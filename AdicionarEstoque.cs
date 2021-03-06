using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaComSQLServer
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            PreencherDataEstoque();
            pesquisar();
            comboForne();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            mostraCorFundo();
        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [cadastroProdutos] WHERE codigoBarra LIKE '%" + EstoqueAdicionar.Text + "%' ORDER BY nomeProduto";

            SqlDataAdapter dta = new SqlDataAdapter(pesquisar, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            dataGridView1.DataSource = table;

            try
            {
                sqlcon.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void EstoqueAdicionar_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisar();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            mostraCorFundo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string taNoBanco = "SELECT * FROM cadastroProdutos WHERE codigoBarra = '" + EstoqueAdicionar.Text + "'";
            string selectEstoque = "SELECT * FROM Estoque WHERE codigoBarra = '" + EstoqueAdicionar.Text + "'";

            SqlDataAdapter dataAdapterEstoque = new SqlDataAdapter(selectEstoque, sqlcon);

            DataTable tableEstoque = new DataTable();

            dataAdapterEstoque.Fill(tableEstoque);

            if (tableEstoque.Rows.Count > 0)
            {
                MessageBox.Show("Produto já cadastrado no sistema.Utilize o campo Alterar estoque para alterar alguma informação", "Já Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                SqlDataAdapter dta = new SqlDataAdapter(taNoBanco, sqlcon);

                DataTable table = new DataTable();

                dta.Fill(table);

                try
                {
                    sqlcon.Open();
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Insira as Informações abaixo para cadastrar o produto no estoque");

                        int index = dataGridView1.CurrentCell.RowIndex;
                        codEstoque.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        nomeText.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        //QuantidadeText.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        precoText.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
                        fornceEsoque.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        groupMostrarEstoque.Visible = true;
                        //codEstoque.Text = dataGridView1.Rows[index].Cells[]

                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado no sistema");
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    sqlcon.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string addEstoque = "INSERT INTO Estoque(codigoBarra, nomeProduto, quantidade , dataEntrada, horarioEntrada, precoVenda, fornecedor, distribuidora, nomeConferente) VALUES (@cod,@nome,@quant, @date, @hor,@preco, @forn,@dist,@confe)";

            SqlCommand cmd = new SqlCommand(addEstoque, sqlcon);

            cmd.Parameters.AddWithValue("@cod", codEstoque.Text);
            cmd.Parameters.AddWithValue("@nome", nomeText.Text);
            cmd.Parameters.AddWithValue("@quant", quantEstoque.Text);
            cmd.Parameters.AddWithValue("@date", dataEstoque.Value);
            cmd.Parameters.AddWithValue("@hor", dataEstoque.Text);
            cmd.Parameters.AddWithValue("@preco", precoText.Text);
            cmd.Parameters.AddWithValue("@forn", fornceEsoque.Text);
            cmd.Parameters.AddWithValue("@dist", distEstoque.Text);
            cmd.Parameters.AddWithValue("@confe", confeEstque.Text);

            try
             {
                 sqlcon.Open();
                 checarSeExiste();
                 cmd.ExecuteNonQuery();
                 //baixaProduto();
                 MessageBox.Show("Produto adicionado ao estoque");
             }
             catch (Exception E)
             {
                 MessageBox.Show(E.Message);
             }
             finally
            {
                 sqlcon.Close();
             }
        }

        void comboForne()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Fornecedores";

            SqlCommand cmd = new SqlCommand(select, sqlcon);
            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            { 
                while (reader.Read())
                {
                    string forne = reader["nomeFornecedor"].ToString();
                    fornceEsoque.Items.Add(forne);
                }
            }catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            EstoqueAdicionar.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        void checarSeExiste()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string taNoBanco = "SELECT * FROM Estoque WHERE codigoBarra = '" + EstoqueAdicionar.Text + "'";

            SqlDataAdapter dta = new SqlDataAdapter(taNoBanco, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            try
            {
                sqlcon.Open();
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Produto já cadastrado no Estoque");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        void PreencherDataEstoque()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string selectAll = "SELECT * FROM [Estoque]";

            SqlDataAdapter dta = new SqlDataAdapter(selectAll, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            try
            {
                sqlcon.Open();
                dataGridView2.DataSource = table;
            }catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        /*void baixaProduto()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string baixa = "UPDATE CadastroProdutos SET quantidade = @quant WHERE codigoBarra = '" + EstoqueAdicionar.Text + "'";

            SqlCommand cmd = new SqlCommand(baixa, sqlcon);

            int novaQuantidade = Convert.ToInt32(QuantidadeText.Text) - Convert.ToInt32(quantEstoque.Text);

            cmd.Parameters.AddWithValue("@quant", novaQuantidade);

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Baixa com sucesso");
            }catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }*/



        private void Estoque_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            mostraCorFundo();
        }

        void mostraCorFundo()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToInt32(row.Cells[3].Value) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                if (Convert.ToInt32(row.Cells[3].Value) > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (Convert.ToInt32(row.Cells[3].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dataGridView2_Sorted(object sender, EventArgs e)
        {
            mostraCorFundo();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            //mostraCorFundo();
        }
    }
}

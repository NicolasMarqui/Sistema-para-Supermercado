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
using System.Globalization;

namespace SistemaComSQLServer
{
    public partial class AlterarProd : Form
    {
        public AlterarProd()
        {
            InitializeComponent();
            pesquisar();
            //mostrarFundoVermelho();
            dataGridView1.Refresh();
            preencherEmbalagem();
            preencherForne();
        }

        public static int quantidadeAlterada;
        public static string nomeProdutoAlterado;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubGrupoAlt.Items.Clear();

            if (GrupoAlt.SelectedItem.ToString() == "LIMPEZA")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("DESINFETANTE");
                SubGrupoAlt.Items.Add("SABÃO EM PÓ");
                SubGrupoAlt.Items.Add("ESPONJAS");
                SubGrupoAlt.Items.Add("PANOS");
                SubGrupoAlt.Items.Add("LUVAS");
                SubGrupoAlt.Items.Add("SABONETES");
                SubGrupoAlt.Items.Add("DETERGENTE");
                SubGrupoAlt.Items.Add("DESENGORDURANTE");
                SubGrupoAlt.Items.Add("BALDES");
                SubGrupoAlt.Items.Add("SABÃO EM BARRA");
                SubGrupoAlt.Items.Add("SABÃO EM PÓ");
                SubGrupoAlt.Items.Add("AMACIANTE");
                SubGrupoAlt.Items.Add("ÁGUA SANITÁRIA");
                SubGrupoAlt.Items.Add("MULTIUSO");
                SubGrupoAlt.Items.Add("Outro(a)");

            }
            else if (GrupoAlt.SelectedItem.ToString() == "ALIMENTOS")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("Achocolatado");
                SubGrupoAlt.Items.Add("Açúcar");
                SubGrupoAlt.Items.Add("Adoçante");
                SubGrupoAlt.Items.Add("Arroz");
                SubGrupoAlt.Items.Add("Atum"); SubGrupoAlt.Items.Add("Azeite"); SubGrupoAlt.Items.Add("Azeitona");
                SubGrupoAlt.Items.Add("Batata-Palha"); SubGrupoAlt.Items.Add("Baunilha"); SubGrupoAlt.Items.Add("Biscoito");
                SubGrupoAlt.Items.Add("Bombom"); SubGrupoAlt.Items.Add("Café"); SubGrupoAlt.Items.Add("Caldo");
                SubGrupoAlt.Items.Add("Catchup"); SubGrupoAlt.Items.Add("Cereal"); SubGrupoAlt.Items.Add("Chá");
                SubGrupoAlt.Items.Add("Chocolate"); SubGrupoAlt.Items.Add("Granulado"); SubGrupoAlt.Items.Add("Coco Ralado");
                SubGrupoAlt.Items.Add("Creme de Leite"); SubGrupoAlt.Items.Add("Farinha de Milho"); SubGrupoAlt.Items.Add("Feijão");
                SubGrupoAlt.Items.Add("Fermento"); SubGrupoAlt.Items.Add("Gelatina"); SubGrupoAlt.Items.Add("Geléia");
                SubGrupoAlt.Items.Add("Leite Condensado");
                SubGrupoAlt.Items.Add("Macarrão"); SubGrupoAlt.Items.Add("Maionese"); SubGrupoAlt.Items.Add("Molho");
                SubGrupoAlt.Items.Add("Macarrão"); SubGrupoAlt.Items.Add("Maionese"); SubGrupoAlt.Items.Add("Molho");
                SubGrupoAlt.Items.Add("Mostarda"); SubGrupoAlt.Items.Add("Polpa de Tomate"); SubGrupoAlt.Items.Add("Polvilho");
                SubGrupoAlt.Items.Add("Sagu"); SubGrupoAlt.Items.Add("Sal"); SubGrupoAlt.Items.Add("Sal Grosso");
                SubGrupoAlt.Items.Add("Salsicha"); SubGrupoAlt.Items.Add("Sardinha"); SubGrupoAlt.Items.Add("Sopa");
                SubGrupoAlt.Items.Add("Tempero"); SubGrupoAlt.Items.Add("Outro(a)");
            }
            else if (GrupoAlt.SelectedItem.ToString() == "FRIOS")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("Bacon");
                SubGrupoAlt.Items.Add("Chester");
                SubGrupoAlt.Items.Add("Gordura Vegetal");
                SubGrupoAlt.Items.Add("Hambúrguer"); SubGrupoAlt.Items.Add("Iogurte"); SubGrupoAlt.Items.Add("Leite");
                SubGrupoAlt.Items.Add("Linguiça"); SubGrupoAlt.Items.Add("Manteiga"); SubGrupoAlt.Items.Add("Margarina");
                SubGrupoAlt.Items.Add("Mortadela"); SubGrupoAlt.Items.Add("Nata"); SubGrupoAlt.Items.Add("Patê");
                SubGrupoAlt.Items.Add("Peito de Peru"); SubGrupoAlt.Items.Add("Presunto"); SubGrupoAlt.Items.Add("Queijo");
                SubGrupoAlt.Items.Add("Queijo Ralado"); SubGrupoAlt.Items.Add("Requeijão"); SubGrupoAlt.Items.Add("Ricota");
                SubGrupoAlt.Items.Add("Salame"); SubGrupoAlt.Items.Add("Outro(a)");
            }
            else if (GrupoAlt.SelectedItem.ToString() == "BEBIDAS")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("Água");
                SubGrupoAlt.Items.Add("Água de Coco");
                SubGrupoAlt.Items.Add("Água Tônica");
                SubGrupoAlt.Items.Add("Cerveja"); SubGrupoAlt.Items.Add("Champagne"); SubGrupoAlt.Items.Add("Licor");
                SubGrupoAlt.Items.Add("Refrigerante"); SubGrupoAlt.Items.Add("Rum"); SubGrupoAlt.Items.Add("Suco");
                SubGrupoAlt.Items.Add("Vinho"); SubGrupoAlt.Items.Add("Vodca"); SubGrupoAlt.Items.Add("Uisque");
                SubGrupoAlt.Items.Add("Leite de Coco"); SubGrupoAlt.Items.Add("Leite"); SubGrupoAlt.Items.Add("Iogurte");
                SubGrupoAlt.Items.Add("Outro(a)");
            }
            else if (GrupoAlt.SelectedItem.ToString() == "DOCES")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("BOLACHA");
                SubGrupoAlt.Items.Add("BOLACHA");
                SubGrupoAlt.Items.Add("BOLACHA");
                SubGrupoAlt.Items.Add("BOLACHA");
            }
            else if (GrupoAlt.SelectedItem.ToString() == "Carnes")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("Bovina");
                SubGrupoAlt.Items.Add("Frango");
                SubGrupoAlt.Items.Add("Miúdos");
                SubGrupoAlt.Items.Add("Peixe"); SubGrupoAlt.Items.Add("Porco"); SubGrupoAlt.Items.Add("Outro(a)");
            }
            else if (GrupoAlt.SelectedItem.ToString() == "FRUTAS,VERDURAS E LEGUMES")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("Abacate");
                SubGrupoAlt.Items.Add("Abacaxi");
                SubGrupoAlt.Items.Add("Abobrinha");
                SubGrupoAlt.Items.Add("Agrião"); SubGrupoAlt.Items.Add("Alface"); SubGrupoAlt.Items.Add("Alho");
                SubGrupoAlt.Items.Add("Banana"); SubGrupoAlt.Items.Add("Batata"); SubGrupoAlt.Items.Add("Berinjela");
                SubGrupoAlt.Items.Add("Beterraba"); SubGrupoAlt.Items.Add("Brócolis"); SubGrupoAlt.Items.Add("Cebola");
                SubGrupoAlt.Items.Add("Chu-Chu"); SubGrupoAlt.Items.Add("Couve"); SubGrupoAlt.Items.Add("Espinafre");
                SubGrupoAlt.Items.Add("Goiaba"); SubGrupoAlt.Items.Add("Laranja"); SubGrupoAlt.Items.Add("Maça");
                SubGrupoAlt.Items.Add("Mamão"); SubGrupoAlt.Items.Add("Manjericão"); SubGrupoAlt.Items.Add("Melancia");
                SubGrupoAlt.Items.Add("Melão"); SubGrupoAlt.Items.Add("Ovos"); SubGrupoAlt.Items.Add("Pêra");
                SubGrupoAlt.Items.Add("Pimentão"); SubGrupoAlt.Items.Add("Repolho"); SubGrupoAlt.Items.Add("Rúcula");
                SubGrupoAlt.Items.Add("Salsinha"); SubGrupoAlt.Items.Add("Tomate"); SubGrupoAlt.Items.Add("Uva");
                SubGrupoAlt.Items.Add("Vagem"); SubGrupoAlt.Items.Add("Ervilha"); SubGrupoAlt.Items.Add("Palmito");
                SubGrupoAlt.Items.Add("Milho"); SubGrupoAlt.Items.Add("Pepino"); SubGrupoAlt.Items.Add("Outro(a)");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AlterarProd_PaddingChanged(object sender, EventArgs e)
        {

        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [cadastroProdutos] WHERE codigoBarra LIKE '%" + PesquisarCod.Text + "%' ORDER BY idProd";

            SqlDataAdapter dta = new SqlDataAdapter(pesquisar, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            dataGridView1.DataSource = table;

            try
            {
                sqlcon.Open();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void PesquisarCod_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisar();
            //mostrarFundoVermelho();
            dataGridView1.Refresh();
        }

        string nomeB;
        decimal vlCompra;
        decimal vlVenda;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nomeB = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                NomeAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                GrupoAlt.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                SubGrupoAlt.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxEmbalagem.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                //QuantidadeAlt.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                comboBoxForn.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                CNPJAlt.Text = PrecoCompraAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                //PrecoCompraAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                PrecoCompraAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                PrecoVendaAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                CodigoAlt.Text = nomeB.ToString();
            }
        }

        bool isEmpty = false;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE cadastroProdutos SET codigoBarra = @codigoBarra, nomeProduto = @nomeProduto, grupo = @grupo,subGrupo = @subGrupo,embalagem = @embalagem,fabricante = @fabricante,CNPJ = @CNPJ,precoCompra = @PrecoCompra,precoVenda = @precoVenda WHERE (codigoBarra = '" + nomeB + "')";

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            cmd.Parameters.AddWithValue("@codigoBarra", CodigoAlt.Text);
            cmd.Parameters.AddWithValue("@nomeProduto", NomeAlt.Text);
            cmd.Parameters.AddWithValue("@grupo", GrupoAlt.SelectedItem);
            cmd.Parameters.AddWithValue("@subGrupo", SubGrupoAlt.SelectedItem);
            cmd.Parameters.AddWithValue("@embalagem", comboBoxEmbalagem.SelectedItem);
            cmd.Parameters.AddWithValue("@fabricante", comboBoxForn.SelectedItem);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJAlt.Text);
            cmd.Parameters.AddWithValue("@precoCompra", PrecoCompraAlt.Text);
            cmd.Parameters.AddWithValue("@precoVenda", PrecoVendaAlt.Text);

            try
            {
                
                int index = dataGridView1.CurrentCell.RowIndex;



                if (String.IsNullOrEmpty(CodigoAlt.Text))
                {
                    MessageBox.Show("O campo Código de Barras não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(NomeAlt.Text))
                {
                    MessageBox.Show("O campo Nome não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(GrupoAlt.Text))
                {
                    MessageBox.Show("O campo Grupo não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(SubGrupoAlt.Text))
                {
                    MessageBox.Show("O campo Sub Grupo não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(comboBoxEmbalagem.Text))
                {
                    MessageBox.Show("O campo Embalagem não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(comboBoxForn.Text))
                {
                    MessageBox.Show("O campo Fornecedor não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(PrecoCompraAlt.Text))
                {
                    MessageBox.Show("O campo Preço Compra não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(PrecoVendaAlt.Text))
                {
                    MessageBox.Show("O campo Preço Venda não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                sqlcon.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (CodigoAlt.Text.Equals(row.Cells[1].Value.ToString()) && NomeAlt.Text.Equals(row.Cells[2].Value.ToString()) && GrupoAlt.SelectedText.Equals(row.Cells[3].Value.ToString()) && SubGrupoAlt.SelectedText.Equals(row.Cells[4].Value.ToString()) && comboBoxEmbalagem.SelectedText.Equals(row.Cells[5].Value.ToString()) && comboBoxForn.SelectedText.Equals(row.Cells[6].Value.ToString()) && CNPJAlt.Text.Equals(row.Cells[7].Value.ToString()) && PrecoCompraAlt.Text.Equals(row.Cells[8].Value.ToString()) && PrecoVendaAlt.Text.Equals(row.Cells[9].Value.ToString()))
                    {
                        MessageBox.Show("Nenhuma alteração feita", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isEmpty = true;
                    }
                }

                if (isEmpty.Equals(false))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Atualizado com sucesso");
                    NomeAlt.Clear();
                    GrupoAlt.Text = "";
                    SubGrupoAlt.Text = "";

                    if (Convert.ToInt64(CodigoAlt.Text) != Convert.ToInt64(dataGridView1.CurrentRow.Cells[1].Value))
                    {
                        if (MessageBox.Show("Você alterou o código de " + dataGridView1.CurrentRow.Cells[1].Value + " para " + CodigoAlt.Text + ". Deseja fazer essa alteração no estoque?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            alterarCodigoEstoque();
                        }
                    }
                    limparCampos();


                }
            
                    
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
    
        }

        void alterarCodigoEstoque()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE Estoque SET codigoBarra = @cod WHERE codigoBarra = '" + dataGridView1.CurrentRow.Cells[1].Value + "'";
            string select = "SELECT * from Estoque WHERE codigoBarra = '" + dataGridView1.CurrentRow.Cells[1].Value + "'";

            sqlcon.Open();

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            //SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            //DataTable table = new DataTable();

            //dta.Fill(table);

            cmd.Parameters.AddWithValue("@cod", CodigoAlt.Text);

            try
            {
                //if(table.Rows.Count < 0)
                //{
                    //MessageBox.Show("Ops, Parece que esse código de barras não está cadastrado no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Código de Barras Alterado com sucesso no estoque");
                //}
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

        private void AlterarProd_Load(object sender, EventArgs e)
        {
            //mostrarFundoVermelho();
            GrupoAlt.Items.Add("LIMPEZA");
            GrupoAlt.Items.Add("ALIMENTOS");
            GrupoAlt.Items.Add("FRUTAS,VERDURAS E LEGUMES");
            GrupoAlt.Items.Add("FRIOS");
            GrupoAlt.Items.Add("BEBIDAS");
            GrupoAlt.Items.Add("DOCES");
            GrupoAlt.Items.Add("CARNES");
            GrupoAlt.Items.Add("HIGIENE");
            dataGridView1.Refresh();
        }

        /*void mostrarFundoVermelho()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                if (Convert.ToInt32(row.Cells[6].Value) > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (Convert.ToInt32(row.Cells[6].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }*/

        void limparCampos()
        {
            CodigoAlt.Clear();
            GrupoAlt.Text = "";
            comboBoxEmbalagem.Text = "";
            comboBoxForn.Text = "";
            CNPJAlt.Clear();
            PrecoCompraAlt.Clear();
            PrecoVendaAlt.Clear();
        }

        void preencherEmbalagem()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string mostrar = "SELECT * FROM [Embalagens]";

            SqlCommand cmd = new SqlCommand(mostrar, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string forne = reader["nomeEmbalagem"].ToString();
                    comboBoxEmbalagem.Items.Add(forne);
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

        void preencherForne()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string mostrar = "SELECT * FROM [Fornecedores]";

            SqlCommand cmd = new SqlCommand(mostrar, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string forne = reader["nomeFornecedor"].ToString();
                    comboBoxForn.Items.Add(forne);
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

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            //mostrarFundoVermelho();
        }

        private void btnRemoverAlterarProd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string delete = "DELETE FROM cadastroProdutos WHERE codigoBarra = '" + CodigoAlt.Text + "'";

            SqlCommand cmd = new SqlCommand(delete, sqlcon);

            try
            {
                sqlcon.Open();
                if (MessageBox.Show("Deseja realmente excluir o produto " + NomeAlt.Text + " do sistema?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto removido com sucesso");
                    limparCampos();
                }
                else
                {

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
}


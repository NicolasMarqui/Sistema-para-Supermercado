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

/*
 * 
 * Falta arrumar a parte que só adiciona a quantidade se especificar a row
 * 
 * 
 * */

namespace SistemaComSQLServer
{
    public partial class PedidoFornecedor : Form
    {
        public PedidoFornecedor()
        {
            InitializeComponent();
            dataGridView1.Refresh();
        }

        private void PedidoFornecedor_Load(object sender, EventArgs e)
        {
            preencherData();
            preencherProduto();
            preencherData2();
            //label6.Text = dataGridView2.Rows[6].Cells[6].Value.ToString();
            dataGridView1.Refresh();
        }

        void preencherData()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Fornecedores";

            SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            try
            {
                sqlcon.Open();
                dataGridView1.DataSource = table;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFornece.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            telefoneForne.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailFornece.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        void preencherProduto()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM CadastroProdutos";

            SqlCommand cmd = new SqlCommand(select, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string forne = reader["nomeProduto"].ToString();
                    comboBox1.Items.Add(forne);
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

        private void msgBox_Click(object sender, EventArgs e)
        {
            msgBox.Text = "Caro " + nomeFornece.Text + " , gostaria de pedir mais " + numericUpDown1.Value + " unidades do produto " + comboBox1.Text;
        }

        int somar;

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE CadastroProdutos SET quantidade = @quant WHERE nomeProduto = '" + comboBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            //int index = dataGridView2.CurrentCell.RowIndex;

            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if(Convert.ToString(dataGridView2.Rows[i].Cells[1].Value) == nomeFornece.Text)
                {
                    somar = Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value) + Convert.ToInt32(numericUpDown1.Value);

                }
                else
                {
                    somar = Convert.ToInt32(label6.Text) + Convert.ToInt32(numericUpDown1.Value);
                }
            }

             cmd.Parameters.AddWithValue("@quant", somar);

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(numericUpDown1.Value.ToString());
                MessageBox.Show(somar.ToString());
                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }*/

            MessageBox.Show("Email para " + emailFornece.Text + " enviado com Sucesso");
            limparDados();
        }

        void preencherData2()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM CadastroProdutos";

            SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            try
            {
                sqlcon.Open();
                dataGridView2.DataSource = table;
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

        void limparDados()
        {
            nomeFornece.Clear();
            telefoneForne.Clear();
            emailFornece.Clear();
            comboBox1.Text = "";
            numericUpDown1.Value = 0;
            msgBox.Clear();
        }
    }
}

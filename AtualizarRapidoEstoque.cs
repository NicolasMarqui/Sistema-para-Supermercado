using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComSQLServer
{
    public partial class EstoqueRapido : Form
    {
        public EstoqueRapido()
        {
            InitializeComponent();
            PreencherDataEstoque();
            pesquisar();
            mostrarFundoVermelho();
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
            mostrarNome.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            labelPegarQuant.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [Estoque] WHERE nomeProduto LIKE '%" + textBox1.Text + "%' ORDER BY nomeProduto";

            SqlDataAdapter dta = new SqlDataAdapter(pesquisar, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            dataGridView1.DataSource = table;

            try
            {
                sqlcon.Open();
                mostrarFundoVermelho();
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

        private void btnRapido_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string updateQuantidadeEstoque = "UPDATE Estoque SET quantidade = @quant WHERE nomeProduto = @nome";

            SqlCommand cmd = new SqlCommand(updateQuantidadeEstoque, sqlcon);

            int novaQuantidadeSomada = Convert.ToInt32(labelPegarQuant.Text) + Convert.ToInt32(numericUpDown1.Value);

            cmd.Parameters.AddWithValue("@quant", novaQuantidadeSomada);
            cmd.Parameters.AddWithValue("@nome", mostrarNome.Text);

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("+ " + numericUpDown1.Value + " unidades do produto " + mostrarNome.Text + " foram adicionadas ao estoque", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EstoqueRapido_Load(object sender, EventArgs e)
        {
            pesquisar();
            mostrarFundoVermelho();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisar();
        }

        void limparCampos()
        {
            textBox1.Clear();
            mostrarNome.Text = "-";
            numericUpDown1.Value = 0;
        }

        void mostrarFundoVermelho()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            mostrarFundoVermelho();
        }
    }
}

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
    public partial class AltFornecedor : Form
    {
        public AltFornecedor()
        {
            InitializeComponent();
        }

        void preencherForne()
        {
            dataGridView1.Refresh();
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string mostrarForn = "SELECT * FROM Fornecedores";

            SqlDataAdapter dta = new SqlDataAdapter(mostrarForn, sqlcon);

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

        private void AltFornecedor_Load(object sender, EventArgs e)
        {
            preencherForne();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFornce.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            teleForne.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CNPJFornce.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailForne.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            endeForne.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            labelId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        bool isEmpty = false;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string att = "UPDATE Fornecedores SET nomeFornecedor = @nome, telefone = @tel,CNPJ = @CNPJ, email = @email,endereco = @ende WHERE idFornecedor = '" + labelId.Text + "'";

            SqlCommand cmd = new SqlCommand(att, sqlcon);

            cmd.Parameters.AddWithValue("@nome", nomeFornce.Text);
            cmd.Parameters.AddWithValue("@tel", teleForne.Text);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJFornce.Text);
            cmd.Parameters.AddWithValue("@email", emailForne.Text);
            cmd.Parameters.AddWithValue("@ende", endeForne.Text);

            try
            {
                sqlcon.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(nomeFornce.Text.Equals(row.Cells[1].Value.ToString()) && teleForne.Text.Equals(row.Cells[2].Value.ToString()) && CNPJFornce.Text.Equals(row.Cells[3].Value.ToString()) && emailForne.Text.Equals(row.Cells[4].Value.ToString()) && endeForne.Text.Equals(row.Cells[5].Value.ToString()))
                    {
                        MessageBox.Show("Nenhuma alteração foi feita", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isEmpty = true;
                    }
                }

                if (isEmpty.Equals(false))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    limparCampos();
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

        void limparCampos()
        {
            nomeFornce.Clear();
            teleForne.Clear();
            CNPJFornce.Clear();
            emailForne.Clear();
            endeForne.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string delete = "DELETE FROM Fornecedores WHERE nomeFornecedor = '" + nomeFornce.Text + "'";

            SqlCommand cmd = new SqlCommand(delete, sqlcon);

            try
            {
                sqlcon.Open();
                if (MessageBox.Show("Deseja realmente excluir o fornecedor " + nomeFornce.Text + " do sistema?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor removido com sucesso");
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

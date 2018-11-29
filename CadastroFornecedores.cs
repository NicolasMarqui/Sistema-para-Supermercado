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
    public partial class CadastrarFornecedores : Form
    {
        public CadastrarFornecedores()
        {
            InitializeComponent();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkIfExists();
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string cadastrar = "INSERT INTO Fornecedores(nomeFornecedor, telefone, CNPJ, email, endereco) VALUES (@nomeFornecedor,@telefone,@CNPJ,@email,@endereco)";

            SqlCommand cmd = new SqlCommand(cadastrar, sqlcon);

            string select = "SELECT * FROM Fornecedores WHERE nomeFornecedor = '" + nomeFornce.Text + "'";

            SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ops, esse fornecedor já está cadastrado");
            }
            else
            {

                cmd.Parameters.AddWithValue("@nomeFornecedor", nomeFornce.Text);
                cmd.Parameters.AddWithValue("@telefone", teleForne.Text);
                cmd.Parameters.AddWithValue("@CNPJ", CNPJFornce.Text);
                cmd.Parameters.AddWithValue("@email", emailForne.Text);
                cmd.Parameters.AddWithValue("@endereco", endeForne.Text);

                try
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Forncedor cadastrado com sucesso");
                    limparCampos();
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

        private void CadastrarFornecedores_Load(object sender, EventArgs e)
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
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PedidoFornecedor ped = new PedidoFornecedor();
            ped.ShowDialog();
        }

        void limparCampos()
        {
            nomeFornce.Clear();
            teleForne.Clear();
            CNPJFornce.Clear();
            emailForne.Clear();
            endeForne.Clear();
        }

        void checkIfExists()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Fornecedores";

            SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Ops, esse fornecedor já está cadastrado");
            }
        }
    }
}

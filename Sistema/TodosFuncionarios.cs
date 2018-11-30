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
    public partial class TodosFuncionarios : Form
    {
        public TodosFuncionarios()
        {
            InitializeComponent();
        }

        private void TodosFuncionarios_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Login";

            SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            DataTable table = new DataTable();

            sqlcon.Open();

            dta.Fill(table);

            try
            {
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string delete = "DELETE FROM Login WHERE username = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";

            SqlCommand cmd = new SqlCommand(delete, sqlcon);

            try
            {
                sqlcon.Open();
                if (MessageBox.Show("Deseja realmente excluir o funcionário " + dataGridView1.CurrentRow.Cells[0].Value + " do sistema?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario removido com sucesso");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComSQLServer
{
    public partial class Relacao : Form
    {
        public Relacao()
        {
            InitializeComponent();
        }

        void preencherNome()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Estoque";

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

        private void Relacao_Load(object sender, EventArgs e)
        {
            preencherNome();
            contarProdutos();
            addProd();
        }

        void contarProdutos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                listBox1.Items.Add(row.Cells[7].Value);
            }

            for(int i = 0;i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items.Contains(listBox1.Items[i])){
                    listBox1.Items.Remove(i);
                }
            }


        }

        void addProd()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT nomeProduto FROM CadastroProdutos WHERE fabricante = '" + listBox1.SelectedItem + "'";

            SqlCommand cmd = new SqlCommand(select, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.BeginUpdate();
            listBox2.Items.Clear();

            while (reader.Read())
            {
                listBox2.Items.Add(reader.GetString(0));
            }

            reader.Close();
            sqlcon.Close();
            listBox1.EndUpdate();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            addProd();
            
        }

        void delete()
        {
            
        }
    }
}

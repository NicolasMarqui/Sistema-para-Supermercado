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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
            pesquisar();
        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [cadastroProdutos] WHERE codigoBarra LIKE '%" + CodigoCaixa.Text + "%' ORDER BY nomeProduto";

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

        private void CodigoCaixa_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("add");
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome do Produto");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Preço");

            //foreach(DataGridViewRow row in dataGridView1.Rows)
            //{

            for(int i = 0;i < dataGridView1.Rows.Count; i++)
            {
                dt.Rows.Add();
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int columnIindex = dataGridView1.CurrentCell.ColumnIndex;
                dt.Rows.Add(dataGridView1.Rows[rowIndex].Cells[columnIindex].Value);
            }
                /*int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int columnIindex = dataGridView1.CurrentCell.ColumnIndex;
                dt.Rows.Add(dataGridView1.Rows[rowIndex].Cells[columnIindex].Value);
            //}*/

            dataGridView2.DataSource = dt;
        }
    }
}

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
        public static decimal valorTelaPagamento = 0;
        decimal soma;

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

        string quantidadeTabelaUm;
        string quantidadeTabelaUm2;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal result = 0;
            soma = 0;

            try
            {
                /*dataGridView2.DataSource = dataGridView1;
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();*/
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string quantidadeInput = InputDialogBox.Show("Quantidade");
                    quantidadeTabelaUm = row.Cells[3].Value.ToString();
                    label3.Text = Convert.ToInt32(quantidadeInput).ToString();

                    string nomeDataDois = row.Cells[2].Value.ToString();
                    string precoDataDois = row.Cells[10].Value.ToString();
                    row.Cells[3].Value = quantidadeInput.ToString();
                    string quantidadeData2 = row.Cells[3].Value.ToString();

                    dataGridView2.Rows.Add(nomeDataDois, quantidadeData2, precoDataDois);
                    labelTotalItem.Text = precoDataDois.ToString();
                    labelQuantidade.Text = quantidadeInput.ToString();

                }
                
                for(int i = 0;i < dataGridView2.Rows.Count;i++)
                {
                    decimal teste = Convert.ToDecimal(dataGridView2.Rows[i].Cells[1].Value) * Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value);
                    soma += teste;
                }

                labelTotalCompra.Text = soma.ToString();
                valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);

            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                for(int i = 0;i < dataGridView1.Rows.Count;i++)
                {
                    dataGridView2.DataSource = row.Cells[i].Value;
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Pagamento pagar = new Pagamento();
            pagar.ShowDialog();

            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE cadastroProdutos SET quantidade = @quantidade";

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            cmd.Parameters.AddWithValue("@quantidade", (Convert.ToInt32(label3.Text) - 15));

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Produto atualizado carai");
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clique duas vezes em cima de uma linha para excluir o produto");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        decimal id,id2;

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView2.SelectedRows)
            {
                id = Convert.ToDecimal(row.Cells[2].Value);
                id2 = Convert.ToDecimal(row.Cells[1].Value);
                dataGridView2.Rows.RemoveAt(row.Index);

                soma -= (Convert.ToDecimal(id)) * Convert.ToDecimal(id2);
            }

            labelTotalCompra.Text = soma.ToString();
            valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);
        }
    }
}

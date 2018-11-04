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
        bool compraFechada = false;
        

        public Caixa()
        {
            InitializeComponent();
            pesquisar();
        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [Estoque] WHERE codigoBarra LIKE '%" + CodigoCaixa.Text + "%' ORDER BY nomeProduto";

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
        int valorAposQuantidade = 0;

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
                    quantidadeTabelaUm = row.Cells[2].Value.ToString();

                    string nomeDataDois = row.Cells[1].Value.ToString();
                    string precoDataDois = row.Cells[5].Value.ToString();
                    valorAposQuantidade = Convert.ToInt32(row.Cells[2].Value) - Convert.ToInt32(quantidadeInput);

                    if (valorAposQuantidade < 0)
                    {
                        MessageBox.Show("Não há quantidades desse item no estoque");
                    }
                    else
                    {
                        row.Cells[2].Value = valorAposQuantidade.ToString();
                        string quantidadeData2 = quantidadeInput.ToString();
                        dataGridView2.Rows.Add(nomeDataDois, quantidadeData2, precoDataDois);
                        labelTotalItem.Text = precoDataDois.ToString();
                        labelQuantidade.Text = quantidadeInput.ToString();
                    }

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
            compraFechada = true;
            Pagamento pagar = new Pagamento();
            pagar.ShowDialog();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

                int j = dataGridView1.SelectedCells[0].RowIndex;

                string select = "UPDATE Estoque set quantidade = @quant WHERE nomeProduto = '" + dataGridView1.Rows[j].Cells[1].Value + "'";

                SqlCommand cmd = new SqlCommand(select, sqlcon);

                cmd.Parameters.AddWithValue("@quant", dataGridView1.Rows[j].Cells[2].Value);

                try
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Baixa no estoque");
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clique duas vezes em cima de uma linha para excluir o produto");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        decimal id,id2;

        private void Caixa_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView2.SelectedRows)
            {
                id = Convert.ToDecimal(row.Cells[2].Value);
                id2 = Convert.ToDecimal(row.Cells[1].Value);
                dataGridView2.Rows.RemoveAt(row.Index);
                soma -= (Convert.ToDecimal(id)) * Convert.ToDecimal(id2);
            }

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int teste = Convert.ToInt32(row.Cells[2].Value) + Convert.ToInt32(id2);
                row.Cells[2].Value = teste;
            }

            
            labelTotalCompra.Text = soma.ToString();
            valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);
            labelTotalItem.Text = "0.00";
            labelQuantidade.Text = "0";
        }
    }
}

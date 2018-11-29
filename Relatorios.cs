using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace SistemaComSQLServer
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            mostraCorFundo();
        }


        int somaTabelaVendas = 0;

        private void Relatorio_Load(object sender, EventArgs e)
        {
            preencherVendas();
            contarRowsVenda();
            pesquisaVendas();
            criarRowMultiplicar();
            preencherEstoque();
            mostraCorFundo();
            somarCores();
            PesquisaPorNomeEstoque();
            preencherFornce();
            contarForne();
        }

        void preencherVendas()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM relatorioCaixa";

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

        decimal precoTotalConta = 0;

        void contarRowsVenda()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                somaTabelaVendas++;

                decimal somaDeTodas = Convert.ToDecimal(row.Cells[2].Value);
                decimal qunatidade = Convert.ToDecimal(row.Cells[1].Value);

                precoTotalConta = precoTotalConta + (somaDeTodas * qunatidade);
            }

            labelValorTotal.Text = precoTotalConta.ToString();

            labelMostrarRowsVendas.Text = somaTabelaVendas.ToString();
        }

        private void brnCaixa_Click(object sender, EventArgs e)
        {
            labelVendas.Visible = true;
            groupBox1.Visible = true;
            btnExpotarVendas.Visible = true;
            textBoxVendas.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            labelEstoque.Visible = false;
            textBoxEstoque.Visible = false;
            groupBoxEstoque.Visible = false;
            btnExportarEstoque.Visible = false;
            dataGridView3.Visible = false;
            groupBoxFornecedores.Visible = false;
            btnExportarForne.Visible = false;
            pesquisaNomeForne.Visible = false;
            textBoxForne.Visible = false;
        }

        void pesquisaVendas()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM relatorioCaixa WHERE diaVenda LIKE '%" + textBoxVendas.Text + "%' ORDER BY diaVenda";

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

        private void textBoxVendas_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisaVendas();
        }

        

        private void btnExpotarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void criarRowMultiplicar()
        {

            decimal valorMultiplicado = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                //string quantidade = row.Cells[1].Value.ToString();
                //string valorUnitario = row.Cells[2].Value.ToString();

                //valorMultiplicado = Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[1].Value);

                //dataGridView1.Rows.Add(valorMultiplicado);
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            labelVendas.Visible = false;
            groupBox1.Visible = false;
            btnExpotarVendas.Visible = false;
            textBoxVendas.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            labelEstoque.Visible = true;
            textBoxEstoque.Visible = true;
            groupBoxEstoque.Visible = true;
            btnExportarEstoque.Visible = true;
            dataGridView3.Visible = false;
            groupBoxFornecedores.Visible = false;
            btnExportarForne.Visible = false;
            pesquisaNomeForne.Visible = false;
            textBoxForne.Visible = false;
        }

        void preencherEstoque()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Estoque";

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

        void mostraCorFundo()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
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

        private void dataGridView2_Sorted(object sender, EventArgs e)
        {
            mostraCorFundo();
        }

        int somaVermelho = 0, somaAmarelo = 0, somaVerde = 0;
        void somarCores()
        {
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                if(row.DefaultCellStyle.BackColor == Color.Red)
                {
                    somaVermelho++;
                }else if(row.DefaultCellStyle.BackColor == Color.Yellow)
                {
                    somaAmarelo++;
                }
                else
                {
                    somaVerde++;
                }
            }

            labelProdutoAmarelo.Text = somaAmarelo.ToString();
            labelProdutoVerde.Text = somaVerde.ToString();
            labelProdutoVermelho.Text = somaVermelho.ToString();
        }

        private void textBoxEstoque_KeyUp(object sender, KeyEventArgs e)
        {
            PesquisaPorNomeEstoque();
        }

        private void btnForne_Click(object sender, EventArgs e)
        {
            labelVendas.Visible = false;
            groupBox1.Visible = false;
            btnExpotarVendas.Visible = false;
            textBoxVendas.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            labelEstoque.Visible = false;
            textBoxEstoque.Visible = false;
            groupBoxEstoque.Visible = false;
            btnExportarEstoque.Visible = false;
            dataGridView3.Visible = true;
            groupBoxFornecedores.Visible = true;
            btnExportarForne.Visible = true;
            pesquisaNomeForne.Visible = true;
            textBoxForne.Visible = true;
        }

        private void btnExportarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView2.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView2[j, i].Value == null ? "" : dataGridView2[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void PesquisaPorNomeEstoque()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM Estoque WHERE nomeProduto LIKE '%" + textBoxEstoque.Text + "%' ORDER BY id";

            SqlDataAdapter dta = new SqlDataAdapter(pesquisar, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            dataGridView2.DataSource = table;

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

        void preencherFornce()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Fornecedores";

            SqlDataAdapter dta = new SqlDataAdapter(select, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            try
            {
                sqlcon.Open();
                dataGridView3.DataSource = table;
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

        private void btnRelacao_Click(object sender, EventArgs e)
        {
            Relacao rel = new Relacao();
            rel.ShowDialog();
        }

        private void btnExportarForne_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView3.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView3[j, i].Value == null ? "" : dataGridView3[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        int quantidadeFornecedores = 0;

        void contarForne()
        {
            foreach(DataGridViewRow row in dataGridView3.Rows)
            {
                quantidadeFornecedores++;
            }

            labelMostrarForn.Text = quantidadeFornecedores.ToString();
        }
    }
}

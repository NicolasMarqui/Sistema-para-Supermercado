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
using DGVPrinterHelper;
using System.Drawing.Printing;

namespace SistemaComSQLServer
{
    public partial class Caixa : Form
    {
        public static decimal valorTelaPagamento = 0;
        public static decimal pagarCartao = 0;
        Bitmap bitmap;
        decimal soma;
        bool compraFechada = false;
        public static int itens;
        string quantidadeTabelaUm;
        string quantidadeTabelaUm2;
        int valorAposQuantidade = 0;
        bool isCodigo = false;

        public Caixa()
        {
            InitializeComponent();
            pesquisar();
            mostrarFundoVermelho();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            labelNomeCaixa.Text = Login.nomeMenu;
        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [Estoque] WHERE codigoBarra LIKE '%" + CodigoCaixa.Text + "%' ORDER BY id";

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
            //pesquisar();
            mostrarFundoVermelho();
            dataGridView1.Refresh();
            dataGridView2.Refresh();

            if (isCodigo)
            {
                decimal total = 0;
                decimal result = 0;
                soma = 0;

                int teste3;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[0].Cells.Count; j++)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            if (CodigoCaixa.Text.Equals(dataGridView1.Rows[i].Cells[1].Value))
                            {
                                mostrarFundoVermelho();


                                try
                                {
                                    quantidadeTabelaUm = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                    string nomeDataDois = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                    string precoDataDois = dataGridView1.Rows[i].Cells[6].Value.ToString();
                                    string codigoBarra1 = dataGridView1.Rows[i].Cells[6].Value.ToString();
                                    valorAposQuantidade = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) - 1;

                                    //break;

                                    if (valorAposQuantidade < 0)
                                    {
                                        MessageBox.Show("Não há quantidades desse item no estoque");
                                    }
                                    else
                                    {
                                        dataGridView1.Rows[i].Cells[3].Value = valorAposQuantidade.ToString();
                                        string quantidadeData2 = "1";
                                        dataGridView2.Rows.Add(nomeDataDois, precoDataDois, quantidadeData2, codigoBarra1);
                                        labelTotalItem.Text = precoDataDois.ToString();
                                        labelQuantidade.Text = "1";
                                        foreach (DataGridViewRow row in dataGridView2.Rows)
                                        {
                                            decimal teste = Convert.ToDecimal(row.Cells[1].Value) * Convert.ToDecimal(row.Cells[2].Value);
                                            soma += teste;

                                            labelTotalCompra.Text = soma.ToString();
                                            valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);
                                        }
                                    }

                                }
                                catch (Exception E)
                                {
                                    MessageBox.Show(E.Message);
                                }

                                CodigoCaixa.Clear();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                
            }
        }

        void addProdutos()
        {
            decimal total = 0;
            decimal result = 0;
            soma = 0;
            mostrarFundoVermelho();
            string quantidadeInput;

            try
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    quantidadeInput = InputDialogBox.Show("Quantidade");
                    quantidadeTabelaUm = row.Cells[3].Value.ToString();

                    string nomeDataDois = row.Cells[2].Value.ToString();
                    string precoDataDois = row.Cells[6].Value.ToString();
                    string codigoBarra1 = row.Cells[6].Value.ToString();
                    valorAposQuantidade = Convert.ToInt32(row.Cells[3].Value) - Convert.ToInt32(quantidadeInput);

                    if (valorAposQuantidade < 0)
                    {
                        MessageBox.Show("Não há quantidades desse item no estoque");
                    }
                    else
                    {
                        row.Cells[3].Value = valorAposQuantidade.ToString();
                        string quantidadeData2 = quantidadeInput.ToString();
                        dataGridView2.Rows.Add(nomeDataDois, precoDataDois, quantidadeData2, codigoBarra1);
                        labelTotalItem.Text = precoDataDois.ToString();
                        labelQuantidade.Text = quantidadeInput.ToString();
                    }

                }

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    decimal teste = Convert.ToDecimal(dataGridView2.Rows[i].Cells[1].Value) * Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value);
                    soma += teste;
                }

                labelTotalCompra.Text = soma.ToString();
                valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tirarQuantidadeComPergunta();
            mostrarFundoVermelho();
        }

        void tirarQuantidadeComPergunta()
        {
            decimal total = 0;
            decimal result = 0;
            soma = 0;
            mostrarFundoVermelho();
            string quantidadeInput;

            try
            {
                /*dataGridView2.DataSource = dataGridView1;
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();*/
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    quantidadeInput = InputDialogBox.Show("Quantidade");
                    quantidadeTabelaUm = row.Cells[3].Value.ToString();

                    string nomeDataDois = row.Cells[2].Value.ToString();
                    string precoDataDois = row.Cells[6].Value.ToString();
                    string codigoBarra1 = row.Cells[6].Value.ToString();
                    valorAposQuantidade = Convert.ToInt32(row.Cells[3].Value) - Convert.ToInt32(quantidadeInput);

                    if (valorAposQuantidade < 0)
                    {
                        MessageBox.Show("Não há quantidades desse item no estoque");
                    }
                    else
                    {
                        row.Cells[3].Value = valorAposQuantidade.ToString();
                        string quantidadeData2 = quantidadeInput.ToString();
                        dataGridView2.Rows.Add(nomeDataDois,precoDataDois,quantidadeData2,codigoBarra1);
                        labelTotalItem.Text = precoDataDois.ToString();
                        labelQuantidade.Text = quantidadeInput.ToString();
                    }

                }

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    decimal teste = Convert.ToDecimal(dataGridView2.Rows[i].Cells[1].Value) * Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value);
                    soma += teste;
                }

                labelTotalCompra.Text = soma.ToString();
                valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);

            }
            catch (Exception E)
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

        int count = 0;

        public void imprimir()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Obrigado por com comprar";
            printer.PrintDataGridView(dataGridView3);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //deletarNota();
            compraFechada = true;
            panel1.Visible = true;
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
            mostrarFundoVermelho();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            btnAlterar.Enabled = false;
            //deletarNota();
            dataGridView3.RowTemplate.Height = 20;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                id = Convert.ToDecimal(row.Cells[3].Value);
                id2 = Convert.ToDecimal(row.Cells[2].Value);
                dataGridView2.Rows.RemoveAt(row.Index);
                soma -= (Convert.ToDecimal(id)) * Convert.ToDecimal(id2);
            }

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int teste = Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(id2);
                row.Cells[3].Value = teste;
            }

            
            labelTotalCompra.Text = soma.ToString();
            valorTelaPagamento = Convert.ToDecimal(labelTotalCompra.Text);
            labelTotalItem.Text = "0.00";
            labelQuantidade.Text = "0";
        }

        private void dataGridView2_Sorted(object sender, EventArgs e)
        {
            //mostrarFundoVermelho();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            mostrarFundoVermelho();
        }

        private void dataGridView1_Sorted_1(object sender, EventArgs e)
        {
            mostrarFundoVermelho();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modo Código de Barras ativado");
            isCodigo = true;
        }

        void AddCodigoBarra()
        {
            
        }

        private void timerDataCaixa_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            groupBoxMostrarDinheiro.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            labelValorCompra.Text = valorTelaPagamento.ToString();
        }


        bool alterarCompra = false;

        public static string valorPagoCliente;

        private void btnPagar_Click(object sender, EventArgs e)
        {
            alterarCompra = true;
            do
            {
                valorPagoCliente = InputDialogBox.Show("Valor em dinheiro pago");

                if (Convert.ToDecimal(valorPagoCliente) < Convert.ToDecimal(labelValorCompra.Text))
                {
                    MessageBox.Show("Dinheiro Insuficiente");
                }

            } while (Convert.ToDecimal(valorPagoCliente) < Convert.ToDecimal(labelValorCompra.Text));

            if (Convert.ToDecimal(valorPagoCliente) > Convert.ToDecimal(labelValorCompra.Text))
            {
                decimal troco = Convert.ToDecimal(valorPagoCliente) - Convert.ToDecimal(labelValorCompra.Text);

                troco1.Visible = true;
                cifrao.Visible = true;
                valorTroco.Visible = true;
                button1.Visible = true;

                valorTroco.Text = troco.ToString();
                cifrao.BackColor = Color.Green;
                valorTroco.BackColor = Color.Green;
                cifrao.ForeColor = Color.Black;
                valorTroco.ForeColor = Color.Black;

            }

            if (Convert.ToDecimal(valorPagoCliente) == Convert.ToDecimal(labelValorCompra.Text))
            {
                troco1.Visible = true;
                cifrao.Visible = true;
                valorTroco.Visible = true;
                button1.Visible = true;
                valorTroco.Text = "0.00";
                cifrao.BackColor = Color.Green;
                valorTroco.BackColor = Color.Green;
                cifrao.ForeColor = Color.Black;
                valorTroco.ForeColor = Color.Black;
            }
        }

        bool vendaConcluida = false;

        private void button1_Click(object sender, EventArgs e)
        {
            vendaConcluida = true;
            panel2.Visible = true;
            btnImprimir.Visible = true;
            btnVoltarMenu.Visible = true;
            btnCancelarCompra.Visible = true;
            totalCompraNota.Text = labelValorCompra.Text;
            valorTrocoNota.Text = valorPagoCliente;
            labelValorTroco.Text = valorTroco.Text;

            atualizarEstoqueFinalizar();
        }

        void atualizarEstoqueFinalizar()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                dataGridView3.Rows.Add(row.Cells[0].Value, row.Cells[2].Value, row.Cells[3].Value);
            }

            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "UPDATE Estoque set quantidade = @quant WHERE nomeProduto = @nome";

            SqlCommand cmd = new SqlCommand(select, sqlcon);

            sqlcon.Open();

            dataGridView1.Refresh();



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@quant", row.Cells[3].Value);
                cmd.Parameters.AddWithValue("@nome", row.Cells[2].Value);
                cmd.ExecuteNonQuery();
            }

            string colocarRelatorio = "INSERT INTO relatorioCaixa(nomeProduto, quantidade, precoVenda,diaVenda) VALUES (@nome,@quant,@valor,@dia)";

            SqlCommand cmd2 = new SqlCommand(colocarRelatorio, sqlcon);

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@nome", row.Cells[0].Value);
                cmd2.Parameters.AddWithValue("@quant", row.Cells[2].Value);
                cmd2.Parameters.AddWithValue("@valor", row.Cells[3].Value);
                cmd2.Parameters.AddWithValue("@dia", label2.Text);
                cmd2.ExecuteNonQuery();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = panel2.CreateGraphics();
            Size s = panel2.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, panel2.ClientRectangle.Width, panel2.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.imprimir();   


            CaptureScreen();
            PrinterSettings ps = new PrinterSettings();
            ps.Copies = 2;
            IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("473 x 615 mm", 370, 525);
            PrintPreviewDialog ppw = new PrintPreviewDialog();
            ppw.Document = printDocument1;
            ppw.ShowDialog();

            Close();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            if (vendaConcluida)
            {
                Menu menu = new Menu();
                this.Close();
                menu.Show();
            }
            else
            {
                if (MessageBox.Show("Voçê tem certeza que deseka sair para o menu? A comprar não sera salva.", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Menu men = new Menu();
                    this.Close();
                    men.Show();
                }
                else
                {

                }
            }
            
        }



        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (alterarCompra)
            {
                MessageBox.Show("Não é possivel alterar a compra!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(vendaConcluida == false)
            {
                if(MessageBox.Show("Você tem certeza que deseja alterar a comprar? ","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    panel1.Visible = false;
                }
                else
                {

                }
                
            }
        }
        
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btmCartao_Click(object sender, EventArgs e)
        {
            groupBoxMostrarDinheiro.Visible = true;
            pagarCartao = Convert.ToDecimal(labelValorCompra.Text);
            btnPagar.Enabled = false;
            valorTroco.Text = "0.00";
            btnFinalizar.Enabled = false;
            pagarCartaoCredito cart = new pagarCartaoCredito();
            cart.ShowDialog();
            

            if (pagarCartaoCredito.isDone)
            {
                panel2.Visible = true;
                totalCompraNota.Text = labelValorCompra.Text;
                valorTrocoNota.Text = totalCompraNota.Text;
                labelValorTroco.Text = "0.00";
                btnImprimir.Visible = true;
                atualizarEstoqueFinalizar();
            }
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

                if (Convert.ToInt32(row.Cells[3].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (Convert.ToInt32(row.Cells[3].Value) > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
    }
}

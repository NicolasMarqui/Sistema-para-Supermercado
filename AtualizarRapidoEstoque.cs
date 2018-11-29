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
    public partial class AtualizarRapido : Form
    {
        public AtualizarRapido()
        {
            InitializeComponent();
            labelNome.Text = AlterarProd.nomeProdutoAlterado;
            PreencherDataEstoque();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string pegarQuantidadeDataParaAlterarEstoque;
            int somaEstoque = 0;

            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE Estoque SET quantidade = @quantidade WHERE nomeProduto = @nome";

            string diferencaCadastro = "UPDATE cadastroProdutos SET quantidade = @quant WHERE nomeProduto = @nome2";

            SqlCommand cmdProdutos = new SqlCommand(diferencaCadastro, sqlcon);

            int quantidadeProdutAposBaixa = AlterarProd.quantidadeAlterada - Convert.ToInt32(quatidadeNumeric.Value);

            cmdProdutos.Parameters.AddWithValue("@quant",quantidadeProdutAposBaixa);
            cmdProdutos.Parameters.AddWithValue("@nome2", labelNome.Text);

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            pegarQuantidadeDataParaAlterarEstoque = dataGridView1.Rows[0].Cells[1].Value.ToString();
            somaEstoque = Convert.ToInt32(pegarQuantidadeDataParaAlterarEstoque) + Convert.ToInt32(quatidadeNumeric.Value);

            cmd.Parameters.AddWithValue("@quantidade", somaEstoque);
            cmd.Parameters.AddWithValue("@nome", labelNome.Text);

            try
            {
                if(Convert.ToInt32(quatidadeNumeric.Value) > AlterarProd.quantidadeAlterada)
                {
                    MessageBox.Show("Não há quantidade suficiente desse produto");
                }
                else
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    cmdProdutos.ExecuteNonQuery();
                    MessageBox.Show("Quantidade alterada no estoque");
                }
            }catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        void PreencherDataEstoque()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string selectAll = "SELECT quantidade FROM [Estoque] WHERE nomeProduto = '" + labelNome.Text + "'";

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AlterarProd alt = new AlterarProd();
            this.Close();
            alt.ShowDialog();
        }
    }
}

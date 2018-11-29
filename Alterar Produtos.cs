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
using System.Globalization;

namespace SistemaComSQLServer
{
    public partial class AlterarProd : Form
    {
        public AlterarProd()
        {
            InitializeComponent();
            pesquisar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GrupoAlt.SelectedItem.ToString() == "LIMPEZA")
            {
                SubGrupoAlt.Items.Add("DESINFETANTE");
                SubGrupoAlt.Items.Add("OMO");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AlterarProd_PaddingChanged(object sender, EventArgs e)
        {

        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [cadastroProdutos] WHERE codigoBarra LIKE '%" + PesquisarCod.Text + "%' ORDER BY nomeProduto";

            SqlDataAdapter dta = new SqlDataAdapter(pesquisar, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            dataGridView1.DataSource = table;

            try
            {
                sqlcon.Open();
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

        private void PesquisarCod_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisar();
        }

        long nomeB;
        decimal vlCompra;
        decimal vlVenda;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeB = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            NomeAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            GrupoAlt.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if(GrupoAlt.SelectedItem.ToString() == "LIMPEZA"){
                //SubGrupoCad.SelectedItem = "";
                SubGrupoAlt.Items.Add("DESINFETANTE");
            }
            else if (GrupoAlt.SelectedItem.ToString() == "COMIDA")
            {
                SubGrupoAlt.SelectedItem = "";
                SubGrupoAlt.Items.Add("BOLACHA");
                SubGrupoAlt.Items.Add("BOLACHA");
                SubGrupoAlt.Items.Add("BOLACHA");
                SubGrupoAlt.Items.Add("BOLACHA");
            }


            SubGrupoAlt.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            EmbalagemAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            QuantidadeAlt.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            FabricanteAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            CNPJAlt.Text = PrecoCompraAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            //PrecoCompraAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            PrecoCompraAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            PrecoVendaAlt.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            CodigoAlt.Text = nomeB.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE cadastroProdutos SET codigoBarra = @codigoBarra, nomeProduto = @nomeProduto, grupo = @grupo,subGrupo = @subGrupo,embalagem = @embalagem,quantidade = @quantidade, fabricante = @fabricante,CNPJ = @CNPJ,precoCompra = @PrecoCompra,precoVenda = @precoVenda WHERE (codigoBarra = '" + nomeB + "')";

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            cmd.Parameters.AddWithValue("@codigoBarra", CodigoAlt.Text);
            cmd.Parameters.AddWithValue("@nomeProduto", NomeAlt.Text);
            cmd.Parameters.AddWithValue("@grupo", GrupoAlt.SelectedItem);
            cmd.Parameters.AddWithValue("@subGrupo", SubGrupoAlt.SelectedItem);
            cmd.Parameters.AddWithValue("@embalagem", EmbalagemAlt.Text);
            cmd.Parameters.AddWithValue("@quantidade", QuantidadeAlt.Value);
            cmd.Parameters.AddWithValue("@fabricante", FabricanteAlt.Text);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJAlt.Text);
            cmd.Parameters.AddWithValue("@precoCompra", PrecoCompraAlt.Text);
            cmd.Parameters.AddWithValue("@precoVenda", PrecoVendaAlt.Text);

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Atualizado com sucesso");
                CodigoAlt.Clear();
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
    }
}

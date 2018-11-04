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
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
            mostrar();
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(400,180);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string SalvarProduto = "INSERT INTO [cadastroProdutos](codigoBarra,nomeProduto,grupo,subGrupo,embalagem,quantidade,fabricante,CNPJ,precoCompra,precoVenda) VALUES (@codigoBarra,@nomeProduto,@grupo,@subGrupo,@embalagem,@quantidade,@fabricante,@CNPJ,@precoCompra,@precoVenda)";

            SqlCommand cmd = new SqlCommand(SalvarProduto, sqlcon);

            cmd.Parameters.AddWithValue("@codigoBarra", CodigoBarraCad.Text);
            cmd.Parameters.AddWithValue("@nomeProduto", nomeCad.Text);
            cmd.Parameters.AddWithValue("@grupo", GrupoCad.SelectedItem);
            cmd.Parameters.AddWithValue("@subGrupo", SubGrupoCad.SelectedItem);
            cmd.Parameters.AddWithValue("@embalagem", EmbalagemCad.Text);
            cmd.Parameters.AddWithValue("@quantidade", QuantidadeCad.Value);
            cmd.Parameters.AddWithValue("@fabricante", FabricanteCad.Text);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJCad.Text);
            cmd.Parameters.AddWithValue("@precoCompra", PrecoCompraCad.Text);
            cmd.Parameters.AddWithValue("@precoVenda", PrecoVendaCad.Text);

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado com Sucesso");
                labelAviso.Visible = true;
                //CodigoBarraCad.Clear();

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

        private void GrupoCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubGrupoCad.Items.Clear();

            if (GrupoCad.SelectedItem.ToString() == "LIMPEZA")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("DESINFETANTE");
                SubGrupoCad.Items.Add("DESINFETANTE");
                SubGrupoCad.Items.Add("DESINFETANTE");
                SubGrupoCad.Items.Add("DESINFETANTE");
            }else if(GrupoCad.SelectedItem.ToString() == "COMIDA")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("BOLACHA");
                SubGrupoCad.Items.Add("BOLACHA");
                SubGrupoCad.Items.Add("BOLACHA");
                SubGrupoCad.Items.Add("BOLACHA");
            }
        }

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            GrupoCad.Items.Add("LIMPEZA");
            GrupoCad.Items.Add("COMIDA");
            GrupoCad.Items.Add("CONGELADOS");
            GrupoCad.Items.Add("MACONHA");
            mostrar();
            dataGridView1.Refresh();

        }
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void mostrar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string mostrar = "SELECT * FROM [cadastroProdutos]";

            SqlDataAdapter dta = new SqlDataAdapter(mostrar, sqlcon);

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
    }
}


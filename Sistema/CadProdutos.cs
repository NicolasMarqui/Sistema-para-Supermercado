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
            preencherEmbalagem();
            preencherForne();
            dataGridView1.Refresh();
            //mostrarFundoVermelho();
            preencherCNPJ2();
        }

        int num = -1;

        private void btnCadProd_Click(object sender, EventArgs e)
        {    
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pictureBox1.Image = barcode.Draw(CodigoBarraCad.Text, 50);
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(!String.IsNullOrEmpty(CodigoBarraCad.Text) && (Convert.ToInt64(CodigoBarraCad.Text) == Convert.ToInt64(row.Cells[1].Value)))
                {
                    MessageBox.Show("Um produto com esse Cógido barra já se encontra Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            insert_data();
        }

        void insert_data()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string SalvarProduto = "INSERT INTO [cadastroProdutos](codigoBarra,nomeProduto,grupo,subGrupo,embalagem,fabricante,CNPJ,precoCompra,precoVenda) VALUES (@codigoBarra,@nomeProduto,@grupo,@subGrupo,@embalagem,@fabricante,@CNPJ,@precoCompra,@precoVenda)";

            SqlCommand cmd = new SqlCommand(SalvarProduto, sqlcon);

            cmd.Parameters.AddWithValue("@codigoBarra", CodigoBarraCad.Text);
            cmd.Parameters.AddWithValue("@nomeProduto", nomeCad.Text);
            cmd.Parameters.AddWithValue("@grupo", GrupoCad.SelectedItem);
            cmd.Parameters.AddWithValue("@subGrupo", SubGrupoCad.SelectedItem);
            cmd.Parameters.AddWithValue("@embalagem", comboBoxEmbalagem.Text);
            cmd.Parameters.AddWithValue("@fabricante", comboBoxForn.Text);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJCad.Text);
            cmd.Parameters.AddWithValue("@precoCompra", PrecoCompraCad.Text);
            cmd.Parameters.AddWithValue("@precoVenda", PrecoVendaCad.Text);

            try
            {
                sqlcon.Open();

                if (String.IsNullOrEmpty(CodigoBarraCad.Text))
                {
                    MessageBox.Show("O campo Código de Barras não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(nomeCad.Text))
                {
                    MessageBox.Show("O campo Nome não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(GrupoCad.Text))
                {
                    MessageBox.Show("O campo Grupo não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(SubGrupoCad.Text))
                {
                    MessageBox.Show("O campo Sub Grupo não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(comboBoxEmbalagem.Text))
                {
                    MessageBox.Show("O campo Embalagem não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(comboBoxForn.Text))
                {
                    MessageBox.Show("O campo Fornecedor não pode ser vazio ou nulo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(PrecoCompraCad.Text) || Convert.ToDecimal(PrecoCompraCad.Text) <= 0)
                {
                    MessageBox.Show("O campo Preço Compra não pode ser vazio ou menor que 0", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (String.IsNullOrEmpty(PrecoVendaCad.Text) || Convert.ToDecimal(PrecoVendaCad.Text) <= 0)
                {
                    MessageBox.Show("O campo Preço Venda não pode ser vazio ou menor que 0", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Cadastrado com Sucesso");
                    labelAviso.Visible = true;
                    //CodigoBarraCad.Clear();

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

        private void GrupoCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubGrupoCad.Items.Clear();

            if (GrupoCad.SelectedItem.ToString() == "LIMPEZA")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("DESINFETANTE");
                SubGrupoCad.Items.Add("SABÃO EM PÓ");
                SubGrupoCad.Items.Add("ESPONJAS");
                SubGrupoCad.Items.Add("PANOS");
                SubGrupoCad.Items.Add("LUVAS");
                SubGrupoCad.Items.Add("SABONETES");
                SubGrupoCad.Items.Add("DETERGENTE");
                SubGrupoCad.Items.Add("DESENGORDURANTE");
                SubGrupoCad.Items.Add("BALDES");
                SubGrupoCad.Items.Add("SABÃO EM BARRA");
                SubGrupoCad.Items.Add("SABÃO EM PÓ");
                SubGrupoCad.Items.Add("AMACIANTE");
                SubGrupoCad.Items.Add("ÁGUA SANITÁRIA");
                SubGrupoCad.Items.Add("MULTIUSO");
                SubGrupoCad.Items.Add("Outro(a)");

            }
            else if(GrupoCad.SelectedItem.ToString() == "ALIMENTOS")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("Achocolatado");
                SubGrupoCad.Items.Add("Açúcar");
                SubGrupoCad.Items.Add("Adoçante");
                SubGrupoCad.Items.Add("Arroz");
                SubGrupoCad.Items.Add("Atum"); SubGrupoCad.Items.Add("Azeite"); SubGrupoCad.Items.Add("Azeitona");
                SubGrupoCad.Items.Add("Batata-Palha"); SubGrupoCad.Items.Add("Baunilha"); SubGrupoCad.Items.Add("Biscoito");
                SubGrupoCad.Items.Add("Bombom"); SubGrupoCad.Items.Add("Café"); SubGrupoCad.Items.Add("Caldo");
                SubGrupoCad.Items.Add("Catchup"); SubGrupoCad.Items.Add("Cereal"); SubGrupoCad.Items.Add("Chá");
                SubGrupoCad.Items.Add("Chocolate"); SubGrupoCad.Items.Add("Granulado"); SubGrupoCad.Items.Add("Coco Ralado");
                SubGrupoCad.Items.Add("Creme de Leite"); SubGrupoCad.Items.Add("Farinha de Milho"); SubGrupoCad.Items.Add("Feijão");
                SubGrupoCad.Items.Add("Fermento"); SubGrupoCad.Items.Add("Gelatina"); SubGrupoCad.Items.Add("Geléia");
                SubGrupoCad.Items.Add("Leite Condensado");
                SubGrupoCad.Items.Add("Macarrão"); SubGrupoCad.Items.Add("Maionese"); SubGrupoCad.Items.Add("Molho");
                SubGrupoCad.Items.Add("Mostarda"); SubGrupoCad.Items.Add("Polpa de Tomate"); SubGrupoCad.Items.Add("Polvilho");
                SubGrupoCad.Items.Add("Sagu"); SubGrupoCad.Items.Add("Sal"); SubGrupoCad.Items.Add("Sal Grosso");
                SubGrupoCad.Items.Add("Salsicha"); SubGrupoCad.Items.Add("Sardinha"); SubGrupoCad.Items.Add("Sopa");
                SubGrupoCad.Items.Add("Tempero"); SubGrupoCad.Items.Add("Outro(a)");
            }
            else if (GrupoCad.SelectedItem.ToString() == "FRIOS")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("Bacon");
                SubGrupoCad.Items.Add("Chester");
                SubGrupoCad.Items.Add("Gordura Vegetal");
                SubGrupoCad.Items.Add("Hambúrguer"); SubGrupoCad.Items.Add("Iogurte"); SubGrupoCad.Items.Add("Leite");
                SubGrupoCad.Items.Add("Linguiça"); SubGrupoCad.Items.Add("Manteiga"); SubGrupoCad.Items.Add("Margarina");
                SubGrupoCad.Items.Add("Mortadela"); SubGrupoCad.Items.Add("Nata"); SubGrupoCad.Items.Add("Patê");
                SubGrupoCad.Items.Add("Peito de Peru"); SubGrupoCad.Items.Add("Presunto"); SubGrupoCad.Items.Add("Queijo");
                SubGrupoCad.Items.Add("Queijo Ralado"); SubGrupoCad.Items.Add("Requeijão"); SubGrupoCad.Items.Add("Ricota");
                SubGrupoCad.Items.Add("Salame"); SubGrupoCad.Items.Add("Outro(a)");
            }
            else if (GrupoCad.SelectedItem.ToString() == "BEBIDAS")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("Água");
                SubGrupoCad.Items.Add("Água de Coco");
                SubGrupoCad.Items.Add("Água Tônica");
                SubGrupoCad.Items.Add("Cerveja"); SubGrupoCad.Items.Add("Champagne"); SubGrupoCad.Items.Add("Licor");
                SubGrupoCad.Items.Add("Refrigerante"); SubGrupoCad.Items.Add("Rum"); SubGrupoCad.Items.Add("Suco");
                SubGrupoCad.Items.Add("Vinho"); SubGrupoCad.Items.Add("Vodca"); SubGrupoCad.Items.Add("Uisque");
                SubGrupoCad.Items.Add("Leite de Coco"); SubGrupoCad.Items.Add("Leite"); SubGrupoCad.Items.Add("Iogurte");
                SubGrupoCad.Items.Add("Outro(a)");
            }
            else if (GrupoCad.SelectedItem.ToString() == "DOCES")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("BOLACHA");
                SubGrupoCad.Items.Add("BOLACHA");
                SubGrupoCad.Items.Add("BOLACHA");
                SubGrupoCad.Items.Add("BOLACHA");
            }
            else if (GrupoCad.SelectedItem.ToString() == "Carnes")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("Bovina");
                SubGrupoCad.Items.Add("Frango");
                SubGrupoCad.Items.Add("Miúdos");
                SubGrupoCad.Items.Add("Peixe");SubGrupoCad.Items.Add("Porco");SubGrupoCad.Items.Add("Outro(a)");
            }
            else if (GrupoCad.SelectedItem.ToString() == "FRUTAS,VERDURAS E LEGUMES")
            {
                SubGrupoCad.SelectedItem = "";
                SubGrupoCad.Items.Add("Abacate");
                SubGrupoCad.Items.Add("Abacaxi");
                SubGrupoCad.Items.Add("Abobrinha");
                SubGrupoCad.Items.Add("Agrião"); SubGrupoCad.Items.Add("Alface"); SubGrupoCad.Items.Add("Alho");
                SubGrupoCad.Items.Add("Banana"); SubGrupoCad.Items.Add("Batata"); SubGrupoCad.Items.Add("Berinjela");
                SubGrupoCad.Items.Add("Beterraba"); SubGrupoCad.Items.Add("Brócolis"); SubGrupoCad.Items.Add("Cebola");
                SubGrupoCad.Items.Add("Chu-Chu"); SubGrupoCad.Items.Add("Couve"); SubGrupoCad.Items.Add("Espinafre");
                SubGrupoCad.Items.Add("Goiaba"); SubGrupoCad.Items.Add("Laranja"); SubGrupoCad.Items.Add("Maça");
                SubGrupoCad.Items.Add("Mamão"); SubGrupoCad.Items.Add("Manjericão"); SubGrupoCad.Items.Add("Melancia");
                SubGrupoCad.Items.Add("Melão"); SubGrupoCad.Items.Add("Ovos"); SubGrupoCad.Items.Add("Pêra");
                SubGrupoCad.Items.Add("Pimentão"); SubGrupoCad.Items.Add("Repolho"); SubGrupoCad.Items.Add("Rúcula");
                SubGrupoCad.Items.Add("Salsinha"); SubGrupoCad.Items.Add("Tomate"); SubGrupoCad.Items.Add("Uva");
                SubGrupoCad.Items.Add("Vagem"); SubGrupoCad.Items.Add("Ervilha"); SubGrupoCad.Items.Add("Palmito");
                SubGrupoCad.Items.Add("Milho"); SubGrupoCad.Items.Add("Pepino"); SubGrupoCad.Items.Add("Outro(a)");

            }

        }

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            CodigoBarraCad.Focus();
            //mostrarFundoVermelho();
            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

            }*/

            GrupoCad.Items.Add("LIMPEZA");
            GrupoCad.Items.Add("ALIMENTOS");
            GrupoCad.Items.Add("FRUTAS,VERDURAS E LEGUMES");
            GrupoCad.Items.Add("FRIOS");
            GrupoCad.Items.Add("BEBIDAS");
            GrupoCad.Items.Add("DOCES");
            GrupoCad.Items.Add("CARNES");
            GrupoCad.Items.Add("HIGIENE");

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

        void preencherForne()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string mostrar = "SELECT * FROM [Fornecedores]";

            SqlCommand cmd = new SqlCommand(mostrar, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string forne = reader["nomeFornecedor"].ToString();
                    comboBoxForn.Items.Add(forne);
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

        void preencherEmbalagem()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string mostrar = "SELECT * FROM [Embalagens]";

            SqlCommand cmd = new SqlCommand(mostrar, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string forne = reader["nomeEmbalagem"].ToString();
                    comboBoxEmbalagem.Items.Add(forne);
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

        /*void mostrarFundoVermelho()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                if (Convert.ToInt32(row.Cells[6].Value) > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (Convert.ToInt32(row.Cells[6].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }*/

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            //mostrarFundoVermelho();
        }

        private void CodigoBarraCad_TextChanged(object sender, EventArgs e)
        {
            //mostrarFundoVermelho();
        }

        private void CodigoBarraCad_Click(object sender, EventArgs e)
        {
            //mostrarFundoVermelho();
        }

        void preencherCNPJ2()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT CNPJ FROM [Fornecedores] WHERE nomeFornecedor = '" + comboBoxForn.Text + "'";

            SqlCommand cmd = new SqlCommand(select, sqlcon);

            sqlcon.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            

            try
            {
                while (reader.Read())
                {
                    string CNPJ = reader["CNPJ"].ToString();

                    CNPJCad.Text = CNPJ;
                    
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

        private void comboBoxForn_TextChanged(object sender, EventArgs e)
        {
            preencherCNPJ2();
        }

        void checarSeExisteCodigoBarra()
        {

        }

       
    }

}

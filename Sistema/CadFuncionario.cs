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
using System.IO;
using System.Drawing.Imaging;

namespace SistemaComSQLServer
{
    public partial class CadFuncionario : Form
    {
        public CadFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 180);
        }

        private void btnCadastarFuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");
            
            string addFuncionario = "INSERT INTO [Login](username,password,nivel) VALUES (@username,@password,@nivel)";

            //Antes de adicionar verifica se já possui um funcionario com o mesmo username cadastrado
            string checkSeJaPossui = "SELECT * FROM [Login] WHERE username = '" + UserCadastro.Text + "'";
            SqlDataAdapter dta = new SqlDataAdapter(checkSeJaPossui, sqlcon);

            DataTable table = new DataTable();

            dta.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já registrado..");
            }

            //Se não possuir nenhum , continua com o cadastro
            if (string.IsNullOrEmpty(UserCadastro.Text))
            {
                MessageBox.Show("O nome do funcionário não pode ser vazio","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }else if (string.IsNullOrEmpty(SenhaCadastro.Text))
            {
                MessageBox.Show("A senha não pode ser vazia", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (string.IsNullOrEmpty(NivelCadastro.Text))
            {
                MessageBox.Show("O nivel não pode ser vazio", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand(addFuncionario, sqlcon);

                cmd.Parameters.AddWithValue("@username", UserCadastro.Text);
                cmd.Parameters.AddWithValue("@password", SenhaCadastro.Text);
                cmd.Parameters.AddWithValue("@nivel", NivelCadastro.Text);

                //SqlParameter imagem = new SqlParameter("@img", SqlDbType.Binary);
                try
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário Cadastrado com sucesso");
                    UserCadastro.Clear();
                    SenhaCadastro.Clear();
                    NivelCadastro.Clear();
                    //pictureBox1.Image = null;


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

        /*Bitmap bmp;
        byte[] foto;

        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = openFileDialog1.FileName;

                bmp = new Bitmap(caminho);

                pictureBox1.Image = bmp;
            }

            MemoryStream memory = new MemoryStream();

            bmp.Save(memory, ImageFormat.Bmp);

            foto = memory.ToArray();
        }*/

        private void fecharCad_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkMostrarSenhaCad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarSenhaCad.Checked)
            {
                SenhaCadastro.PasswordChar = '\0';
            }
            else
            {
                SenhaCadastro.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            TodosFuncionarios todos = new TodosFuncionarios();
            todos.ShowDialog();
        }
    }
}

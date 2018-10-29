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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string nomeMenu;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string validarLogin = "SELECT * FROM [Login] WHERE username = '" + UserLogin.Text + "' and password = '" + SenhaLogin.Text + "'";

            SqlCommand cmd = new SqlCommand(validarLogin,sqlcon);

            SqlDataAdapter sdt = new SqlDataAdapter(validarLogin,sqlcon);

            DataTable dtaTable = new DataTable();

            sdt.Fill(dtaTable);

            try
            {
                sqlcon.Open();

                if (dtaTable.Rows.Count == 1)
                {
                    MessageBox.Show("Seja bem vindo " + UserLogin.Text);
                    nomeMenu = UserLogin.Text;
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int imageNumber = 1;

        private void loadNextImage()
        {
            TimerSlide.Interval = 3000;
            if (imageNumber == 7)
            {
                imageNumber = 1;
            }

            imagensSlide.ImageLocation = string.Format(@"C:\Data_store\images\Logo{0}.jpeg", imageNumber);
            imageNumber++;
        }

        private void TimerSlide_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TimerSlide.Interval = 80;
        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarSenha.Checked)
            {
                SenhaLogin.PasswordChar = '\0';
            }
            else
            {
                SenhaLogin.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelMensagem.Visible = true;
            labelMensagem.Text = "Entre em contato com o admin\nou o dono do mercado";
            labelMensagem.BackColor = Color.Red;
            labelMensagem.ForeColor = Color.Black;
        }

        private void labelMensagem_Click(object sender, EventArgs e)
        {
            labelMensagem.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Hide();
            men.Show();
        }
    }
}

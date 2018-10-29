using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComSQLServer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            CadFuncionario cadastrarFuncionarios = new CadFuncionario();
            cadastrarFuncionarios.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        { 
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

            mostrarNome.Text = Login.nomeMenu;

            if (checkBox1.Checked)
            {
                CadProdutos cad = new CadProdutos();
                cad.FormBorderStyle = FormBorderStyle.None;
                cad.BackColor = Color.Black;
            }
            else
            {
                CadProdutos cad = new CadProdutos();
                cad.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            label2.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterarProd alt = new AlterarProd();
            alt.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            label1.Font = new Font("Arial", 62);
            label2.Font = new Font("Arial", 30);
            label1.Left = 670;
            label2.Left = 760;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadProdutos cadProd = new CadProdutos();
            cadProd.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                

                this.BackColor = Color.FromArgb(37, 46, 59);
                this.ForeColor = Color.White;
                panelFechar.BackColor = Color.FromArgb(220, 20, 60);
                panelFechar.ForeColor = Color.Black;

                panelNavBar.BackColor = Color.FromArgb(220, 20, 60);
                panelNavBar.ForeColor = Color.Black;

                panelNome.BackColor = Color.FromArgb(220, 20, 60);
                panelNome.ForeColor = Color.Black;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;

                btnLog.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                panelFechar.BackColor = Color.FromArgb(13, 93, 142);
                panelFechar.ForeColor = Color.White;

                panelNavBar.BackColor = Color.FromArgb(13, 93, 142);
                panelNavBar.ForeColor = Color.Black;

                panelNome.BackColor = Color.FromArgb(13, 93, 142);
                panelNome.ForeColor = Color.White;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelConfig.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowDialog();
        }

        private void BtnVoltarNormal_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.ShowDialog();
        }
    }
}

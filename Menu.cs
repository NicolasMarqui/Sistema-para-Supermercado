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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            preencherData();
            checarNivel();
        }

        int pegarNivel = 0;
        

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(label7.Text) != 1)
            {
                MessageBox.Show("Desculpe você não pode acessar essa tela");
            }
            else
            {
                CadFuncionario cadastrarFuncionarios = new CadFuncionario();
                cadastrarFuncionarios.ShowDialog();
            }  
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            checarNivel();
            preencherData();
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(Menu_KeyDown);

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
            label1.Left = 600;
            label2.Left = 650;
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
                btnSelecionar.ForeColor = Color.Black;
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

                rightSidePanel.BackColor = Color.FromArgb(220, 20, 60);
                rightSidePanel.ForeColor = Color.Black;

                menuStrip1.BackColor = Color.FromArgb(220, 20, 60);

                pictureBox2.BackColor = Color.FromArgb(220, 20, 60);
                pictureBox3.BackColor = Color.FromArgb(220, 20, 60);
                BtnVoltarNormal.BackColor = Color.FromArgb(220, 20, 60);

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

                rightSidePanel.BackColor = Color.FromArgb(13, 93, 142);
                rightSidePanel.ForeColor = Color.White;

                menuStrip1.BackColor = Color.FromArgb(13, 93, 142);
                menuStrip1.ForeColor = Color.White;

                pictureBox2.BackColor = Color.FromArgb(13, 93, 142);
                pictureBox3.BackColor = Color.FromArgb(13, 93, 142);
                BtnVoltarNormal.BackColor = Color.FromArgb(13, 93, 142);
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
            if (Convert.ToInt32(label7.Text) != 2 && Convert.ToInt32(label7.Text) != 1)
            {
                MessageBox.Show("Desculpe você não pode acessar essa tela");
            }
            else
            {
                Estoque est = new Estoque();
                est.ShowDialog();
            }
        }

        private void BtnVoltarNormal_Click(object sender, EventArgs e)
        {
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label7.Text) != 3 && Convert.ToInt32(label7.Text) != 1)
            {
                MessageBox.Show("Desculpe você não pode acessar essa tela");
            }
            else
            {
                Caixa caixa = new Caixa();
                caixa.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastrarFornecedores forn = new CadastrarFornecedores();
            forn.ShowDialog();
        }

        private void adicionarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            CadProdutos cad = new CadProdutos();
            cad.ShowDialog();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                CadProdutos cad = new CadProdutos();
                cad.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F2")
            {
                AlterarProd alt = new AlterarProd();
                alt.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F3")
            {
                Estoque est = new Estoque();
                est.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F4")
            {
                AlterarProd altEs = new AlterarProd();
                altEs.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F5")
            {
                Caixa caixa = new Caixa();
                caixa.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F6")
            {
                EstoqueRapido cad = new EstoqueRapido();
                cad.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F7")
            {
                CadFuncionario func = new CadFuncionario();
                func.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F8")
            {
                CadastrarFornecedores forn = new CadastrarFornecedores();
                forn.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F9")
            {
                AltFornecedor alt = new AltFornecedor();
                alt.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F10")
            {
                PedidoFornecedor ped = new PedidoFornecedor();
                ped.ShowDialog();
            }

            if (e.KeyCode.ToString() == "F11")
            {
                Relatorio rel = new Relatorio();
                rel.ShowDialog();
            }
        }

        private void pedirProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoFornecedor ped = new PedidoFornecedor();
            ped.ShowDialog();
        }

        private void alterarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarProd alt = new AlterarProd();
            alt.ShowDialog();
        }

        private void adicionarProdutoNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque est = new Estoque();
            est.ShowDialog();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.ShowDialog();
        }

        private void adicionarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label7.Text) != 1)
            {
                MessageBox.Show("Desculpe você não pode acessar essa tela");
            }
            else
            {
                CadFuncionario cadastrarFuncionarios = new CadFuncionario();
                cadastrarFuncionarios.ShowDialog();
            }
        }

        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFornecedores forn = new CadastrarFornecedores();
            forn.ShowDialog();
        }

        private void alterarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarEstoque altEst = new AlterarEstoque();
            altEst.ShowDialog();
        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            AlterarEstoque altEst = new AlterarEstoque();
            altEst.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PedidoFornecedor pedi = new PedidoFornecedor();
            pedi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstoqueRapido rap = new EstoqueRapido();
            rap.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label7.Text) != 1)
            {
                MessageBox.Show("Desculpe você não pode acessar essa tela");
            }
            else
            {
                Relatorio rel = new Relatorio();
                rel.ShowDialog();
            }
        }

        void preencherData()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string select = "SELECT * FROM Login WHERE username = '" + Login.nomeMenu + "'";

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

        void checarNivel()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                pegarNivel = Convert.ToInt32(row.Cells[2].Value);
                label7.Text = pegarNivel.ToString();
            }
        }

        private void btnAlterarForne_Click(object sender, EventArgs e)
        {
            AltFornecedor forne = new AltFornecedor();
            forne.ShowDialog();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                panelFechar.BackColor = colorDialog1.Color;
                panelNavBar.BackColor = colorDialog1.Color;
                panelFechar.ForeColor = Color.Black;
                panelNavBar.ForeColor = Color.Black;

                panelNome.BackColor = colorDialog1.Color;
                panelNome.ForeColor = Color.Black;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

                btnLog.ForeColor = Color.Black;

                rightSidePanel.BackColor = colorDialog1.Color;
                rightSidePanel.ForeColor = Color.Black;

                menuStrip1.BackColor = colorDialog1.Color;

                pictureBox2.BackColor = colorDialog1.Color;
                pictureBox3.BackColor = colorDialog1.Color;
                BtnVoltarNormal.BackColor = colorDialog1.Color;
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label7.Text) != 1)
            {
                MessageBox.Show("Desculpe você não pode acessar essa tela");
            }
            else
            {
                Relatorio rel = new Relatorio();
                rel.ShowDialog();
            }
        }

        private void verTodosFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodosFuncionarios todos = new TodosFuncionarios();
            todos.ShowDialog();
        }
    }
}

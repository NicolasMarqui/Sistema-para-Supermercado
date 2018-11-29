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
    public partial class pagarCartaoCredito : Form
    {
        public pagarCartaoCredito()
        {
            InitializeComponent();
        }


        public static bool isDone = false;

        private void btnCredito_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioSantander.Checked && textBox1.Text.Length.Equals(4))
            {
                isDone = true;
                this.Close();

            }else if(radioBrasil.Checked && textBox1.Text.Length.Equals(6))
            {
                isDone = true;
                this.Close();
            }
        }

        private void pagarCartaoCredito_Load(object sender, EventArgs e)
        {
            labelValorTotal.Text = Caixa.pagarCartao.ToString();
        }
    }
}

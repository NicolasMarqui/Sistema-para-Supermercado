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
    public partial class AlterarEstoque : Form
    {
        public AlterarEstoque()
        {
            InitializeComponent();
            pesquisar();
            mostrarFundoVermelho();
            dataGridView1.Refresh();
        }

        public void pesquisar()
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string pesquisar = "SELECT * FROM [Estoque] WHERE codigoBarra LIKE '%" + PesquisarCod.Text + "%' ORDER BY id";

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

        private void PesquisarCod_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisar();
            mostrarFundoVermelho();
            dataGridView1.Refresh();
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

                if (Convert.ToInt32(row.Cells[3].Value) > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (Convert.ToInt32(row.Cells[3].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void AlterarEstoque_Load(object sender, EventArgs e)
        {
            mostrarFundoVermelho();
            timePortionDateTimePicker.Format = DateTimePickerFormat.Time;
            timePortionDateTimePicker.ShowUpDown = true;
            dataGridView1.Refresh();
        }

        long nomeB;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                //column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (e.RowIndex >= 0)
            {
                nomeB = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                NomeAltEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                timePortionDateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                precoAltEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                forneAltEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                distAltEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                conferenteAltEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                CodigoAltEstoque.Text = nomeB.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string update = "UPDATE Estoque SET codigoBarra = @codigoBarra, nomeProduto = @nomeProduto,quantidade = @quantidade, dataEntrada = @data,horarioEntrada = @hora, precoVenda = @precoVenda,fornecedor = @forn, distribuidora = @dist, nomeConferente = @nomeCon WHERE (codigoBarra = '" + nomeB + "')";

            SqlCommand cmd = new SqlCommand(update, sqlcon);

            cmd.Parameters.AddWithValue("@codigoBarra", CodigoAltEstoque.Text);
            cmd.Parameters.AddWithValue("@nomeProduto", NomeAltEstoque.Text);
            cmd.Parameters.AddWithValue("@quantidade", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@data", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@hora", timePortionDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@precoVenda", precoAltEstoque.Text);
            cmd.Parameters.AddWithValue("@forn", forneAltEstoque.Text);
            cmd.Parameters.AddWithValue("@dist", distAltEstoque.Text);
            cmd.Parameters.AddWithValue("@nomeCon", conferenteAltEstoque.Text);

            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Atualizado no estoque com sucesso");
                limparCampos();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void limparCampos()
        {
            CodigoAltEstoque.Clear();
            NomeAltEstoque.Clear();
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Today;
            precoAltEstoque.Clear();
            forneAltEstoque.Clear();
            distAltEstoque.Clear();
            conferenteAltEstoque.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Funcionarios;Data Source=DESKTOP-SDG9LN1");

            string delete = "DELETE FROM Estoque WHERE codigoBarra = '" + CodigoAltEstoque.Text + "'";

            SqlCommand cmd = new SqlCommand(delete, sqlcon);

            try
            {
                sqlcon.Open();
                if(MessageBox.Show("Deseja realmente excluir o produto " + NomeAltEstoque.Text + " do estoque?","Deseja excluir?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto removido com sucesso");
                    limparCampos();
                }
                else
                {

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

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            mostrarFundoVermelho();
        }

        private void numericUpDown1_Move(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(numericUpDown1, "ESSE CAMPO NÃO ADICIONA VALORES, APENAS MUDA SEU VALOR");
        }
    }
}

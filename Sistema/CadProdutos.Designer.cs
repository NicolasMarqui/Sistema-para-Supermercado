namespace SistemaComSQLServer
{
    partial class CadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.nomeCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrupoCad = new System.Windows.Forms.ComboBox();
            this.SubGrupoCad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecoCompraCad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrecoVendaCad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodigoBarraCad = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CNPJCad = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxForn = new System.Windows.Forms.ComboBox();
            this.comboBoxEmbalagem = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras";
            // 
            // nomeCad
            // 
            this.nomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCad.Location = new System.Drawing.Point(27, 149);
            this.nomeCad.Name = "nomeCad";
            this.nomeCad.Size = new System.Drawing.Size(222, 34);
            this.nomeCad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(24, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grupo";
            // 
            // GrupoCad
            // 
            this.GrupoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoCad.FormattingEnabled = true;
            this.GrupoCad.Location = new System.Drawing.Point(30, 243);
            this.GrupoCad.Name = "GrupoCad";
            this.GrupoCad.Size = new System.Drawing.Size(216, 37);
            this.GrupoCad.TabIndex = 5;
            this.GrupoCad.SelectedIndexChanged += new System.EventHandler(this.GrupoCad_SelectedIndexChanged);
            // 
            // SubGrupoCad
            // 
            this.SubGrupoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubGrupoCad.FormattingEnabled = true;
            this.SubGrupoCad.Location = new System.Drawing.Point(30, 336);
            this.SubGrupoCad.Name = "SubGrupoCad";
            this.SubGrupoCad.Size = new System.Drawing.Size(216, 37);
            this.SubGrupoCad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(24, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "SubGrupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Embalagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(28, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Forncedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(28, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "CNPJ";
            // 
            // PrecoCompraCad
            // 
            this.PrecoCompraCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoCompraCad.Location = new System.Drawing.Point(22, 59);
            this.PrecoCompraCad.Name = "PrecoCompraCad";
            this.PrecoCompraCad.Size = new System.Drawing.Size(248, 38);
            this.PrecoCompraCad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(19, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Preço Compra";
            // 
            // PrecoVendaCad
            // 
            this.PrecoVendaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoVendaCad.Location = new System.Drawing.Point(25, 149);
            this.PrecoVendaCad.Name = "PrecoVendaCad";
            this.PrecoVendaCad.Size = new System.Drawing.Size(251, 38);
            this.PrecoVendaCad.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(16, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Preço Venda";
            // 
            // btnCadProd
            // 
            this.btnCadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.Location = new System.Drawing.Point(367, 708);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(697, 85);
            this.btnCadProd.TabIndex = 20;
            this.btnCadProd.Text = "Cadastrar";
            this.btnCadProd.UseVisualStyleBackColor = true;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodigoBarraCad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SubGrupoCad);
            this.groupBox1.Controls.Add(this.GrupoCad);
            this.groupBox1.Controls.Add(this.nomeCad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(238, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 402);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CodigoBarraCad
            // 
            this.CodigoBarraCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoBarraCad.Location = new System.Drawing.Point(27, 56);
            this.CodigoBarraCad.Mask = "9999999999999";
            this.CodigoBarraCad.Name = "CodigoBarraCad";
            this.CodigoBarraCad.Size = new System.Drawing.Size(218, 34);
            this.CodigoBarraCad.TabIndex = 28;
            this.CodigoBarraCad.Click += new System.EventHandler(this.CodigoBarraCad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CNPJCad);
            this.groupBox2.Controls.Add(this.comboBoxForn);
            this.groupBox2.Controls.Add(this.comboBoxEmbalagem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(558, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 402);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            // 
            // CNPJCad
            // 
            this.CNPJCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJCad.Location = new System.Drawing.Point(31, 242);
            this.CNPJCad.Mask = "99.999.999/9999-99";
            this.CNPJCad.Name = "CNPJCad";
            this.CNPJCad.Size = new System.Drawing.Size(218, 34);
            this.CNPJCad.TabIndex = 29;
            // 
            // comboBoxForn
            // 
            this.comboBoxForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxForn.FormattingEnabled = true;
            this.comboBoxForn.Location = new System.Drawing.Point(34, 149);
            this.comboBoxForn.Name = "comboBoxForn";
            this.comboBoxForn.Size = new System.Drawing.Size(219, 37);
            this.comboBoxForn.TabIndex = 17;
            this.comboBoxForn.TextChanged += new System.EventHandler(this.comboBoxForn_TextChanged);
            // 
            // comboBoxEmbalagem
            // 
            this.comboBoxEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmbalagem.FormattingEnabled = true;
            this.comboBoxEmbalagem.Location = new System.Drawing.Point(34, 56);
            this.comboBoxEmbalagem.Name = "comboBoxEmbalagem";
            this.comboBoxEmbalagem.Size = new System.Drawing.Size(219, 37);
            this.comboBoxEmbalagem.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.PrecoVendaCad);
            this.groupBox3.Controls.Add(this.PrecoCompraCad);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(891, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 402);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.codigoBarra,
            this.nomeProduto,
            this.grupo,
            this.subGrupo,
            this.embalagem,
            this.fabricante,
            this.CNPJ,
            this.precoCompra,
            this.precoVenda});
            this.dataGridView1.Location = new System.Drawing.Point(56, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 215);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // idProd
            // 
            this.idProd.DataPropertyName = "idProd";
            this.idProd.HeaderText = "ID";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // codigoBarra
            // 
            this.codigoBarra.DataPropertyName = "codigoBarra";
            this.codigoBarra.HeaderText = "Código de Barra";
            this.codigoBarra.Name = "codigoBarra";
            this.codigoBarra.ReadOnly = true;
            this.codigoBarra.Width = 200;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "nomeProduto";
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            this.nomeProduto.Width = 200;
            // 
            // grupo
            // 
            this.grupo.DataPropertyName = "grupo";
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            this.grupo.Width = 150;
            // 
            // subGrupo
            // 
            this.subGrupo.DataPropertyName = "subGrupo";
            this.subGrupo.HeaderText = "SubGrupo";
            this.subGrupo.Name = "subGrupo";
            this.subGrupo.ReadOnly = true;
            this.subGrupo.Width = 150;
            // 
            // embalagem
            // 
            this.embalagem.DataPropertyName = "embalagem";
            this.embalagem.HeaderText = "Embalagem";
            this.embalagem.Name = "embalagem";
            this.embalagem.ReadOnly = true;
            this.embalagem.Width = 150;
            // 
            // fabricante
            // 
            this.fabricante.DataPropertyName = "fabricante";
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            this.fabricante.Width = 150;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Width = 150;
            // 
            // precoCompra
            // 
            this.precoCompra.DataPropertyName = "precoCompra";
            this.precoCompra.HeaderText = "Preço Compra";
            this.precoCompra.Name = "precoCompra";
            this.precoCompra.ReadOnly = true;
            this.precoCompra.Width = 70;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "precoVenda";
            this.precoVenda.HeaderText = "Preço Venda";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
            this.precoVenda.Width = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(552, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 31);
            this.label11.TabIndex = 26;
            this.label11.Text = "Produtos Cadastrados";
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAviso.Location = new System.Drawing.Point(546, 802);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(332, 17);
            this.labelAviso.TabIndex = 27;
            this.labelAviso.Text = "*Feche essa janela para recarregar as informações";
            this.labelAviso.Visible = false;
            // 
            // CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1381, 835);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(346, 17);
            this.Name = "CadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produtos";
            this.Load += new System.EventHandler(this.CadProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GrupoCad;
        private System.Windows.Forms.ComboBox SubGrupoCad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PrecoCompraCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrecoVendaCad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.ComboBox comboBoxForn;
        private System.Windows.Forms.ComboBox comboBoxEmbalagem;
        private System.Windows.Forms.MaskedTextBox CodigoBarraCad;
        private System.Windows.Forms.MaskedTextBox CNPJCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
    }
}
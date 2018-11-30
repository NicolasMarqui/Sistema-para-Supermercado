namespace SistemaComSQLServer
{
    partial class AlterarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarProd));
            this.label1 = new System.Windows.Forms.Label();
            this.PesquisarCod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeAlt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxForn = new System.Windows.Forms.ComboBox();
            this.comboBoxEmbalagem = new System.Windows.Forms.ComboBox();
            this.PrecoVendaAlt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecoCompraAlt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CNPJAlt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Fabricante = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubGrupoAlt = new System.Windows.Forms.ComboBox();
            this.GrupoAlt = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoverAlterarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(346, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código de Barras do Produto que deseja alterar";
            // 
            // PesquisarCod
            // 
            this.PesquisarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarCod.Location = new System.Drawing.Point(334, 58);
            this.PesquisarCod.Name = "PesquisarCod";
            this.PesquisarCod.Size = new System.Drawing.Size(726, 38);
            this.PesquisarCod.TabIndex = 1;
            this.PesquisarCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PesquisarCod_KeyUp);
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
            this.fabric,
            this.CNPJ,
            this.precoCompra,
            this.precoVenda});
            this.dataGridView1.Location = new System.Drawing.Point(16, 105);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 214);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.codigoBarra.HeaderText = "Código de Barras";
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
            // fabric
            // 
            this.fabric.DataPropertyName = "fabricante";
            this.fabric.HeaderText = "Fabricante";
            this.fabric.Name = "fabric";
            this.fabric.ReadOnly = true;
            this.fabric.Width = 150;
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
            // CodigoAlt
            // 
            this.CodigoAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoAlt.Location = new System.Drawing.Point(18, 72);
            this.CodigoAlt.Name = "CodigoAlt";
            this.CodigoAlt.Size = new System.Drawing.Size(427, 38);
            this.CodigoAlt.TabIndex = 4;
            this.CodigoAlt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Barra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomeAlt
            // 
            this.NomeAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeAlt.Location = new System.Drawing.Point(21, 162);
            this.NomeAlt.Name = "NomeAlt";
            this.NomeAlt.Size = new System.Drawing.Size(427, 38);
            this.NomeAlt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxForn);
            this.groupBox1.Controls.Add(this.comboBoxEmbalagem);
            this.groupBox1.Controls.Add(this.PrecoVendaAlt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NomeAlt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PrecoCompraAlt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CNPJAlt);
            this.groupBox1.Controls.Add(this.CodigoAlt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Fabricante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SubGrupoAlt);
            this.groupBox1.Controls.Add(this.GrupoAlt);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(16, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 325);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Informações";
            // 
            // comboBoxForn
            // 
            this.comboBoxForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxForn.FormattingEnabled = true;
            this.comboBoxForn.Location = new System.Drawing.Point(503, 164);
            this.comboBoxForn.Name = "comboBoxForn";
            this.comboBoxForn.Size = new System.Drawing.Size(354, 39);
            this.comboBoxForn.TabIndex = 22;
            // 
            // comboBoxEmbalagem
            // 
            this.comboBoxEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmbalagem.FormattingEnabled = true;
            this.comboBoxEmbalagem.Location = new System.Drawing.Point(502, 71);
            this.comboBoxEmbalagem.Name = "comboBoxEmbalagem";
            this.comboBoxEmbalagem.Size = new System.Drawing.Size(354, 39);
            this.comboBoxEmbalagem.TabIndex = 21;
            // 
            // PrecoVendaAlt
            // 
            this.PrecoVendaAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoVendaAlt.Location = new System.Drawing.Point(928, 165);
            this.PrecoVendaAlt.Name = "PrecoVendaAlt";
            this.PrecoVendaAlt.Size = new System.Drawing.Size(287, 38);
            this.PrecoVendaAlt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(922, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Preço Venda";
            // 
            // PrecoCompraAlt
            // 
            this.PrecoCompraAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoCompraAlt.Location = new System.Drawing.Point(928, 76);
            this.PrecoCompraAlt.Name = "PrecoCompraAlt";
            this.PrecoCompraAlt.Size = new System.Drawing.Size(287, 38);
            this.PrecoCompraAlt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(922, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Preço Compra";
            // 
            // CNPJAlt
            // 
            this.CNPJAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJAlt.Location = new System.Drawing.Point(503, 256);
            this.CNPJAlt.Name = "CNPJAlt";
            this.CNPJAlt.Size = new System.Drawing.Size(287, 38);
            this.CNPJAlt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(497, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "CNPJ";
            // 
            // Fabricante
            // 
            this.Fabricante.AutoSize = true;
            this.Fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fabricante.ForeColor = System.Drawing.SystemColors.Control;
            this.Fabricante.Location = new System.Drawing.Point(497, 124);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(153, 31);
            this.Fabricante.TabIndex = 11;
            this.Fabricante.Text = "Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(250, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "SubGrupo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(490, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Embalagem";
            // 
            // SubGrupoAlt
            // 
            this.SubGrupoAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubGrupoAlt.FormattingEnabled = true;
            this.SubGrupoAlt.Location = new System.Drawing.Point(250, 254);
            this.SubGrupoAlt.Name = "SubGrupoAlt";
            this.SubGrupoAlt.Size = new System.Drawing.Size(195, 39);
            this.SubGrupoAlt.TabIndex = 9;
            this.SubGrupoAlt.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // GrupoAlt
            // 
            this.GrupoAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoAlt.FormattingEnabled = true;
            this.GrupoAlt.Location = new System.Drawing.Point(18, 255);
            this.GrupoAlt.Name = "GrupoAlt";
            this.GrupoAlt.Size = new System.Drawing.Size(185, 39);
            this.GrupoAlt.TabIndex = 0;
            this.GrupoAlt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(16, 686);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(650, 87);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemoverAlterarProd
            // 
            this.btnRemoverAlterarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverAlterarProd.Location = new System.Drawing.Point(708, 687);
            this.btnRemoverAlterarProd.Name = "btnRemoverAlterarProd";
            this.btnRemoverAlterarProd.Size = new System.Drawing.Size(640, 87);
            this.btnRemoverAlterarProd.TabIndex = 11;
            this.btnRemoverAlterarProd.Text = "Remover um Produto do Sistema";
            this.btnRemoverAlterarProd.UseVisualStyleBackColor = true;
            this.btnRemoverAlterarProd.Click += new System.EventHandler(this.btnRemoverAlterarProd_Click);
            // 
            // AlterarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1363, 788);
            this.Controls.Add(this.btnRemoverAlterarProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PesquisarCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarProd";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Produto";
            this.Load += new System.EventHandler(this.AlterarProd_Load);
            this.PaddingChanged += new System.EventHandler(this.AlterarProd_PaddingChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PesquisarCod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CodigoAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PrecoCompraAlt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CNPJAlt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Fabricante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SubGrupoAlt;
        private System.Windows.Forms.ComboBox GrupoAlt;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox PrecoVendaAlt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxEmbalagem;
        private System.Windows.Forms.ComboBox comboBoxForn;
        private System.Windows.Forms.Button btnRemoverAlterarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabric;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
    }
}
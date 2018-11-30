namespace SistemaComSQLServer
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.label1 = new System.Windows.Forms.Label();
            this.EstoqueAdicionar = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMostrarEstoque = new System.Windows.Forms.GroupBox();
            this.precoText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nomeText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fornceEsoque = new System.Windows.Forms.ComboBox();
            this.confeEstque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.distEstoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataEstoque = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.quantEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeConfere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupMostrarEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(109, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicione um item no estoque";
            // 
            // EstoqueAdicionar
            // 
            this.EstoqueAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstoqueAdicionar.Location = new System.Drawing.Point(500, 52);
            this.EstoqueAdicionar.Name = "EstoqueAdicionar";
            this.EstoqueAdicionar.Size = new System.Drawing.Size(483, 34);
            this.EstoqueAdicionar.TabIndex = 1;
            this.EstoqueAdicionar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EstoqueAdicionar_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1004, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(312, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarra,
            this.idProd,
            this.nomeProduto,
            this.grupo,
            this.subGrupo,
            this.embalagem,
            this.fabricante,
            this.CNPJ,
            this.precoCompra,
            this.precoVenda});
            this.dataGridView1.Location = new System.Drawing.Point(115, 114);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 235);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // codigoBarra
            // 
            this.codigoBarra.DataPropertyName = "codigoBarra";
            this.codigoBarra.HeaderText = "Código de Barras";
            this.codigoBarra.Name = "codigoBarra";
            this.codigoBarra.ReadOnly = true;
            // 
            // idProd
            // 
            this.idProd.DataPropertyName = "idProd";
            this.idProd.HeaderText = "ID";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "nomeProduto";
            this.nomeProduto.HeaderText = "Nome";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // grupo
            // 
            this.grupo.DataPropertyName = "grupo";
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            // 
            // subGrupo
            // 
            this.subGrupo.DataPropertyName = "subGrupo";
            this.subGrupo.HeaderText = "Sub Grupo";
            this.subGrupo.Name = "subGrupo";
            this.subGrupo.ReadOnly = true;
            // 
            // embalagem
            // 
            this.embalagem.DataPropertyName = "embalagem";
            this.embalagem.HeaderText = "Embalagem";
            this.embalagem.Name = "embalagem";
            this.embalagem.ReadOnly = true;
            // 
            // fabricante
            // 
            this.fabricante.DataPropertyName = "fabricante";
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // precoCompra
            // 
            this.precoCompra.DataPropertyName = "precoCompra";
            this.precoCompra.HeaderText = "Preço Compra";
            this.precoCompra.Name = "precoCompra";
            this.precoCompra.ReadOnly = true;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "precoVenda";
            this.precoVenda.HeaderText = "Preço Venda";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
            // 
            // groupMostrarEstoque
            // 
            this.groupMostrarEstoque.Controls.Add(this.precoText);
            this.groupMostrarEstoque.Controls.Add(this.label9);
            this.groupMostrarEstoque.Controls.Add(this.nomeText);
            this.groupMostrarEstoque.Controls.Add(this.label8);
            this.groupMostrarEstoque.Controls.Add(this.button1);
            this.groupMostrarEstoque.Controls.Add(this.fornceEsoque);
            this.groupMostrarEstoque.Controls.Add(this.confeEstque);
            this.groupMostrarEstoque.Controls.Add(this.label7);
            this.groupMostrarEstoque.Controls.Add(this.distEstoque);
            this.groupMostrarEstoque.Controls.Add(this.label6);
            this.groupMostrarEstoque.Controls.Add(this.label5);
            this.groupMostrarEstoque.Controls.Add(this.dataEstoque);
            this.groupMostrarEstoque.Controls.Add(this.label4);
            this.groupMostrarEstoque.Controls.Add(this.quantEstoque);
            this.groupMostrarEstoque.Controls.Add(this.label3);
            this.groupMostrarEstoque.Controls.Add(this.codEstoque);
            this.groupMostrarEstoque.Controls.Add(this.label2);
            this.groupMostrarEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.groupMostrarEstoque.Location = new System.Drawing.Point(87, 386);
            this.groupMostrarEstoque.Name = "groupMostrarEstoque";
            this.groupMostrarEstoque.Size = new System.Drawing.Size(1229, 437);
            this.groupMostrarEstoque.TabIndex = 4;
            this.groupMostrarEstoque.TabStop = false;
            this.groupMostrarEstoque.Visible = false;
            // 
            // precoText
            // 
            this.precoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoText.Location = new System.Drawing.Point(280, 166);
            this.precoText.Name = "precoText";
            this.precoText.Size = new System.Drawing.Size(262, 34);
            this.precoText.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preço Venda";
            // 
            // nomeText
            // 
            this.nomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeText.Location = new System.Drawing.Point(280, 109);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(262, 34);
            this.nomeText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(588, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(559, 91);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar no Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fornceEsoque
            // 
            this.fornceEsoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornceEsoque.FormattingEnabled = true;
            this.fornceEsoque.Location = new System.Drawing.Point(885, 145);
            this.fornceEsoque.Name = "fornceEsoque";
            this.fornceEsoque.Size = new System.Drawing.Size(262, 37);
            this.fornceEsoque.TabIndex = 12;
            // 
            // confeEstque
            // 
            this.confeEstque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confeEstque.Location = new System.Drawing.Point(885, 254);
            this.confeEstque.Name = "confeEstque";
            this.confeEstque.Size = new System.Drawing.Size(262, 34);
            this.confeEstque.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(582, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Conferente";
            // 
            // distEstoque
            // 
            this.distEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distEstoque.Location = new System.Drawing.Point(885, 200);
            this.distEstoque.Name = "distEstoque";
            this.distEstoque.Size = new System.Drawing.Size(262, 34);
            this.distEstoque.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Distribuidora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fornecedor";
            // 
            // dataEstoque
            // 
            this.dataEstoque.CustomFormat = "dd-mm-yy";
            this.dataEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEstoque.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataEstoque.Location = new System.Drawing.Point(885, 99);
            this.dataEstoque.Name = "dataEstoque";
            this.dataEstoque.Size = new System.Drawing.Size(262, 34);
            this.dataEstoque.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horario de entrada";
            // 
            // quantEstoque
            // 
            this.quantEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantEstoque.Location = new System.Drawing.Point(885, 45);
            this.quantEstoque.Name = "quantEstoque";
            this.quantEstoque.Size = new System.Drawing.Size(262, 34);
            this.quantEstoque.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade do produto ";
            // 
            // codEstoque
            // 
            this.codEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codEstoque.Location = new System.Drawing.Point(280, 52);
            this.codEstoque.Name = "codEstoque";
            this.codEstoque.Size = new System.Drawing.Size(262, 34);
            this.codEstoque.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Barras";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nom,
            this.preco,
            this.quant,
            this.dataEntrada,
            this.horarioEntrada,
            this.fornecedor,
            this.distribuidora,
            this.nomeConfere});
            this.dataGridView2.Location = new System.Drawing.Point(738, 114);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(578, 235);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Sorted += new System.EventHandler(this.dataGridView2_Sorted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(320, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "* Produtos Cadastrados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(946, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "* Produtos no Estoque";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigoBarra";
            this.codigo.HeaderText = "Código de Barras";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nomeProduto";
            this.nom.HeaderText = "Nome";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "precoVenda";
            this.preco.HeaderText = "Preço Venda";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "quantidade";
            this.quant.HeaderText = "Quantidade";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            // 
            // dataEntrada
            // 
            this.dataEntrada.DataPropertyName = "dataEntrada";
            this.dataEntrada.HeaderText = "Data De Entrada";
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.ReadOnly = true;
            // 
            // horarioEntrada
            // 
            this.horarioEntrada.DataPropertyName = "horarioEntrada";
            this.horarioEntrada.HeaderText = "Horário de Entrada";
            this.horarioEntrada.Name = "horarioEntrada";
            this.horarioEntrada.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // distribuidora
            // 
            this.distribuidora.DataPropertyName = "distribuidora";
            this.distribuidora.HeaderText = "Distribuidora";
            this.distribuidora.Name = "distribuidora";
            this.distribuidora.ReadOnly = true;
            // 
            // nomeConfere
            // 
            this.nomeConfere.DataPropertyName = "nomeConferente";
            this.nomeConfere.HeaderText = "Conferente";
            this.nomeConfere.Name = "nomeConfere";
            this.nomeConfere.ReadOnly = true;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1381, 835);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.EstoqueAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupMostrarEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupMostrarEstoque.ResumeLayout(false);
            this.groupMostrarEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EstoqueAdicionar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupMostrarEstoque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fornceEsoque;
        private System.Windows.Forms.TextBox confeEstque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox distEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox precoText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn distribuidora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeConfere;
    }
}
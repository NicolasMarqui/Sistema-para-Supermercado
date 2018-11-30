namespace SistemaComSQLServer
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.label1 = new System.Windows.Forms.Label();
            this.brnCaixa = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnForne = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMostrarRowsVendas = new System.Windows.Forms.Label();
            this.btnExpotarVendas = new System.Windows.Forms.Button();
            this.textBoxVendas = new System.Windows.Forms.TextBox();
            this.labelVendas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeConferente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.groupBoxEstoque = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelProdutoVermelho = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelProdutoVerde = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProdutoAmarelo = new System.Windows.Forms.Label();
            this.btnExportarEstoque = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBoxFornecedores = new System.Windows.Forms.GroupBox();
            this.btnRelacao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMostrarForn = new System.Windows.Forms.Label();
            this.btnExportarForne = new System.Windows.Forms.Button();
            this.pesquisaNomeForne = new System.Windows.Forms.Label();
            this.textBoxForne = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBoxFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(413, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a tabela que deseja gerar o relatório";
            // 
            // brnCaixa
            // 
            this.brnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCaixa.Location = new System.Drawing.Point(175, 120);
            this.brnCaixa.Name = "brnCaixa";
            this.brnCaixa.Size = new System.Drawing.Size(303, 84);
            this.brnCaixa.TabIndex = 1;
            this.brnCaixa.Text = "Vendas";
            this.brnCaixa.UseVisualStyleBackColor = true;
            this.brnCaixa.Click += new System.EventHandler(this.brnCaixa_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(550, 120);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(303, 84);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnForne
            // 
            this.btnForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForne.Location = new System.Drawing.Point(933, 120);
            this.btnForne.Name = "btnForne";
            this.btnForne.Size = new System.Drawing.Size(303, 84);
            this.btnForne.TabIndex = 3;
            this.btnForne.Text = "Fornecedores";
            this.btnForne.UseVisualStyleBackColor = true;
            this.btnForne.Click += new System.EventHandler(this.btnForne_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProduto,
            this.quantidade,
            this.precoVenda,
            this.diaVenda});
            this.dataGridView1.Location = new System.Drawing.Point(156, 304);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 379);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "nomeProduto";
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            this.nomeProduto.Width = 200;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 200;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "precoVenda";
            this.precoVenda.HeaderText = "Preço da Venda";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
            this.precoVenda.Width = 200;
            // 
            // diaVenda
            // 
            this.diaVenda.DataPropertyName = "diaVenda";
            this.diaVenda.HeaderText = "Dia da venda";
            this.diaVenda.Name = "diaVenda";
            this.diaVenda.ReadOnly = true;
            this.diaVenda.Width = 170;
            // 
            // labelMostrarRowsVendas
            // 
            this.labelMostrarRowsVendas.AutoSize = true;
            this.labelMostrarRowsVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrarRowsVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMostrarRowsVendas.Location = new System.Drawing.Point(61, 18);
            this.labelMostrarRowsVendas.Name = "labelMostrarRowsVendas";
            this.labelMostrarRowsVendas.Size = new System.Drawing.Size(23, 31);
            this.labelMostrarRowsVendas.TabIndex = 5;
            this.labelMostrarRowsVendas.Text = "-";
            // 
            // btnExpotarVendas
            // 
            this.btnExpotarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpotarVendas.Location = new System.Drawing.Point(915, 697);
            this.btnExpotarVendas.Name = "btnExpotarVendas";
            this.btnExpotarVendas.Size = new System.Drawing.Size(321, 96);
            this.btnExpotarVendas.TabIndex = 6;
            this.btnExpotarVendas.Text = "Exportar Para o Excel";
            this.btnExpotarVendas.UseVisualStyleBackColor = true;
            this.btnExpotarVendas.Visible = false;
            this.btnExpotarVendas.Click += new System.EventHandler(this.btnExpotarVendas_Click);
            // 
            // textBoxVendas
            // 
            this.textBoxVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVendas.Location = new System.Drawing.Point(550, 245);
            this.textBoxVendas.Name = "textBoxVendas";
            this.textBoxVendas.Size = new System.Drawing.Size(303, 34);
            this.textBoxVendas.TabIndex = 7;
            this.textBoxVendas.Visible = false;
            this.textBoxVendas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxVendas_KeyUp);
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVendas.Location = new System.Drawing.Point(232, 245);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(246, 31);
            this.labelVendas.TabIndex = 8;
            this.labelVendas.Text = "Pesquisar por Data";
            this.labelVendas.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelValorTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelMostrarRowsVendas);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(156, 689);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            this.groupBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(198, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "total de produtos vendidos";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorTotal.Location = new System.Drawing.Point(68, 73);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(23, 31);
            this.labelValorTotal.TabIndex = 7;
            this.labelValorTotal.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(198, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "vendas feitas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigoBarra,
            this.nomeProdutos,
            this.quantidades,
            this.dataEntrada,
            this.horarioEntrada,
            this.precoVendas,
            this.fornecedor,
            this.distribuidora,
            this.nomeConferente});
            this.dataGridView2.Location = new System.Drawing.Point(156, 304);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1080, 321);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.Visible = false;
            this.dataGridView2.Sorted += new System.EventHandler(this.dataGridView2_Sorted);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // codigoBarra
            // 
            this.codigoBarra.DataPropertyName = "codigoBarra";
            this.codigoBarra.HeaderText = "Código de Barras";
            this.codigoBarra.Name = "codigoBarra";
            this.codigoBarra.ReadOnly = true;
            // 
            // nomeProdutos
            // 
            this.nomeProdutos.DataPropertyName = "nomeProduto";
            this.nomeProdutos.HeaderText = "Nome";
            this.nomeProdutos.Name = "nomeProdutos";
            this.nomeProdutos.ReadOnly = true;
            // 
            // quantidades
            // 
            this.quantidades.DataPropertyName = "quantidade";
            this.quantidades.HeaderText = "Quantidade";
            this.quantidades.Name = "quantidades";
            this.quantidades.ReadOnly = true;
            // 
            // dataEntrada
            // 
            this.dataEntrada.DataPropertyName = "dataEntrada";
            this.dataEntrada.HeaderText = "Data";
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.ReadOnly = true;
            // 
            // horarioEntrada
            // 
            this.horarioEntrada.DataPropertyName = "horarioEntrada";
            this.horarioEntrada.HeaderText = "Horário";
            this.horarioEntrada.Name = "horarioEntrada";
            this.horarioEntrada.ReadOnly = true;
            // 
            // precoVendas
            // 
            this.precoVendas.DataPropertyName = "precoVenda";
            this.precoVendas.HeaderText = "Preço";
            this.precoVendas.Name = "precoVendas";
            this.precoVendas.ReadOnly = true;
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
            // nomeConferente
            // 
            this.nomeConferente.DataPropertyName = "nomeConferente";
            this.nomeConferente.HeaderText = "Conferente";
            this.nomeConferente.Name = "nomeConferente";
            this.nomeConferente.ReadOnly = true;
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEstoque.Location = new System.Drawing.Point(232, 248);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(260, 31);
            this.labelEstoque.TabIndex = 11;
            this.labelEstoque.Text = "Pesquisar por Nome\r\n";
            this.labelEstoque.Visible = false;
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstoque.Location = new System.Drawing.Point(550, 245);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(303, 34);
            this.textBoxEstoque.TabIndex = 12;
            this.textBoxEstoque.Visible = false;
            this.textBoxEstoque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEstoque_KeyUp);
            // 
            // groupBoxEstoque
            // 
            this.groupBoxEstoque.Controls.Add(this.label7);
            this.groupBoxEstoque.Controls.Add(this.labelProdutoVermelho);
            this.groupBoxEstoque.Controls.Add(this.label6);
            this.groupBoxEstoque.Controls.Add(this.labelProdutoVerde);
            this.groupBoxEstoque.Controls.Add(this.label5);
            this.groupBoxEstoque.Controls.Add(this.labelProdutoAmarelo);
            this.groupBoxEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxEstoque.Location = new System.Drawing.Point(156, 646);
            this.groupBoxEstoque.Name = "groupBoxEstoque";
            this.groupBoxEstoque.Size = new System.Drawing.Size(737, 165);
            this.groupBoxEstoque.TabIndex = 13;
            this.groupBoxEstoque.TabStop = false;
            this.groupBoxEstoque.Text = "Informações";
            this.groupBoxEstoque.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Produtos com nenhuma unidade\r\n";
            // 
            // labelProdutoVermelho
            // 
            this.labelProdutoVermelho.AutoSize = true;
            this.labelProdutoVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoVermelho.Location = new System.Drawing.Point(41, 116);
            this.labelProdutoVermelho.Name = "labelProdutoVermelho";
            this.labelProdutoVermelho.Size = new System.Drawing.Size(21, 29);
            this.labelProdutoVermelho.TabIndex = 4;
            this.labelProdutoVermelho.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Produtos com mais de 5 unidades";
            // 
            // labelProdutoVerde
            // 
            this.labelProdutoVerde.AutoSize = true;
            this.labelProdutoVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoVerde.Location = new System.Drawing.Point(41, 69);
            this.labelProdutoVerde.Name = "labelProdutoVerde";
            this.labelProdutoVerde.Size = new System.Drawing.Size(21, 29);
            this.labelProdutoVerde.TabIndex = 2;
            this.labelProdutoVerde.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Produtos com menos de 5 unidades";
            // 
            // labelProdutoAmarelo
            // 
            this.labelProdutoAmarelo.AutoSize = true;
            this.labelProdutoAmarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoAmarelo.Location = new System.Drawing.Point(41, 28);
            this.labelProdutoAmarelo.Name = "labelProdutoAmarelo";
            this.labelProdutoAmarelo.Size = new System.Drawing.Size(21, 29);
            this.labelProdutoAmarelo.TabIndex = 0;
            this.labelProdutoAmarelo.Text = "-";
            // 
            // btnExportarEstoque
            // 
            this.btnExportarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarEstoque.Location = new System.Drawing.Point(915, 674);
            this.btnExportarEstoque.Name = "btnExportarEstoque";
            this.btnExportarEstoque.Size = new System.Drawing.Size(321, 108);
            this.btnExportarEstoque.TabIndex = 14;
            this.btnExportarEstoque.Text = "Exportar Para Excel";
            this.btnExportarEstoque.UseVisualStyleBackColor = true;
            this.btnExportarEstoque.Visible = false;
            this.btnExportarEstoque.Click += new System.EventHandler(this.btnExportarEstoque_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(156, 492);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1080, 321);
            this.dataGridView3.TabIndex = 15;
            this.dataGridView3.Visible = false;
            // 
            // groupBoxFornecedores
            // 
            this.groupBoxFornecedores.Controls.Add(this.btnRelacao);
            this.groupBoxFornecedores.Controls.Add(this.label8);
            this.groupBoxFornecedores.Controls.Add(this.labelMostrarForn);
            this.groupBoxFornecedores.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxFornecedores.Location = new System.Drawing.Point(156, 321);
            this.groupBoxFornecedores.Name = "groupBoxFornecedores";
            this.groupBoxFornecedores.Size = new System.Drawing.Size(737, 137);
            this.groupBoxFornecedores.TabIndex = 6;
            this.groupBoxFornecedores.TabStop = false;
            this.groupBoxFornecedores.Text = "Informações";
            this.groupBoxFornecedores.Visible = false;
            // 
            // btnRelacao
            // 
            this.btnRelacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRelacao.Location = new System.Drawing.Point(181, 74);
            this.btnRelacao.Name = "btnRelacao";
            this.btnRelacao.Size = new System.Drawing.Size(208, 45);
            this.btnRelacao.TabIndex = 20;
            this.btnRelacao.Text = "Abrir Relação de Produtos";
            this.btnRelacao.UseVisualStyleBackColor = true;
            this.btnRelacao.Click += new System.EventHandler(this.btnRelacao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(130, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fornecedores cadastrados\r\n";
            // 
            // labelMostrarForn
            // 
            this.labelMostrarForn.AutoSize = true;
            this.labelMostrarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrarForn.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMostrarForn.Location = new System.Drawing.Point(23, 33);
            this.labelMostrarForn.Name = "labelMostrarForn";
            this.labelMostrarForn.Size = new System.Drawing.Size(23, 31);
            this.labelMostrarForn.TabIndex = 19;
            this.labelMostrarForn.Text = "-\r\n";
            // 
            // btnExportarForne
            // 
            this.btnExportarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarForne.Location = new System.Drawing.Point(906, 334);
            this.btnExportarForne.Name = "btnExportarForne";
            this.btnExportarForne.Size = new System.Drawing.Size(321, 114);
            this.btnExportarForne.TabIndex = 16;
            this.btnExportarForne.Text = "Exportar excel";
            this.btnExportarForne.UseVisualStyleBackColor = true;
            this.btnExportarForne.Visible = false;
            this.btnExportarForne.Click += new System.EventHandler(this.btnExportarForne_Click);
            // 
            // pesquisaNomeForne
            // 
            this.pesquisaNomeForne.AutoSize = true;
            this.pesquisaNomeForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeForne.ForeColor = System.Drawing.SystemColors.Control;
            this.pesquisaNomeForne.Location = new System.Drawing.Point(232, 248);
            this.pesquisaNomeForne.Name = "pesquisaNomeForne";
            this.pesquisaNomeForne.Size = new System.Drawing.Size(260, 31);
            this.pesquisaNomeForne.TabIndex = 17;
            this.pesquisaNomeForne.Text = "Pesquisar por Nome\r\n";
            this.pesquisaNomeForne.Visible = false;
            // 
            // textBoxForne
            // 
            this.textBoxForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForne.Location = new System.Drawing.Point(550, 245);
            this.textBoxForne.Name = "textBoxForne";
            this.textBoxForne.Size = new System.Drawing.Size(303, 34);
            this.textBoxForne.TabIndex = 18;
            this.textBoxForne.Visible = false;
            this.textBoxForne.WordWrap = false;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1381, 835);
            this.Controls.Add(this.groupBoxFornecedores);
            this.Controls.Add(this.btnExportarForne);
            this.Controls.Add(this.textBoxForne);
            this.Controls.Add(this.pesquisaNomeForne);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnExportarEstoque);
            this.Controls.Add(this.groupBoxEstoque);
            this.Controls.Add(this.textBoxEstoque);
            this.Controls.Add(this.labelEstoque);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelVendas);
            this.Controls.Add(this.textBoxVendas);
            this.Controls.Add(this.btnExpotarVendas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnForne);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.brnCaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxEstoque.ResumeLayout(false);
            this.groupBoxEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBoxFornecedores.ResumeLayout(false);
            this.groupBoxFornecedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnCaixa;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnForne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMostrarRowsVendas;
        private System.Windows.Forms.Button btnExpotarVendas;
        private System.Windows.Forms.TextBox textBoxVendas;
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaVenda;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.TextBox textBoxEstoque;
        private System.Windows.Forms.GroupBox groupBoxEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelProdutoVermelho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelProdutoVerde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProdutoAmarelo;
        private System.Windows.Forms.Button btnExportarEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn distribuidora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeConferente;
        private System.Windows.Forms.GroupBox groupBoxFornecedores;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnExportarForne;
        private System.Windows.Forms.Label pesquisaNomeForne;
        private System.Windows.Forms.TextBox textBoxForne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMostrarForn;
        private System.Windows.Forms.Button btnRelacao;
    }
}
namespace prjLeal
{
    partial class frmCaixa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorall = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtTotalFin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.CodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQuantComp = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEstoq = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarProd = new System.Windows.Forms.Button();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grbPag = new System.Windows.Forms.GroupBox();
            this.chkFechado = new System.Windows.Forms.CheckBox();
            this.chkAberto = new System.Windows.Forms.CheckBox();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkComprovante = new System.Windows.Forms.CheckBox();
            this.btnTroco = new System.Windows.Forms.Button();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnComprovante = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQuantestoq = new System.Windows.Forms.TextBox();
            this.txtCancelado = new System.Windows.Forms.TextBox();
            this.txtCodBarra2 = new System.Windows.Forms.TextBox();
            this.txttipPag = new System.Windows.Forms.TextBox();
            this.txtdeb = new System.Windows.Forms.TextBox();
            this.txtValorfin2 = new System.Windows.Forms.TextBox();
            this.txtdebito2 = new System.Windows.Forms.TextBox();
            this.txtDinheiro2 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrecounid = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet = new prjLeal.LealDataSet();
            this.tableAdapterManager = new prjLeal.LealDataSetTableAdapters.TableAdapterManager();
            this.pedidoTableAdapter = new prjLeal.LealDataSetTableAdapters.PedidoTableAdapter();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new prjLeal.LealDataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantComp)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbPag.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkDebito.Location = new System.Drawing.Point(6, 65);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(67, 20);
            this.chkDebito.TabIndex = 2;
            this.chkDebito.Text = "Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            this.chkDebito.CheckedChanged += new System.EventHandler(this.chkDebito_CheckedChanged);
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkCredito.Location = new System.Drawing.Point(6, 42);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(70, 20);
            this.chkCredito.TabIndex = 1;
            this.chkCredito.Text = "Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            this.chkCredito.CheckedChanged += new System.EventHandler(this.chkCredito_CheckedChanged);
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinheiro.Location = new System.Drawing.Point(6, 19);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(77, 20);
            this.chkDinheiro.TabIndex = 0;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            this.chkDinheiro.CheckedChanged += new System.EventHandler(this.chkDinheiro_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label15.Location = new System.Drawing.Point(224, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 23);
            this.label15.TabIndex = 64;
            this.label15.Text = "Total Prod.:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtVtotal
            // 
            this.txtVtotal.Enabled = false;
            this.txtVtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVtotal.Location = new System.Drawing.Point(228, 171);
            this.txtVtotal.Name = "txtVtotal";
            this.txtVtotal.Size = new System.Drawing.Size(97, 26);
            this.txtVtotal.TabIndex = 63;
            this.txtVtotal.TextChanged += new System.EventHandler(this.txtVtotal_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label14.Location = new System.Drawing.Point(6, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 62;
            this.label14.Text = "Preço Unit.:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPreco.Location = new System.Drawing.Point(9, 167);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(97, 26);
            this.txtPreco.TabIndex = 61;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label13.Location = new System.Drawing.Point(112, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 60;
            this.label13.Text = "Quantidade:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 58;
            this.label12.Text = "Código Barras:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoB.Location = new System.Drawing.Point(9, 43);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(152, 26);
            this.txtCodigoB.TabIndex = 57;
            this.txtCodigoB.TextChanged += new System.EventHandler(this.txtCodigoB_TextChanged);
            this.txtCodigoB.Enter += new System.EventHandler(this.txtCodigoB_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label11.Location = new System.Drawing.Point(350, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 56;
            this.label11.Text = "Total:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtValorall
            // 
            this.txtValorall.Enabled = false;
            this.txtValorall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorall.Location = new System.Drawing.Point(407, 491);
            this.txtValorall.Name = "txtValorall";
            this.txtValorall.Size = new System.Drawing.Size(138, 26);
            this.txtValorall.TabIndex = 55;
            this.txtValorall.TextChanged += new System.EventHandler(this.txtValorall_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDebito);
            this.groupBox2.Controls.Add(this.chkCredito);
            this.groupBox2.Controls.Add(this.chkDinheiro);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(190, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 91);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label10.Location = new System.Drawing.Point(6, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "Valor:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label9.Location = new System.Drawing.Point(10, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Troco:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label8.Location = new System.Drawing.Point(10, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Total:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTroco.Location = new System.Drawing.Point(10, 314);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(147, 26);
            this.txtTroco.TabIndex = 48;
            this.txtTroco.TextChanged += new System.EventHandler(this.txtTroco_TextChanged);
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDinheiro.Location = new System.Drawing.Point(10, 259);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(147, 26);
            this.txtDinheiro.TabIndex = 47;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            // 
            // txtTotalFin
            // 
            this.txtTotalFin.Enabled = false;
            this.txtTotalFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalFin.Location = new System.Drawing.Point(10, 201);
            this.txtTotalFin.Name = "txtTotalFin";
            this.txtTotalFin.Size = new System.Drawing.Size(147, 26);
            this.txtTotalFin.TabIndex = 46;
            this.txtTotalFin.TextChanged += new System.EventHandler(this.txtTotalFin_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomeCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodCli);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 107);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 80;
            this.label5.Text = "Nome:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Enabled = false;
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeCli.Location = new System.Drawing.Point(67, 63);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(231, 26);
            this.txtNomeCli.TabIndex = 79;
            this.txtNomeCli.TextChanged += new System.EventHandler(this.txtNomeCli_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "Cod.:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCodCli
            // 
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodCli.Location = new System.Drawing.Point(67, 17);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(51, 26);
            this.txtCodCli.TabIndex = 77;
            this.txtCodCli.TextChanged += new System.EventHandler(this.txtCodCli_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1248, 10);
            this.label2.TabIndex = 41;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Caixa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodBarras,
            this.Produto,
            this.Preco,
            this.Quantidade,
            this.Total});
            this.dgvPedido.Location = new System.Drawing.Point(5, 3);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(540, 482);
            this.dgvPedido.TabIndex = 68;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // CodBarras
            // 
            this.CodBarras.HeaderText = "Código Barras";
            this.CodBarras.Name = "CodBarras";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço Unit.";
            this.Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1160, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 70;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtQuantComp);
            this.groupBox3.Controls.Add(this.txtMarca);
            this.groupBox3.Controls.Add(this.txtQuantidadeEstoq);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnPesquisarProd);
            this.groupBox3.Controls.Add(this.txtCodigoB);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtPreco);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtVtotal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 257);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtQuantComp
            // 
            this.txtQuantComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantComp.Location = new System.Drawing.Point(116, 167);
            this.txtQuantComp.Name = "txtQuantComp";
            this.txtQuantComp.Size = new System.Drawing.Size(77, 26);
            this.txtQuantComp.TabIndex = 75;
            this.txtQuantComp.ValueChanged += new System.EventHandler(this.txtQuantComp_ValueChanged);
            this.txtQuantComp.VisibleChanged += new System.EventHandler(this.txtQuantComp_VisibleChanged);
            this.txtQuantComp.DoubleClick += new System.EventHandler(this.txtQuantComp_DoubleClick);
            this.txtQuantComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantComp_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(169, 107);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(14, 20);
            this.txtMarca.TabIndex = 73;
            this.txtMarca.Visible = false;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtQuantidadeEstoq
            // 
            this.txtQuantidadeEstoq.Enabled = false;
            this.txtQuantidadeEstoq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidadeEstoq.Location = new System.Drawing.Point(201, 102);
            this.txtQuantidadeEstoq.Name = "txtQuantidadeEstoq";
            this.txtQuantidadeEstoq.Size = new System.Drawing.Size(72, 26);
            this.txtQuantidadeEstoq.TabIndex = 73;
            this.txtQuantidadeEstoq.TextChanged += new System.EventHandler(this.txtQuantidadeEstoq_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label16.Location = new System.Drawing.Point(197, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 23);
            this.label16.TabIndex = 74;
            this.label16.Text = "Estoque:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesc.Location = new System.Drawing.Point(9, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(174, 26);
            this.txtDesc.TabIndex = 71;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnPesquisarProd
            // 
            this.btnPesquisarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProd.Image = global::prjLeal.Properties.Resources.icons8_pesquisar_20;
            this.btnPesquisarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarProd.Location = new System.Drawing.Point(9, 210);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(118, 33);
            this.btnPesquisarProd.TabIndex = 70;
            this.btnPesquisarProd.Text = "Pesquisar Prod.";
            this.btnPesquisarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarProd.UseVisualStyleBackColor = true;
            this.btnPesquisarProd.Click += new System.EventHandler(this.btnPesquisarProd_Click);
            // 
            // txtCodPro
            // 
            this.txtCodPro.Location = new System.Drawing.Point(58, 3);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(35, 20);
            this.txtCodPro.TabIndex = 76;
            this.txtCodPro.TextChanged += new System.EventHandler(this.txtCodPro_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInserir);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(13, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 58);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInserir.Image = global::prjLeal.Properties.Resources.icons8_auditoria_25;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(16, 17);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(97, 33);
            this.btnInserir.TabIndex = 69;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Image = global::prjLeal.Properties.Resources.icons8_nota_importante_25__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(123, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 67;
            this.button3.Text = "Cancelar Prod.";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Enabled = false;
            this.txtNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumPedido.Location = new System.Drawing.Point(713, 40);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(46, 26);
            this.txtNumPedido.TabIndex = 73;
            this.txtNumPedido.TextChanged += new System.EventHandler(this.txtNumPedido_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label17.Location = new System.Drawing.Point(677, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 23);
            this.label17.TabIndex = 74;
            this.label17.Text = "Nº";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(31, 20);
            this.txtNome.TabIndex = 76;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // grbPag
            // 
            this.grbPag.Controls.Add(this.chkFechado);
            this.grbPag.Controls.Add(this.chkAberto);
            this.grbPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grbPag.Location = new System.Drawing.Point(216, 258);
            this.grbPag.Name = "grbPag";
            this.grbPag.Size = new System.Drawing.Size(100, 68);
            this.grbPag.TabIndex = 78;
            this.grbPag.TabStop = false;
            this.grbPag.Text = "Pagamento";
            this.grbPag.Enter += new System.EventHandler(this.grbPag_Enter);
            // 
            // chkFechado
            // 
            this.chkFechado.AutoSize = true;
            this.chkFechado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkFechado.Location = new System.Drawing.Point(6, 42);
            this.chkFechado.Name = "chkFechado";
            this.chkFechado.Size = new System.Drawing.Size(60, 20);
            this.chkFechado.TabIndex = 1;
            this.chkFechado.Text = "Pago";
            this.chkFechado.UseVisualStyleBackColor = true;
            this.chkFechado.CheckedChanged += new System.EventHandler(this.chkFechado_CheckedChanged);
            // 
            // chkAberto
            // 
            this.chkAberto.AutoSize = true;
            this.chkAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkAberto.Location = new System.Drawing.Point(6, 21);
            this.chkAberto.Name = "chkAberto";
            this.chkAberto.Size = new System.Drawing.Size(90, 20);
            this.chkAberto.TabIndex = 0;
            this.chkAberto.Text = "Em Aberto";
            this.chkAberto.UseVisualStyleBackColor = true;
            this.chkAberto.CheckedChanged += new System.EventHandler(this.chkAberto_CheckedChanged);
            // 
            // txtPag
            // 
            this.txtPag.Location = new System.Drawing.Point(116, 20);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(38, 20);
            this.txtPag.TabIndex = 79;
            this.txtPag.TextChanged += new System.EventHandler(this.txtPag_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(571, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 363);
            this.panel1.TabIndex = 80;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvPedido);
            this.panel2.Controls.Add(this.txtValorall);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 553);
            this.panel2.TabIndex = 81;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.chkComprovante);
            this.panel3.Controls.Add(this.btnTroco);
            this.panel3.Controls.Add(this.txtDebito);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtTotalFin);
            this.panel3.Controls.Add(this.txtDinheiro);
            this.panel3.Controls.Add(this.grbPag);
            this.panel3.Controls.Add(this.txtTroco);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(918, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 548);
            this.panel3.TabIndex = 82;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // chkComprovante
            // 
            this.chkComprovante.AutoSize = true;
            this.chkComprovante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkComprovante.Location = new System.Drawing.Point(171, 512);
            this.chkComprovante.Name = "chkComprovante";
            this.chkComprovante.Size = new System.Drawing.Size(145, 20);
            this.chkComprovante.TabIndex = 99;
            this.chkComprovante.Text = "Gerar Comprovante";
            this.chkComprovante.UseVisualStyleBackColor = true;
            // 
            // btnTroco
            // 
            this.btnTroco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTroco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTroco.Image = global::prjLeal.Properties.Resources.icons8_auditoria_25;
            this.btnTroco.Location = new System.Drawing.Point(163, 255);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(29, 36);
            this.btnTroco.TabIndex = 98;
            this.btnTroco.UseVisualStyleBackColor = true;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // txtDebito
            // 
            this.txtDebito.Enabled = false;
            this.txtDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDebito.Location = new System.Drawing.Point(10, 369);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(147, 26);
            this.txtDebito.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label6.Location = new System.Drawing.Point(10, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 96;
            this.label6.Text = "Débito:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(14, 19);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(39, 21);
            this.txtSobrenome.TabIndex = 81;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnComprovante);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnFinalizar);
            this.panel4.Controls.Add(this.txtNumPedido);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(12, 619);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 100);
            this.panel4.TabIndex = 83;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnComprovante
            // 
            this.btnComprovante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComprovante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComprovante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnComprovante.Image = global::prjLeal.Properties.Resources.icons8_aprovação_50;
            this.btnComprovante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprovante.Location = new System.Drawing.Point(15, 16);
            this.btnComprovante.Name = "btnComprovante";
            this.btnComprovante.Size = new System.Drawing.Size(228, 67);
            this.btnComprovante.TabIndex = 75;
            this.btnComprovante.Text = "Gerar Comprovante";
            this.btnComprovante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprovante.UseVisualStyleBackColor = true;
            this.btnComprovante.Visible = false;
            this.btnComprovante.Click += new System.EventHandler(this.btnComprovante_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::prjLeal.Properties.Resources.icons8_excluir_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1002, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 67);
            this.button2.TabIndex = 44;
            this.button2.Text = "Cancelar Compra";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.Image = global::prjLeal.Properties.Resources.icons8_aprovação_50;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(795, 16);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(201, 67);
            this.btnFinalizar.TabIndex = 43;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtQuantestoq);
            this.panel5.Controls.Add(this.txtCodPro);
            this.panel5.Controls.Add(this.txtCancelado);
            this.panel5.Controls.Add(this.txtCodBarra2);
            this.panel5.Controls.Add(this.txttipPag);
            this.panel5.Controls.Add(this.txtdeb);
            this.panel5.Controls.Add(this.txtValorfin2);
            this.panel5.Controls.Add(this.txtdebito2);
            this.panel5.Controls.Add(this.txtDinheiro2);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.txtPrecounid);
            this.panel5.Controls.Add(this.txtSobrenome);
            this.panel5.Controls.Add(this.txtNome);
            this.panel5.Controls.Add(this.txtPag);
            this.panel5.Location = new System.Drawing.Point(666, 459);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 84;
            this.panel5.Visible = false;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtQuantestoq
            // 
            this.txtQuantestoq.Location = new System.Drawing.Point(41, 59);
            this.txtQuantestoq.Name = "txtQuantestoq";
            this.txtQuantestoq.Size = new System.Drawing.Size(38, 20);
            this.txtQuantestoq.TabIndex = 98;
            // 
            // txtCancelado
            // 
            this.txtCancelado.Location = new System.Drawing.Point(14, 3);
            this.txtCancelado.Name = "txtCancelado";
            this.txtCancelado.Size = new System.Drawing.Size(38, 20);
            this.txtCancelado.TabIndex = 100;
            // 
            // txtCodBarra2
            // 
            this.txtCodBarra2.Location = new System.Drawing.Point(127, 46);
            this.txtCodBarra2.Name = "txtCodBarra2";
            this.txtCodBarra2.Size = new System.Drawing.Size(38, 20);
            this.txtCodBarra2.TabIndex = 99;
            // 
            // txttipPag
            // 
            this.txttipPag.Location = new System.Drawing.Point(160, 25);
            this.txttipPag.Name = "txttipPag";
            this.txttipPag.Size = new System.Drawing.Size(38, 20);
            this.txttipPag.TabIndex = 97;
            // 
            // txtdeb
            // 
            this.txtdeb.Location = new System.Drawing.Point(85, 40);
            this.txtdeb.Name = "txtdeb";
            this.txtdeb.Size = new System.Drawing.Size(31, 20);
            this.txtdeb.TabIndex = 96;
            // 
            // txtValorfin2
            // 
            this.txtValorfin2.Location = new System.Drawing.Point(158, 51);
            this.txtValorfin2.Name = "txtValorfin2";
            this.txtValorfin2.Size = new System.Drawing.Size(39, 20);
            this.txtValorfin2.TabIndex = 85;
            this.txtValorfin2.TextChanged += new System.EventHandler(this.txtValorfin2_TextChanged);
            // 
            // txtdebito2
            // 
            this.txtdebito2.Location = new System.Drawing.Point(148, 3);
            this.txtdebito2.Name = "txtdebito2";
            this.txtdebito2.Size = new System.Drawing.Size(38, 20);
            this.txtdebito2.TabIndex = 95;
            // 
            // txtDinheiro2
            // 
            this.txtDinheiro2.Location = new System.Drawing.Point(158, 77);
            this.txtDinheiro2.Name = "txtDinheiro2";
            this.txtDinheiro2.Size = new System.Drawing.Size(39, 20);
            this.txtDinheiro2.TabIndex = 84;
            this.txtDinheiro2.TextChanged += new System.EventHandler(this.txtDinheiro2_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(74, 59);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(39, 20);
            this.txtTotal.TabIndex = 83;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtPrecounid
            // 
            this.txtPrecounid.Location = new System.Drawing.Point(14, 59);
            this.txtPrecounid.Name = "txtPrecounid";
            this.txtPrecounid.Size = new System.Drawing.Size(39, 20);
            this.txtPrecounid.TabIndex = 82;
            this.txtPrecounid.TextChanged += new System.EventHandler(this.txtPrecounid_TextChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.lealDataSet;
            this.clienteBindingSource.CurrentChanged += new System.EventHandler(this.clienteBindingSource_CurrentChanged);
            // 
            // lealDataSet
            // 
            this.lealDataSet.DataSetName = "LealDataSet";
            this.lealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ItemPedidoTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjLeal.LealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.lealDataSet;
            this.pedidoBindingSource.CurrentChanged += new System.EventHandler(this.pedidoBindingSource_CurrentChanged);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.lealDataSet;
            this.clienteBindingSource1.CurrentChanged += new System.EventHandler(this.clienteBindingSource1_CurrentChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(164, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 26);
            this.btnBuscar.TabIndex = 76;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1254, 731);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CAIXA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCaixa_FormClosing);
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantComp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.grbPag.ResumeLayout(false);
            this.grbPag.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVtotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtTotalFin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private LealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LealDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LealDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesquisarProd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadeEstoq;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown txtQuantComp;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.GroupBox grbPag;
        private System.Windows.Forms.CheckBox chkFechado;
        private System.Windows.Forms.CheckBox chkAberto;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPrecounid;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorfin2;
        private System.Windows.Forms.TextBox txtDinheiro2;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdebito2;
        private System.Windows.Forms.Button btnTroco;
        private System.Windows.Forms.TextBox txtdeb;
        private System.Windows.Forms.TextBox txttipPag;
        private System.Windows.Forms.TextBox txtQuantestoq;
        private System.Windows.Forms.TextBox txtCodBarra2;
        private System.Windows.Forms.TextBox txtCancelado;
        private System.Windows.Forms.Button btnComprovante;
        private System.Windows.Forms.CheckBox chkComprovante;
        private System.Windows.Forms.Button btnBuscar;
    }
}
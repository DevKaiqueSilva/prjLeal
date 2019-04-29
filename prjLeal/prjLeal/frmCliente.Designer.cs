namespace prjLeal
{
    partial class frmCliente
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
            System.Windows.Forms.Label cod_ClienteLabel;
            System.Windows.Forms.Label nome_ClienteLabel;
            System.Windows.Forms.Label sobrenome_ClienteLabel;
            System.Windows.Forms.Label dataNascimento_ClienteLabel;
            System.Windows.Forms.Label endereco_ClienteLabel;
            System.Windows.Forms.Label numeroCasa_ClienteLabel;
            System.Windows.Forms.Label bairro_ClienteLabel;
            System.Windows.Forms.Label cidade_ClienteLabel;
            System.Windows.Forms.Label estado_ClienteLabel;
            System.Windows.Forms.Label telefone_ClienteLabel;
            System.Windows.Forms.Label celular_ClienteLabel;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCasaClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet1 = new prjLeal.LealDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet = new prjLeal.LealDataSet();
            this.clienteTableAdapter = new prjLeal.LealDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new prjLeal.LealDataSetTableAdapters.TableAdapterManager();
            this.pedidoTableAdapter = new prjLeal.LealDataSetTableAdapters.PedidoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fKPedidoDataPed628FA481BindingSource = new System.Windows.Forms.BindingSource(this.components);
            cod_ClienteLabel = new System.Windows.Forms.Label();
            nome_ClienteLabel = new System.Windows.Forms.Label();
            sobrenome_ClienteLabel = new System.Windows.Forms.Label();
            dataNascimento_ClienteLabel = new System.Windows.Forms.Label();
            endereco_ClienteLabel = new System.Windows.Forms.Label();
            numeroCasa_ClienteLabel = new System.Windows.Forms.Label();
            bairro_ClienteLabel = new System.Windows.Forms.Label();
            cidade_ClienteLabel = new System.Windows.Forms.Label();
            estado_ClienteLabel = new System.Windows.Forms.Label();
            telefone_ClienteLabel = new System.Windows.Forms.Label();
            celular_ClienteLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPedidoDataPed628FA481BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_ClienteLabel
            // 
            cod_ClienteLabel.AutoSize = true;
            cod_ClienteLabel.Location = new System.Drawing.Point(727, 50);
            cod_ClienteLabel.Name = "cod_ClienteLabel";
            cod_ClienteLabel.Size = new System.Drawing.Size(43, 13);
            cod_ClienteLabel.TabIndex = 96;
            cod_ClienteLabel.Text = "Código:";
            // 
            // nome_ClienteLabel
            // 
            nome_ClienteLabel.AutoSize = true;
            nome_ClienteLabel.Location = new System.Drawing.Point(726, 89);
            nome_ClienteLabel.Name = "nome_ClienteLabel";
            nome_ClienteLabel.Size = new System.Drawing.Size(38, 13);
            nome_ClienteLabel.TabIndex = 98;
            nome_ClienteLabel.Text = "Nome:";
            // 
            // sobrenome_ClienteLabel
            // 
            sobrenome_ClienteLabel.AutoSize = true;
            sobrenome_ClienteLabel.Location = new System.Drawing.Point(885, 89);
            sobrenome_ClienteLabel.Name = "sobrenome_ClienteLabel";
            sobrenome_ClienteLabel.Size = new System.Drawing.Size(64, 13);
            sobrenome_ClienteLabel.TabIndex = 100;
            sobrenome_ClienteLabel.Text = "Sobrenome:";
            // 
            // dataNascimento_ClienteLabel
            // 
            dataNascimento_ClienteLabel.AutoSize = true;
            dataNascimento_ClienteLabel.Location = new System.Drawing.Point(727, 137);
            dataNascimento_ClienteLabel.Name = "dataNascimento_ClienteLabel";
            dataNascimento_ClienteLabel.Size = new System.Drawing.Size(107, 13);
            dataNascimento_ClienteLabel.TabIndex = 102;
            dataNascimento_ClienteLabel.Text = "Data de Nascimento:";
            // 
            // endereco_ClienteLabel
            // 
            endereco_ClienteLabel.AutoSize = true;
            endereco_ClienteLabel.Location = new System.Drawing.Point(729, 186);
            endereco_ClienteLabel.Name = "endereco_ClienteLabel";
            endereco_ClienteLabel.Size = new System.Drawing.Size(56, 13);
            endereco_ClienteLabel.TabIndex = 104;
            endereco_ClienteLabel.Text = "Endereco:";
            // 
            // numeroCasa_ClienteLabel
            // 
            numeroCasa_ClienteLabel.AutoSize = true;
            numeroCasa_ClienteLabel.Location = new System.Drawing.Point(1150, 186);
            numeroCasa_ClienteLabel.Name = "numeroCasa_ClienteLabel";
            numeroCasa_ClienteLabel.Size = new System.Drawing.Size(22, 13);
            numeroCasa_ClienteLabel.TabIndex = 106;
            numeroCasa_ClienteLabel.Text = "Nº:";
            // 
            // bairro_ClienteLabel
            // 
            bairro_ClienteLabel.AutoSize = true;
            bairro_ClienteLabel.Location = new System.Drawing.Point(935, 186);
            bairro_ClienteLabel.Name = "bairro_ClienteLabel";
            bairro_ClienteLabel.Size = new System.Drawing.Size(37, 13);
            bairro_ClienteLabel.TabIndex = 108;
            bairro_ClienteLabel.Text = "Bairro:";
            // 
            // cidade_ClienteLabel
            // 
            cidade_ClienteLabel.AutoSize = true;
            cidade_ClienteLabel.Location = new System.Drawing.Point(840, 137);
            cidade_ClienteLabel.Name = "cidade_ClienteLabel";
            cidade_ClienteLabel.Size = new System.Drawing.Size(43, 13);
            cidade_ClienteLabel.TabIndex = 110;
            cidade_ClienteLabel.Text = "Cidade:";
            // 
            // estado_ClienteLabel
            // 
            estado_ClienteLabel.AutoSize = true;
            estado_ClienteLabel.Location = new System.Drawing.Point(1034, 137);
            estado_ClienteLabel.Name = "estado_ClienteLabel";
            estado_ClienteLabel.Size = new System.Drawing.Size(43, 13);
            estado_ClienteLabel.TabIndex = 112;
            estado_ClienteLabel.Text = "Estado:";
            // 
            // telefone_ClienteLabel
            // 
            telefone_ClienteLabel.AutoSize = true;
            telefone_ClienteLabel.Location = new System.Drawing.Point(729, 234);
            telefone_ClienteLabel.Name = "telefone_ClienteLabel";
            telefone_ClienteLabel.Size = new System.Drawing.Size(52, 13);
            telefone_ClienteLabel.TabIndex = 113;
            telefone_ClienteLabel.Text = "Telefone:";
            // 
            // celular_ClienteLabel
            // 
            celular_ClienteLabel.AutoSize = true;
            celular_ClienteLabel.Location = new System.Drawing.Point(935, 234);
            celular_ClienteLabel.Name = "celular_ClienteLabel";
            celular_ClienteLabel.Size = new System.Drawing.Size(42, 13);
            celular_ClienteLabel.TabIndex = 115;
            celular_ClienteLabel.Text = "Celular:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(1170, 89);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 13);
            label5.TabIndex = 121;
            label5.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.Location = new System.Drawing.Point(545, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 441);
            this.label10.TabIndex = 70;
            this.label10.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.Location = new System.Drawing.Point(545, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 441);
            this.label9.TabIndex = 69;
            this.label9.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 506);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(206, 72);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 506);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(206, 72);
            this.btnExcluir.TabIndex = 67;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(260, 397);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(206, 72);
            this.btnPagar.TabIndex = 66;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 397);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(206, 72);
            this.btnConsultar.TabIndex = 65;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(926, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Venc.:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(970, 331);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 20);
            this.textBox5.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1058, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Total:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1098, 625);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ult. Data:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(744, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.Location = new System.Drawing.Point(545, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 441);
            this.label4.TabIndex = 57;
            this.label4.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(449, 58);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 55;
            this.btnFiltro.Text = "Procurar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(260, 61);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(183, 20);
            this.txtFiltro.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1228, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(729, 66);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(35, 20);
            this.txtCod.TabIndex = 97;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(729, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 99;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(888, 105);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(259, 20);
            this.txtSobrenome.TabIndex = 101;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(729, 153);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(105, 20);
            this.dtpDataNasc.TabIndex = 103;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(729, 202);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(200, 20);
            this.txtEnd.TabIndex = 105;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(938, 202);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 107;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(1153, 202);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 20);
            this.txtNum.TabIndex = 109;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(843, 153);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 20);
            this.txtCidade.TabIndex = 111;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(730, 250);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 20);
            this.txtTel.TabIndex = 114;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(938, 250);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(200, 20);
            this.txtCel.TabIndex = 116;
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(1037, 152);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(50, 21);
            this.cbxUF.TabIndex = 119;
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxSex.Location = new System.Drawing.Point(1173, 105);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(47, 21);
            this.cbxSex.TabIndex = 120;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(565, 240);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(30, 20);
            this.txtFoto.TabIndex = 122;
            this.txtFoto.Visible = false;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.sobrenomeClienteDataGridViewTextBoxColumn,
            this.dataNascimentoClienteDataGridViewTextBoxColumn,
            this.sexoClienteDataGridViewTextBoxColumn,
            this.enderecoClienteDataGridViewTextBoxColumn,
            this.numeroCasaClienteDataGridViewTextBoxColumn,
            this.bairroClienteDataGridViewTextBoxColumn,
            this.cidadeClienteDataGridViewTextBoxColumn,
            this.estadoClienteDataGridViewTextBoxColumn,
            this.telefoneClienteDataGridViewTextBoxColumn,
            this.celularClienteDataGridViewTextBoxColumn,
            this.fotoClienteDataGridViewTextBoxColumn});
            this.clienteDataGridView.DataSource = this.clienteBindingSource1;
            this.clienteDataGridView.Location = new System.Drawing.Point(15, 89);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(507, 265);
            this.clienteDataGridView.TabIndex = 122;
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            this.codClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // sobrenomeClienteDataGridViewTextBoxColumn
            // 
            this.sobrenomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome_Cliente";
            this.sobrenomeClienteDataGridViewTextBoxColumn.HeaderText = "Sobrenome_Cliente";
            this.sobrenomeClienteDataGridViewTextBoxColumn.Name = "sobrenomeClienteDataGridViewTextBoxColumn";
            // 
            // dataNascimentoClienteDataGridViewTextBoxColumn
            // 
            this.dataNascimentoClienteDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento_Cliente";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.HeaderText = "DataNascimento_Cliente";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.Name = "dataNascimentoClienteDataGridViewTextBoxColumn";
            // 
            // sexoClienteDataGridViewTextBoxColumn
            // 
            this.sexoClienteDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Cliente";
            this.sexoClienteDataGridViewTextBoxColumn.HeaderText = "Sexo_Cliente";
            this.sexoClienteDataGridViewTextBoxColumn.Name = "sexoClienteDataGridViewTextBoxColumn";
            // 
            // enderecoClienteDataGridViewTextBoxColumn
            // 
            this.enderecoClienteDataGridViewTextBoxColumn.DataPropertyName = "Endereco_Cliente";
            this.enderecoClienteDataGridViewTextBoxColumn.HeaderText = "Endereco_Cliente";
            this.enderecoClienteDataGridViewTextBoxColumn.Name = "enderecoClienteDataGridViewTextBoxColumn";
            // 
            // numeroCasaClienteDataGridViewTextBoxColumn
            // 
            this.numeroCasaClienteDataGridViewTextBoxColumn.DataPropertyName = "NumeroCasa_Cliente";
            this.numeroCasaClienteDataGridViewTextBoxColumn.HeaderText = "NumeroCasa_Cliente";
            this.numeroCasaClienteDataGridViewTextBoxColumn.Name = "numeroCasaClienteDataGridViewTextBoxColumn";
            // 
            // bairroClienteDataGridViewTextBoxColumn
            // 
            this.bairroClienteDataGridViewTextBoxColumn.DataPropertyName = "Bairro_Cliente";
            this.bairroClienteDataGridViewTextBoxColumn.HeaderText = "Bairro_Cliente";
            this.bairroClienteDataGridViewTextBoxColumn.Name = "bairroClienteDataGridViewTextBoxColumn";
            // 
            // cidadeClienteDataGridViewTextBoxColumn
            // 
            this.cidadeClienteDataGridViewTextBoxColumn.DataPropertyName = "Cidade_Cliente";
            this.cidadeClienteDataGridViewTextBoxColumn.HeaderText = "Cidade_Cliente";
            this.cidadeClienteDataGridViewTextBoxColumn.Name = "cidadeClienteDataGridViewTextBoxColumn";
            // 
            // estadoClienteDataGridViewTextBoxColumn
            // 
            this.estadoClienteDataGridViewTextBoxColumn.DataPropertyName = "Estado_Cliente";
            this.estadoClienteDataGridViewTextBoxColumn.HeaderText = "Estado_Cliente";
            this.estadoClienteDataGridViewTextBoxColumn.Name = "estadoClienteDataGridViewTextBoxColumn";
            // 
            // telefoneClienteDataGridViewTextBoxColumn
            // 
            this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "Telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
            // 
            // celularClienteDataGridViewTextBoxColumn
            // 
            this.celularClienteDataGridViewTextBoxColumn.DataPropertyName = "Celular_Cliente";
            this.celularClienteDataGridViewTextBoxColumn.HeaderText = "Celular_Cliente";
            this.celularClienteDataGridViewTextBoxColumn.Name = "celularClienteDataGridViewTextBoxColumn";
            // 
            // fotoClienteDataGridViewTextBoxColumn
            // 
            this.fotoClienteDataGridViewTextBoxColumn.DataPropertyName = "Foto_Cliente";
            this.fotoClienteDataGridViewTextBoxColumn.HeaderText = "Foto_Cliente";
            this.fotoClienteDataGridViewTextBoxColumn.Name = "fotoClienteDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.lealDataSet1BindingSource;
            // 
            // lealDataSet1BindingSource
            // 
            this.lealDataSet1BindingSource.DataSource = this.lealDataSet1;
            this.lealDataSet1BindingSource.Position = 0;
            // 
            // lealDataSet1
            // 
            this.lealDataSet1.DataSetName = "LealDataSet";
            this.lealDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.lealDataSet;
            // 
            // lealDataSet
            // 
            this.lealDataSet.DataSetName = "LealDataSet";
            this.lealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaixaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjLeal.LealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::prjLeal.Properties.Resources.Cliente;
            this.pictureBox1.Location = new System.Drawing.Point(565, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 170);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // fKPedidoDataPed628FA481BindingSource
            // 
            this.fKPedidoDataPed628FA481BindingSource.DataMember = "FK__Pedido__Data_Ped__628FA481";
            this.fKPedidoDataPed628FA481BindingSource.DataSource = this.clienteBindingSource;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1311, 672);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(label5);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(cod_ClienteLabel);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(nome_ClienteLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(sobrenome_ClienteLabel);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(dataNascimento_ClienteLabel);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(endereco_ClienteLabel);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(numeroCasa_ClienteLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(bairro_ClienteLabel);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(cidade_ClienteLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(estado_ClienteLabel);
            this.Controls.Add(telefone_ClienteLabel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(celular_ClienteLabel);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPedidoDataPed628FA481BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.ComboBox cbxSex;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LealDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private LealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource fKPedidoDataPed628FA481BindingSource;
        private LealDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource lealDataSet1BindingSource;
        private LealDataSet lealDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCasaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoClienteDataGridViewTextBoxColumn;
    }
}
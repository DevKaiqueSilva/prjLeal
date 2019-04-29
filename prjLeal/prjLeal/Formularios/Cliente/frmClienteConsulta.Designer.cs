namespace prjLeal
{
    partial class frmClienteConsulta
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
            System.Windows.Forms.Label label5;
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
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteConsulta));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new prjLeal.LealDataSetTableAdapters.TableAdapterManager();
            this.pedidoTableAdapter = new prjLeal.LealDataSetTableAdapters.PedidoTableAdapter();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet = new prjLeal.LealDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.pedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnConsultarPed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtualizaCadast = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cod_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPag_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_ClienteLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
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
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_ClienteLabel
            // 
            cod_ClienteLabel.AutoSize = true;
            cod_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            cod_ClienteLabel.Location = new System.Drawing.Point(191, 3);
            cod_ClienteLabel.Name = "cod_ClienteLabel";
            cod_ClienteLabel.Size = new System.Drawing.Size(68, 23);
            cod_ClienteLabel.TabIndex = 192;
            cod_ClienteLabel.Text = "Código:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 14.25F);
            label5.Location = new System.Drawing.Point(723, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 23);
            label5.TabIndex = 187;
            label5.Text = "Sexo:";
            // 
            // nome_ClienteLabel
            // 
            nome_ClienteLabel.AutoSize = true;
            nome_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            nome_ClienteLabel.Location = new System.Drawing.Point(191, 58);
            nome_ClienteLabel.Name = "nome_ClienteLabel";
            nome_ClienteLabel.Size = new System.Drawing.Size(61, 23);
            nome_ClienteLabel.TabIndex = 168;
            nome_ClienteLabel.Text = "Nome:";
            // 
            // sobrenome_ClienteLabel
            // 
            sobrenome_ClienteLabel.AutoSize = true;
            sobrenome_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            sobrenome_ClienteLabel.Location = new System.Drawing.Point(381, 58);
            sobrenome_ClienteLabel.Name = "sobrenome_ClienteLabel";
            sobrenome_ClienteLabel.Size = new System.Drawing.Size(104, 23);
            sobrenome_ClienteLabel.TabIndex = 170;
            sobrenome_ClienteLabel.Text = "Sobrenome:";
            // 
            // dataNascimento_ClienteLabel
            // 
            dataNascimento_ClienteLabel.AutoSize = true;
            dataNascimento_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            dataNascimento_ClienteLabel.Location = new System.Drawing.Point(191, 113);
            dataNascimento_ClienteLabel.Name = "dataNascimento_ClienteLabel";
            dataNascimento_ClienteLabel.Size = new System.Drawing.Size(169, 23);
            dataNascimento_ClienteLabel.TabIndex = 172;
            dataNascimento_ClienteLabel.Text = "Data de Nascimento:";
            // 
            // endereco_ClienteLabel
            // 
            endereco_ClienteLabel.AutoSize = true;
            endereco_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            endereco_ClienteLabel.Location = new System.Drawing.Point(188, 168);
            endereco_ClienteLabel.Name = "endereco_ClienteLabel";
            endereco_ClienteLabel.Size = new System.Drawing.Size(87, 23);
            endereco_ClienteLabel.TabIndex = 174;
            endereco_ClienteLabel.Text = "Endereco:";
            // 
            // numeroCasa_ClienteLabel
            // 
            numeroCasa_ClienteLabel.AutoSize = true;
            numeroCasa_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            numeroCasa_ClienteLabel.Location = new System.Drawing.Point(769, 168);
            numeroCasa_ClienteLabel.Name = "numeroCasa_ClienteLabel";
            numeroCasa_ClienteLabel.Size = new System.Drawing.Size(35, 23);
            numeroCasa_ClienteLabel.TabIndex = 176;
            numeroCasa_ClienteLabel.Text = "Nº:";
            // 
            // bairro_ClienteLabel
            // 
            bairro_ClienteLabel.AutoSize = true;
            bairro_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            bairro_ClienteLabel.Location = new System.Drawing.Point(536, 168);
            bairro_ClienteLabel.Name = "bairro_ClienteLabel";
            bairro_ClienteLabel.Size = new System.Drawing.Size(62, 23);
            bairro_ClienteLabel.TabIndex = 178;
            bairro_ClienteLabel.Text = "Bairro:";
            // 
            // cidade_ClienteLabel
            // 
            cidade_ClienteLabel.AutoSize = true;
            cidade_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            cidade_ClienteLabel.Location = new System.Drawing.Point(381, 115);
            cidade_ClienteLabel.Name = "cidade_ClienteLabel";
            cidade_ClienteLabel.Size = new System.Drawing.Size(67, 23);
            cidade_ClienteLabel.TabIndex = 180;
            cidade_ClienteLabel.Text = "Cidade:";
            // 
            // estado_ClienteLabel
            // 
            estado_ClienteLabel.AutoSize = true;
            estado_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            estado_ClienteLabel.Location = new System.Drawing.Point(598, 115);
            estado_ClienteLabel.Name = "estado_ClienteLabel";
            estado_ClienteLabel.Size = new System.Drawing.Size(36, 23);
            estado_ClienteLabel.TabIndex = 182;
            estado_ClienteLabel.Text = "UF:";
            // 
            // telefone_ClienteLabel
            // 
            telefone_ClienteLabel.AutoSize = true;
            telefone_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            telefone_ClienteLabel.Location = new System.Drawing.Point(694, 113);
            telefone_ClienteLabel.Name = "telefone_ClienteLabel";
            telefone_ClienteLabel.Size = new System.Drawing.Size(79, 23);
            telefone_ClienteLabel.TabIndex = 183;
            telefone_ClienteLabel.Text = "Telefone:";
            // 
            // celular_ClienteLabel
            // 
            celular_ClienteLabel.AutoSize = true;
            celular_ClienteLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            celular_ClienteLabel.Location = new System.Drawing.Point(850, 113);
            celular_ClienteLabel.Name = "celular_ClienteLabel";
            celular_ClienteLabel.Size = new System.Drawing.Size(68, 23);
            celular_ClienteLabel.TabIndex = 184;
            celular_ClienteLabel.Text = "Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 14.25F);
            label4.Location = new System.Drawing.Point(754, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 23);
            label4.TabIndex = 204;
            label4.Text = "Cod. Pedido:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-1, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1064, 10);
            this.label3.TabIndex = 194;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 10);
            this.label1.TabIndex = 193;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1067, 10);
            this.label2.TabIndex = 191;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCel.Location = new System.Drawing.Point(698, 139);
            this.txtCel.Mask = "(00)00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(129, 26);
            this.txtCel.TabIndex = 190;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTel.Location = new System.Drawing.Point(854, 139);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 26);
            this.txtTel.TabIndex = 189;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(5, 180);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(30, 20);
            this.txtFoto.TabIndex = 188;
            this.txtFoto.Visible = false;
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxSex.Location = new System.Drawing.Point(726, 82);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(62, 28);
            this.cbxSex.TabIndex = 186;
            // 
            // cbxUF
            // 
            this.cbxUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.cbxUF.Location = new System.Drawing.Point(602, 139);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(64, 28);
            this.cbxUF.TabIndex = 185;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCod.Location = new System.Drawing.Point(194, 29);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(64, 26);
            this.txtCod.TabIndex = 167;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(194, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 26);
            this.txtNome.TabIndex = 169;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSobrenome.Location = new System.Drawing.Point(385, 84);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(308, 26);
            this.txtSobrenome.TabIndex = 171;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(194, 139);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(128, 26);
            this.dtpDataNasc.TabIndex = 173;
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEnd.Location = new System.Drawing.Point(194, 194);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(314, 26);
            this.txtEnd.TabIndex = 175;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBairro.Location = new System.Drawing.Point(540, 194);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 26);
            this.txtBairro.TabIndex = 177;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNum.Location = new System.Drawing.Point(773, 194);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(79, 26);
            this.txtNum.TabIndex = 179;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCidade.Location = new System.Drawing.Point(385, 141);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 26);
            this.txtCidade.TabIndex = 181;
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
            // 
            // lealDataSet
            // 
            this.lealDataSet.DataSetName = "LealDataSet";
            this.lealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 40);
            this.label7.TabIndex = 202;
            this.label7.Text = "Cliente Consulta";
            // 
            // pedidoDataGridView
            // 
            this.pedidoDataGridView.AutoGenerateColumns = false;
            this.pedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Pedido,
            this.Cod_Cliente,
            this.Data_Pedido,
            this.SubTotal_Pedido,
            this.StatusPag_Pedido,
            this.Debito_Pedido});
            this.pedidoDataGridView.DataSource = this.pedidoBindingSource;
            this.pedidoDataGridView.Location = new System.Drawing.Point(204, 16);
            this.pedidoDataGridView.Name = "pedidoDataGridView";
            this.pedidoDataGridView.Size = new System.Drawing.Size(531, 286);
            this.pedidoDataGridView.TabIndex = 202;
            this.pedidoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedidoDataGridView_CellDoubleClick);
            // 
            // txtCodPed
            // 
            this.txtCodPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodPed.Location = new System.Drawing.Point(758, 42);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(75, 26);
            this.txtCodPed.TabIndex = 205;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pedidoDataGridView);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.btnConsultarPed);
            this.panel1.Controls.Add(this.txtCodPed);
            this.panel1.Location = new System.Drawing.Point(12, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 326);
            this.panel1.TabIndex = 206;
            // 
            // btnPagar
            // 
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Image = global::prjLeal.Properties.Resources.icons8_dinheiro_25;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(758, 111);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(132, 31);
            this.btnPagar.TabIndex = 196;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnConsultarPed
            // 
            this.btnConsultarPed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultarPed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultarPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultarPed.Image = global::prjLeal.Properties.Resources.icons8_pesquisar_20;
            this.btnConsultarPed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPed.Location = new System.Drawing.Point(758, 74);
            this.btnConsultarPed.Name = "btnConsultarPed";
            this.btnConsultarPed.Size = new System.Drawing.Size(132, 31);
            this.btnConsultarPed.TabIndex = 203;
            this.btnConsultarPed.Text = "Consultar Pedido";
            this.btnConsultarPed.UseVisualStyleBackColor = true;
            this.btnConsultarPed.Click += new System.EventHandler(this.btnConsultarPed_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAtualizaCadast);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 654);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 73);
            this.panel2.TabIndex = 207;
            // 
            // btnAtualizaCadast
            // 
            this.btnAtualizaCadast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizaCadast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizaCadast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAtualizaCadast.Image = global::prjLeal.Properties.Resources.icons8_salvar_como_50;
            this.btnAtualizaCadast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizaCadast.Location = new System.Drawing.Point(5, 3);
            this.btnAtualizaCadast.Name = "btnAtualizaCadast";
            this.btnAtualizaCadast.Size = new System.Drawing.Size(216, 61);
            this.btnAtualizaCadast.TabIndex = 195;
            this.btnAtualizaCadast.Text = "Atualizar Cadastro";
            this.btnAtualizaCadast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizaCadast.UseVisualStyleBackColor = true;
            this.btnAtualizaCadast.Click += new System.EventHandler(this.btnAtualizaCadast_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Image = global::prjLeal.Properties.Resources.icons8_lixo_50;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(239, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(192, 61);
            this.btnExcluir.TabIndex = 197;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::prjLeal.Properties.Resources.icons8_excluir_50;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(453, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(206, 61);
            this.btnCancelar.TabIndex = 198;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(celular_ClienteLabel);
            this.panel3.Controls.Add(telefone_ClienteLabel);
            this.panel3.Controls.Add(estado_ClienteLabel);
            this.panel3.Controls.Add(this.txtCidade);
            this.panel3.Controls.Add(cidade_ClienteLabel);
            this.panel3.Controls.Add(cod_ClienteLabel);
            this.panel3.Controls.Add(this.txtNum);
            this.panel3.Controls.Add(bairro_ClienteLabel);
            this.panel3.Controls.Add(this.txtCel);
            this.panel3.Controls.Add(this.txtBairro);
            this.panel3.Controls.Add(this.txtTel);
            this.panel3.Controls.Add(numeroCasa_ClienteLabel);
            this.panel3.Controls.Add(this.txtFoto);
            this.panel3.Controls.Add(this.txtEnd);
            this.panel3.Controls.Add(label5);
            this.panel3.Controls.Add(endereco_ClienteLabel);
            this.panel3.Controls.Add(this.cbxSex);
            this.panel3.Controls.Add(this.dtpDataNasc);
            this.panel3.Controls.Add(this.cbxUF);
            this.panel3.Controls.Add(dataNascimento_ClienteLabel);
            this.panel3.Controls.Add(this.txtCod);
            this.panel3.Controls.Add(this.txtSobrenome);
            this.panel3.Controls.Add(nome_ClienteLabel);
            this.panel3.Controls.Add(sobrenome_ClienteLabel);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Location = new System.Drawing.Point(12, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 239);
            this.panel3.TabIndex = 208;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::prjLeal.Properties.Resources.Cliente;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // Cod_Pedido
            // 
            this.Cod_Pedido.DataPropertyName = "Cod_Pedido";
            this.Cod_Pedido.HeaderText = "CodPed";
            this.Cod_Pedido.Name = "Cod_Pedido";
            this.Cod_Pedido.ReadOnly = true;
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            this.Cod_Cliente.HeaderText = "CodCli";
            this.Cod_Cliente.Name = "Cod_Cliente";
            // 
            // Data_Pedido
            // 
            this.Data_Pedido.DataPropertyName = "Data_Pedido";
            this.Data_Pedido.HeaderText = "Data";
            this.Data_Pedido.Name = "Data_Pedido";
            // 
            // SubTotal_Pedido
            // 
            this.SubTotal_Pedido.DataPropertyName = "SubTotal_Pedido";
            this.SubTotal_Pedido.HeaderText = "Total";
            this.SubTotal_Pedido.Name = "SubTotal_Pedido";
            // 
            // StatusPag_Pedido
            // 
            this.StatusPag_Pedido.DataPropertyName = "StatusPag_Pedido";
            this.StatusPag_Pedido.HeaderText = "Status";
            this.StatusPag_Pedido.Name = "StatusPag_Pedido";
            // 
            // Debito_Pedido
            // 
            this.Debito_Pedido.DataPropertyName = "Debito_Pedido";
            this.Debito_Pedido.HeaderText = "Débito";
            this.Debito_Pedido.Name = "Debito_Pedido";
            // 
            // frmClienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1069, 743);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClienteConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cliente Consulta";
            this.Load += new System.EventHandler(this.frmClienteConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAtualizaCadast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LealDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView pedidoDataGridView;
        private System.Windows.Forms.Button btnConsultarPed;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPag_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito_Pedido;
    }
}
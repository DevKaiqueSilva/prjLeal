namespace prjLeal
{
    partial class frmClienteCadast
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
            System.Windows.Forms.Label cod_ClienteLabel;
            System.Windows.Forms.Label nome_ClienteLabel;
            System.Windows.Forms.Label sobrenome_ClienteLabel;
            System.Windows.Forms.Label dataNascimento_ClienteLabel;
            System.Windows.Forms.Label endereco_ClienteLabel;
            System.Windows.Forms.Label numeroCasa_ClienteLabel;
            System.Windows.Forms.Label bairro_ClienteLabel;
            System.Windows.Forms.Label cidade_ClienteLabel;
            System.Windows.Forms.Label telefone_ClienteLabel;
            System.Windows.Forms.Label celular_ClienteLabel;
            System.Windows.Forms.Label estado_ClienteLabel1;
            System.Windows.Forms.Label cbxSexo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteCadast));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.dataNascimento_ClienteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cidade_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.estado_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            cod_ClienteLabel = new System.Windows.Forms.Label();
            nome_ClienteLabel = new System.Windows.Forms.Label();
            sobrenome_ClienteLabel = new System.Windows.Forms.Label();
            dataNascimento_ClienteLabel = new System.Windows.Forms.Label();
            endereco_ClienteLabel = new System.Windows.Forms.Label();
            numeroCasa_ClienteLabel = new System.Windows.Forms.Label();
            bairro_ClienteLabel = new System.Windows.Forms.Label();
            cidade_ClienteLabel = new System.Windows.Forms.Label();
            telefone_ClienteLabel = new System.Windows.Forms.Label();
            celular_ClienteLabel = new System.Windows.Forms.Label();
            estado_ClienteLabel1 = new System.Windows.Forms.Label();
            cbxSexo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_ClienteLabel
            // 
            cod_ClienteLabel.AutoSize = true;
            cod_ClienteLabel.Location = new System.Drawing.Point(306, 52);
            cod_ClienteLabel.Name = "cod_ClienteLabel";
            cod_ClienteLabel.Size = new System.Drawing.Size(43, 13);
            cod_ClienteLabel.TabIndex = 60;
            cod_ClienteLabel.Text = "Código:";
            // 
            // nome_ClienteLabel
            // 
            nome_ClienteLabel.AutoSize = true;
            nome_ClienteLabel.Location = new System.Drawing.Point(305, 91);
            nome_ClienteLabel.Name = "nome_ClienteLabel";
            nome_ClienteLabel.Size = new System.Drawing.Size(38, 13);
            nome_ClienteLabel.TabIndex = 62;
            nome_ClienteLabel.Text = "Nome:";
            // 
            // sobrenome_ClienteLabel
            // 
            sobrenome_ClienteLabel.AutoSize = true;
            sobrenome_ClienteLabel.Location = new System.Drawing.Point(464, 91);
            sobrenome_ClienteLabel.Name = "sobrenome_ClienteLabel";
            sobrenome_ClienteLabel.Size = new System.Drawing.Size(64, 13);
            sobrenome_ClienteLabel.TabIndex = 64;
            sobrenome_ClienteLabel.Text = "Sobrenome:";
            // 
            // dataNascimento_ClienteLabel
            // 
            dataNascimento_ClienteLabel.AutoSize = true;
            dataNascimento_ClienteLabel.Location = new System.Drawing.Point(306, 139);
            dataNascimento_ClienteLabel.Name = "dataNascimento_ClienteLabel";
            dataNascimento_ClienteLabel.Size = new System.Drawing.Size(107, 13);
            dataNascimento_ClienteLabel.TabIndex = 66;
            dataNascimento_ClienteLabel.Text = "Data de Nascimento:";
            // 
            // endereco_ClienteLabel
            // 
            endereco_ClienteLabel.AutoSize = true;
            endereco_ClienteLabel.Location = new System.Drawing.Point(308, 188);
            endereco_ClienteLabel.Name = "endereco_ClienteLabel";
            endereco_ClienteLabel.Size = new System.Drawing.Size(56, 13);
            endereco_ClienteLabel.TabIndex = 70;
            endereco_ClienteLabel.Text = "Endereco:";
            endereco_ClienteLabel.Click += new System.EventHandler(this.endereco_ClienteLabel_Click);
            // 
            // numeroCasa_ClienteLabel
            // 
            numeroCasa_ClienteLabel.AutoSize = true;
            numeroCasa_ClienteLabel.Location = new System.Drawing.Point(729, 188);
            numeroCasa_ClienteLabel.Name = "numeroCasa_ClienteLabel";
            numeroCasa_ClienteLabel.Size = new System.Drawing.Size(22, 13);
            numeroCasa_ClienteLabel.TabIndex = 72;
            numeroCasa_ClienteLabel.Text = "Nº:";
            // 
            // bairro_ClienteLabel
            // 
            bairro_ClienteLabel.AutoSize = true;
            bairro_ClienteLabel.Location = new System.Drawing.Point(514, 188);
            bairro_ClienteLabel.Name = "bairro_ClienteLabel";
            bairro_ClienteLabel.Size = new System.Drawing.Size(37, 13);
            bairro_ClienteLabel.TabIndex = 74;
            bairro_ClienteLabel.Text = "Bairro:";
            // 
            // cidade_ClienteLabel
            // 
            cidade_ClienteLabel.AutoSize = true;
            cidade_ClienteLabel.Location = new System.Drawing.Point(419, 139);
            cidade_ClienteLabel.Name = "cidade_ClienteLabel";
            cidade_ClienteLabel.Size = new System.Drawing.Size(43, 13);
            cidade_ClienteLabel.TabIndex = 76;
            cidade_ClienteLabel.Text = "Cidade:";
            // 
            // telefone_ClienteLabel
            // 
            telefone_ClienteLabel.AutoSize = true;
            telefone_ClienteLabel.Location = new System.Drawing.Point(308, 236);
            telefone_ClienteLabel.Name = "telefone_ClienteLabel";
            telefone_ClienteLabel.Size = new System.Drawing.Size(52, 13);
            telefone_ClienteLabel.TabIndex = 80;
            telefone_ClienteLabel.Text = "Telefone:";
            // 
            // celular_ClienteLabel
            // 
            celular_ClienteLabel.AutoSize = true;
            celular_ClienteLabel.Location = new System.Drawing.Point(410, 236);
            celular_ClienteLabel.Name = "celular_ClienteLabel";
            celular_ClienteLabel.Size = new System.Drawing.Size(42, 13);
            celular_ClienteLabel.TabIndex = 82;
            celular_ClienteLabel.Text = "Celular:";
            // 
            // estado_ClienteLabel1
            // 
            estado_ClienteLabel1.AutoSize = true;
            estado_ClienteLabel1.Location = new System.Drawing.Point(617, 139);
            estado_ClienteLabel1.Name = "estado_ClienteLabel1";
            estado_ClienteLabel1.Size = new System.Drawing.Size(43, 13);
            estado_ClienteLabel1.TabIndex = 90;
            estado_ClienteLabel1.Text = "Estado:";
            // 
            // cbxSexo
            // 
            cbxSexo.AutoSize = true;
            cbxSexo.Location = new System.Drawing.Point(747, 91);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new System.Drawing.Size(34, 13);
            cbxSexo.TabIndex = 92;
            cbxSexo.Text = "Sexo:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 72);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(234, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 72);
            this.btnLimpar.TabIndex = 58;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(-3, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1051, 22);
            this.label12.TabIndex = 57;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 337);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(165, 72);
            this.btnCadastrar.TabIndex = 56;
            this.btnCadastrar.Text = " Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(183, 250);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(66, 23);
            this.btnBuscarFoto.TabIndex = 55;
            this.btnBuscarFoto.Text = "Buscar";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(15, 252);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(162, 20);
            this.txtFoto.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1051, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cadastro";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(308, 68);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(35, 20);
            this.txtCod.TabIndex = 61;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(308, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 63;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(467, 107);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(259, 20);
            this.txtSobrenome.TabIndex = 65;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(308, 155);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(105, 20);
            this.dtpDataNasc.TabIndex = 67;
            this.dtpDataNasc.Value = new System.DateTime(2018, 8, 18, 0, 0, 0, 0);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(308, 204);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(200, 20);
            this.txtEnd.TabIndex = 71;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(517, 204);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 73;
            // 
            // txtNumer
            // 
            this.txtNumer.Location = new System.Drawing.Point(732, 204);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(49, 20);
            this.txtNumer.TabIndex = 75;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(422, 155);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 20);
            this.txtCidade.TabIndex = 77;
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
            this.cbxUF.Location = new System.Drawing.Point(620, 154);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(50, 21);
            this.cbxUF.TabIndex = 91;
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxSex.Location = new System.Drawing.Point(745, 107);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(47, 21);
            this.cbxSex.TabIndex = 93;
            // 
            // dataNascimento_ClienteDateTimePicker
            // 
            this.dataNascimento_ClienteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento_ClienteDateTimePicker.Location = new System.Drawing.Point(308, 155);
            this.dataNascimento_ClienteDateTimePicker.Name = "dataNascimento_ClienteDateTimePicker";
            this.dataNascimento_ClienteDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.dataNascimento_ClienteDateTimePicker.TabIndex = 67;
            // 
            // cidade_ClienteTextBox
            // 
            this.cidade_ClienteTextBox.Location = new System.Drawing.Point(422, 155);
            this.cidade_ClienteTextBox.Name = "cidade_ClienteTextBox";
            this.cidade_ClienteTextBox.Size = new System.Drawing.Size(175, 20);
            this.cidade_ClienteTextBox.TabIndex = 77;
            // 
            // estado_ClienteComboBox
            // 
            this.estado_ClienteComboBox.FormattingEnabled = true;
            this.estado_ClienteComboBox.Items.AddRange(new object[] {
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
            this.estado_ClienteComboBox.Location = new System.Drawing.Point(620, 154);
            this.estado_ClienteComboBox.Name = "estado_ClienteComboBox";
            this.estado_ClienteComboBox.Size = new System.Drawing.Size(50, 21);
            this.estado_ClienteComboBox.TabIndex = 91;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(308, 252);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(91, 20);
            this.txtTel.TabIndex = 94;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(413, 252);
            this.txtCel.Mask = "(00)00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(90, 20);
            this.txtCel.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::prjLeal.Properties.Resources.Cliente;
            this.pictureBox1.Location = new System.Drawing.Point(16, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 170);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // frmClienteCadast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 443);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(cbxSexo);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(estado_ClienteLabel1);
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
            this.Controls.Add(this.txtNumer);
            this.Controls.Add(cidade_ClienteLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(telefone_ClienteLabel);
            this.Controls.Add(celular_ClienteLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClienteCadast";
            this.Text = "frmClienteCadast";
            this.Load += new System.EventHandler(this.frmClienteCadast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.DateTimePicker dataNascimento_ClienteDateTimePicker;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.TextBox cidade_ClienteTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox estado_ClienteComboBox;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LealDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private LealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtCel;
    }
}
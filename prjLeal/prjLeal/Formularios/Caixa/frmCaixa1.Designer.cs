namespace prjLeal.Formularios.Caixa
{
    partial class frmCaixa1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.cbxPesquisa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet1 = new prjLeal.LealDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet = new prjLeal.LealDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new prjLeal.LealDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new prjLeal.LealDataSetTableAdapters.TableAdapterManager();
            this.pedidoTableAdapter = new prjLeal.LealDataSetTableAdapters.PedidoTableAdapter();
            this.fKPedidoDataPed628FA481BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPedidoDataPed628FA481BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Controls.Add(this.btnFiltro);
            this.panel3.Controls.Add(this.txtCod);
            this.panel3.Controls.Add(this.cbxPesquisa);
            this.panel3.Location = new System.Drawing.Point(4, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 48);
            this.panel3.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 125;
            this.label4.Text = "Cod.:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiltro.Location = new System.Drawing.Point(507, 8);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(252, 26);
            this.txtFiltro.TabIndex = 54;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFiltro.Image = global::prjLeal.Properties.Resources.icons8_pesquisar_20;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(1033, 5);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(130, 35);
            this.btnFiltro.TabIndex = 55;
            this.btnFiltro.Text = "Procurar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCod.Location = new System.Drawing.Point(65, 8);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(58, 26);
            this.txtCod.TabIndex = 126;
            // 
            // cbxPesquisa
            // 
            this.cbxPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxPesquisa.FormattingEnabled = true;
            this.cbxPesquisa.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Sobrenome",
            "Sexo",
            "Endereço",
            "Cidade",
            "Estado"});
            this.cbxPesquisa.Location = new System.Drawing.Point(765, 8);
            this.cbxPesquisa.Name = "cbxPesquisa";
            this.cbxPesquisa.Size = new System.Drawing.Size(246, 28);
            this.cbxPesquisa.TabIndex = 124;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.clienteDataGridView);
            this.panel2.Location = new System.Drawing.Point(4, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 487);
            this.panel2.TabIndex = 134;
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
            this.celularClienteDataGridViewTextBoxColumn});
            this.clienteDataGridView.DataSource = this.clienteBindingSource1;
            this.clienteDataGridView.Location = new System.Drawing.Point(3, 6);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(1192, 471);
            this.clienteDataGridView.TabIndex = 122;
            this.clienteDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_CellDoubleClick);
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            this.codClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codClienteDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // sobrenomeClienteDataGridViewTextBoxColumn
            // 
            this.sobrenomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome_Cliente";
            this.sobrenomeClienteDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
            this.sobrenomeClienteDataGridViewTextBoxColumn.Name = "sobrenomeClienteDataGridViewTextBoxColumn";
            // 
            // dataNascimentoClienteDataGridViewTextBoxColumn
            // 
            this.dataNascimentoClienteDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento_Cliente";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.Name = "dataNascimentoClienteDataGridViewTextBoxColumn";
            // 
            // sexoClienteDataGridViewTextBoxColumn
            // 
            this.sexoClienteDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Cliente";
            this.sexoClienteDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoClienteDataGridViewTextBoxColumn.Name = "sexoClienteDataGridViewTextBoxColumn";
            // 
            // enderecoClienteDataGridViewTextBoxColumn
            // 
            this.enderecoClienteDataGridViewTextBoxColumn.DataPropertyName = "Endereco_Cliente";
            this.enderecoClienteDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoClienteDataGridViewTextBoxColumn.Name = "enderecoClienteDataGridViewTextBoxColumn";
            // 
            // numeroCasaClienteDataGridViewTextBoxColumn
            // 
            this.numeroCasaClienteDataGridViewTextBoxColumn.DataPropertyName = "NumeroCasa_Cliente";
            this.numeroCasaClienteDataGridViewTextBoxColumn.HeaderText = "NúmeroCasa";
            this.numeroCasaClienteDataGridViewTextBoxColumn.Name = "numeroCasaClienteDataGridViewTextBoxColumn";
            // 
            // bairroClienteDataGridViewTextBoxColumn
            // 
            this.bairroClienteDataGridViewTextBoxColumn.DataPropertyName = "Bairro_Cliente";
            this.bairroClienteDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroClienteDataGridViewTextBoxColumn.Name = "bairroClienteDataGridViewTextBoxColumn";
            // 
            // cidadeClienteDataGridViewTextBoxColumn
            // 
            this.cidadeClienteDataGridViewTextBoxColumn.DataPropertyName = "Cidade_Cliente";
            this.cidadeClienteDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeClienteDataGridViewTextBoxColumn.Name = "cidadeClienteDataGridViewTextBoxColumn";
            // 
            // estadoClienteDataGridViewTextBoxColumn
            // 
            this.estadoClienteDataGridViewTextBoxColumn.DataPropertyName = "Estado_Cliente";
            this.estadoClienteDataGridViewTextBoxColumn.HeaderText = "UF";
            this.estadoClienteDataGridViewTextBoxColumn.Name = "estadoClienteDataGridViewTextBoxColumn";
            // 
            // telefoneClienteDataGridViewTextBoxColumn
            // 
            this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
            // 
            // celularClienteDataGridViewTextBoxColumn
            // 
            this.celularClienteDataGridViewTextBoxColumn.DataPropertyName = "Celular_Cliente";
            this.celularClienteDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularClienteDataGridViewTextBoxColumn.Name = "celularClienteDataGridViewTextBoxColumn";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(4, 629);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 87);
            this.panel1.TabIndex = 133;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Image = global::prjLeal.Properties.Resources.icons8_pesquisar_50;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(3, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(206, 72);
            this.btnConsultar.TabIndex = 65;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::prjLeal.Properties.Resources.icons8_excluir_50;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(239, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(206, 72);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.ItemPedidoTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjLeal.LealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // fKPedidoDataPed628FA481BindingSource
            // 
            this.fKPedidoDataPed628FA481BindingSource.DataSource = this.clienteBindingSource;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1195, 10);
            this.label3.TabIndex = 132;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 131;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1195, 12);
            this.label2.TabIndex = 130;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // frmCaixa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 727);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaixa1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Escolha o Cliente";
            this.Load += new System.EventHandler(this.frmCaixa1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKPedidoDataPed628FA481BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox cbxPesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView clienteDataGridView;
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
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource lealDataSet1BindingSource;
        private LealDataSet lealDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private LealDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private LealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LealDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource fKPedidoDataPed628FA481BindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
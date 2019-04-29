namespace prjLeal.Formularios.Cliente
{
    partial class frmConsultaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPedido));
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lealDataSet = new prjLeal.LealDataSet();
            this.itemPedidoTableAdapter = new prjLeal.LealDataSetTableAdapters.ItemPedidoTableAdapter();
            this.tableAdapterManager = new prjLeal.LealDataSetTableAdapters.TableAdapterManager();
            this.lealDataSet1 = new prjLeal.LealDataSet();
            this.itemPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPed
            // 
            this.txtCodPed.Location = new System.Drawing.Point(12, 12);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(44, 20);
            this.txtCodPed.TabIndex = 2;
            this.txtCodPed.TextChanged += new System.EventHandler(this.txtCodPed_TextChanged);
            this.txtCodPed.Leave += new System.EventHandler(this.txtCodPed_Leave);
            this.txtCodPed.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodPed_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 601);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lealDataSet
            // 
            this.lealDataSet.DataSetName = "LealDataSet";
            this.lealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemPedidoTableAdapter
            // 
            this.itemPedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ItemPedidoTableAdapter = this.itemPedidoTableAdapter;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjLeal.LealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // lealDataSet1
            // 
            this.lealDataSet1.DataSetName = "LealDataSet";
            this.lealDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemPedidoBindingSource
            // 
            this.itemPedidoBindingSource.DataMember = "ItemPedido";
            this.itemPedidoBindingSource.DataSource = this.lealDataSet;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ItemPedido";
            this.bindingSource1.DataSource = this.lealDataSet;
            // 
            // frmConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodPed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONSULTA PEDIDO";
            this.Load += new System.EventHandler(this.frmConsultaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LealDataSet lealDataSet;
        private LealDataSetTableAdapters.ItemPedidoTableAdapter itemPedidoTableAdapter;
        private LealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCodPed;
        private LealDataSet lealDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemPedidoBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
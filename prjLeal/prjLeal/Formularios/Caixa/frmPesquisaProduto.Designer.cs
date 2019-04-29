namespace prjLeal.Formularios.Caixa
{
    partial class frmPesquisa_Produto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet = new prjLeal.LealDataSet();
            this.lealDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new prjLeal.LealDataSetTableAdapters.ProdutoTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProduto);
            this.panel2.Controls.Add(this.lstProduto);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 488);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProduto.Location = new System.Drawing.Point(3, 34);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(412, 26);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstProduto
            // 
            this.lstProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "CodigoBarra_Produto", true));
            this.lstProduto.DataSource = this.produtoBindingSource;
            this.lstProduto.DisplayMember = "Descricao_Produto";
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.Location = new System.Drawing.Point(0, 68);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(419, 420);
            this.lstProduto.TabIndex = 0;
            this.lstProduto.ValueMember = "CodigoBarra_Produto";
            this.lstProduto.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.lealDataSet;
            // 
            // lealDataSet
            // 
            this.lealDataSet.DataSetName = "LealDataSet";
            this.lealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lealDataSetBindingSource
            // 
            this.lealDataSetBindingSource.DataSource = this.lealDataSet;
            this.lealDataSetBindingSource.Position = 0;
            // 
            // lealDataSetBindingSource1
            // 
            this.lealDataSetBindingSource1.DataSource = this.lealDataSet;
            this.lealDataSetBindingSource1.Position = 0;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquisa Produto";
            // 
            // frmPesquisa_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(439, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmPesquisa_Produto";
            this.Text = "frmPesquisa_Produto";
            this.Load += new System.EventHandler(this.frmPesquisa_Produto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstProduto;
        private System.Windows.Forms.BindingSource lealDataSetBindingSource1;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.BindingSource lealDataSetBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private LealDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
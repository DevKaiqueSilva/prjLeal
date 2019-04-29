namespace prjLeal.Formularios.Caixa
{
    partial class frmNota
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.relatorioComprovanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lealDataSet = new prjLeal.LealDataSet();
            this.relatorioComprovanteTableAdapter = new prjLeal.LealDataSetTableAdapters.RelatorioComprovanteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioComprovanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.relatorioComprovanteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjLeal.Formularios.Caixa.rptComprovante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtCodPed
            // 
            this.txtCodPed.Location = new System.Drawing.Point(466, 46);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(100, 20);
            this.txtCodPed.TabIndex = 1;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(191, 46);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 2;
            // 
            // relatorioComprovanteBindingSource
            // 
            this.relatorioComprovanteBindingSource.DataMember = "Relatorio_Comprovante";
            this.relatorioComprovanteBindingSource.DataSource = this.lealDataSet;
            // 
            // lealDataSet
            // 
            this.lealDataSet.DataSetName = "LealDataSet";
            this.lealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioComprovanteTableAdapter
            // 
            this.relatorioComprovanteTableAdapter.ClearBeforeFill = true;
            // 
            // frmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 575);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtCodPed);
            this.Controls.Add(this.txtCodCli);
            this.Name = "frmNota";
            this.Text = "frmNota";
            this.Load += new System.EventHandler(this.frmNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioComprovanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lealDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.TextBox txtCodCli;
        private LealDataSet lealDataSet;
        private System.Windows.Forms.BindingSource relatorioComprovanteBindingSource;
        private LealDataSetTableAdapters.RelatorioComprovanteTableAdapter relatorioComprovanteTableAdapter;
    }
}
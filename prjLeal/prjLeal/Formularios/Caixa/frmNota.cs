using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLeal.Formularios.Caixa
{
    public partial class frmNota : Form
    {
        public frmNota()
        {
            InitializeComponent();
        }
        public string Pedido { get; set; }
        public string Cliente { get; set; }
        private void frmNota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Relatorio_Comprovante' table. You can move, or remove it, as needed.
            //this.relatorioComprovanteTableAdapter.Fill(this.lealDataSet.Relatorio_Comprovante);
            txtCodCli.Text = this.Cliente;
            txtCodPed.Text = this.Pedido;
            this.relatorioComprovanteTableAdapter.FillByFiltro(this.lealDataSet.Relatorio_Comprovante,int.Parse( txtCodCli.Text), int.Parse(txtCodPed.Text)); 
            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLeal
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LealDataSet.Pedido' table. You can move, or remove it, as needed.
            this.PedidoTableAdapter.Fill(this.LealDataSet.Pedido);

            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.PedidoTableAdapter.FillBy(this.LealDataSet.Pedido);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillByFiltroToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.PedidoTableAdapter.FillByFiltro(this.LealDataSet.Pedido, data_PedidoToolStripTextBox.Text, data_Pedido1ToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {

                this.PedidoTableAdapter.FillByFiltro(this.LealDataSet.Pedido, dateTimePicker1.Text, dateTimePicker2.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

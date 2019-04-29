using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLeal.Formularios.Ferramentas
{
    public partial class frmRelProd : Form
    {
        public frmRelProd()
        {
            InitializeComponent();
        }

        private void frmRelProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.lealDataSet.Usuario);
            // TODO: This line of code loads data into the 'lealDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lealDataSet.Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}

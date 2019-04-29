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
    public partial class frmPesquisa_Produto : Form
    {
        public frmPesquisa_Produto()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lealDataSet.Produto);

        }
        private long _CodigoRetorno;
        public long CodigoRetorno
        {
            get { return _CodigoRetorno; }
            set { _CodigoRetorno = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                produtoBindingSource.Filter = "";
            }
            else
            {
                produtoBindingSource.Filter = "Descricao_Produto like'" + txtProduto.Text + "%'";

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            _CodigoRetorno = (long)lstProduto.SelectedValue;
            Close();
        }
    }
}

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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }
        
        private void caixaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.caixaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.db_06215_1_C_2_2017DataSet);

        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lealDataSet);

        }
        public string Propriedade { get; set; }


        private void frmCaixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lealDataSet.Cliente);
            // TODO: This line of code loads data into the 'lealDataSet.Pedido' table. You can move, or remove it, as needed.
            this.pedidoTableAdapter.Fill(this.lealDataSet.Pedido);
           
            //if(!this.Propriedade.Equals(""))    
            //{
            //    txtUsuario.Text = this.Propriedade;
            //}
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                cbxClientes.Enabled = true;
            }
            if (chkCliente.Checked == false)
            {
                cbxClientes.Enabled = false;
            }
        }

        private void chkDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDinheiro.Checked)
            {
                chkDebito.Enabled = false;
                chkCredito.Enabled = false;
            }
            if (chkDinheiro.Checked == false)
            {

                chkDebito.Enabled = true;
                chkCredito.Enabled = true;
            }
        }

        private void chkCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCredito.Checked)
            {
                chkDebito.Enabled = false;
                chkDinheiro.Enabled = false;
            }
            if (chkCredito.Checked == false)
            {

                chkDebito.Enabled = true;
                chkDinheiro.Enabled = true;
            }
        }

        private void chkDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDebito.Checked)
            {
                chkDinheiro.Enabled = false;
                chkCredito.Enabled = false;
            }
            if (chkDebito.Checked == false)
            {
                chkDinheiro.Enabled = true;
                chkCredito.Enabled = true;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

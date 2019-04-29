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
    public partial class frmCaixa1 : Form
    {
        public frmCaixa1()
        {
            InitializeComponent();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (cbxPesquisa.SelectedItem == "Nome")
            {
                clienteBindingSource1.Filter = "nome_cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Sobrenome")
            {
                clienteBindingSource1.Filter = "sobrenome_cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Sexo")
            {
                clienteBindingSource1.Filter = "sexo_cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Endereço")
            {
                clienteBindingSource1.Filter = "endereco_cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Cidade")
            {
                clienteBindingSource1.Filter = "cidade_cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Estado")
            {
                clienteBindingSource1.Filter = "estado_cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Código")
            {
                clienteBindingSource1.Filter = "Convert(cod_cliente, 'System.String') like '%" + txtFiltro.Text + "%'";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCaixa1_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.lealDataSet1.Cliente);
            txtCod.Focus();
            cbxPesquisa.SelectedItem = "Código";

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (cbxPesquisa.SelectedItem == "Nome")
            {
                clienteBindingSource.Filter = "Nome_Cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Sobrenome")
            {
                clienteBindingSource.Filter = "Sobrenome_Cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Sexo")
            {
                clienteBindingSource.Filter = "Sexo_Cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Endereço")
            {
                clienteBindingSource.Filter = "Endereco_Cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Cidade")
            {
                clienteBindingSource.Filter = "Cidade_Cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Estado")
            {
                clienteBindingSource.Filter = "Estado_Cliente Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Código")
            {
                clienteBindingSource.Filter = "Convert(Cod_Cliente, 'System.String') like '%" + txtFiltro.Text + "%'";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                int cod;
                cod = int.Parse(txtCod.Text);
                frmCaixa consulta = new frmCaixa();
                consulta.codcli = txtCod.Text;
                consulta.Show();
                this.Close();
            }
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codd;
            codd = clienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (codd == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                
                frmCaixa consulta = new frmCaixa();
                consulta.codcli = codd;
                consulta.Show();
                this.Close();
            }
        }
    }
}

using prjLeal.LealDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLeal.Formularios.Produto
{
    public partial class frmAumentPreco : Form
    {
        public frmAumentPreco()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoTableAdapter taProd = new ProdutoTableAdapter();
            DataTable dt;
            dt = taProd.PesquisaCodBarra(Convert.ToInt64(txtCodB.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!");
            }
            else
            {
                string nome, marca;
                
                nome = dt.Rows[0]["Descricao_Produto"].ToString();
                marca = dt.Rows[0]["Marca_Produto"].ToString();
                txtDesc.Text = nome + " ," + marca;
                txtValor.Text = dt.Rows[0]["Preco_Produto"].ToString();
                

            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNovoValor.Text == "")
            {
                MessageBox.Show("Insira um valor!");

            }
            else if (txtNovoValor.Text == "0") 
            {
                MessageBox.Show("Insira um valor!");
            }
            else
            {
                ProdutoTableAdapter taProd = new ProdutoTableAdapter();
                taProd.UpdateValor(Convert.ToDecimal(valornovo), Convert.ToInt64(txtCodB.Text));
                MessageBox.Show("Valor Atualizado com sucesso!");
                txtCodB.Text = "";
                txtDesc.Text = "";
                txtNovoValor.Text = "";
                txtValor.Text = "";


            }
        }

        private void txtNovoValor_TextChanged(object sender, EventArgs e)
        {

        }
        decimal valornovo;
        private void txtNovoValor_Leave(object sender, EventArgs e)
        {
            try
            {
                valornovo = Convert.ToDecimal(txtNovoValor.Text);
                txtNovoValor.Text = valornovo.ToString("C");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

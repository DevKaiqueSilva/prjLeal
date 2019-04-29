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
    public partial class frmInserirProd : Form
    {
        public frmInserirProd()
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
                string quantold;
                nome = dt.Rows[0]["Descricao_Produto"].ToString();
                marca = dt.Rows[0]["Marca_Produto"].ToString();
                txtDesc.Text = nome + " ," + marca;
                txtValor.Text = dt.Rows[0]["Preco_Produto"].ToString();
                txtquatold.Text = dt.Rows[0]["Quantidade_Produto"].ToString();
                
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtNovQuant.Text == "")
            {
                MessageBox.Show("Insira uma quantidade!");
            }
            else if(txtNovQuant.Text == "0")
            {
                MessageBox.Show("Insira uma quantidade!");
            }
            else
            {
                int quantidadenova = Convert.ToInt32(txtNovQuant.Text);
                int quantold = Convert.ToInt32(txtquatold.Text);
                int quantidadetotal = quantold + quantidadenova;
                ProdutoTableAdapter taProd = new ProdutoTableAdapter();
                taProd.UpdateEstoque(quantidadetotal, Convert.ToInt64(txtCodB.Text));
                MessageBox.Show("Quantidade Atualizada com Sucesso!");
                txtCodB.Text = "";
                txtDesc.Text = "";
                txtNovQuant.Text = "";
                txtquatold.Text = "";
                txtValor.Text = "";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace prjLeal
{
    public partial class frmProdutoConsulta : Form
    {
        public frmProdutoConsulta()
        {
            InitializeComponent();
        }
        public string Propriedades { get; set; }
        private void frmProdutoConsulta_Load(object sender, EventArgs e)
        {
            txtCod.Enabled = false;


            if (!this.Propriedades.Equals(""))
            {
                txtCod.Text = this.Propriedades;
            }
            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            DataTable dtProduto;
            dtProduto = taProduto.PesquisaProduto(int.Parse(txtCod.Text));
            
                txtCodBarras.Text = dtProduto.Rows[0]["CodigoBarra_Produto"].ToString();
                txtDesc.Text = dtProduto.Rows[0]["Descricao_Produto"].ToString();
                txtQuantidade.Text = dtProduto.Rows[0]["Quantidade_Produto"].ToString();
                txtTipo.Text = dtProduto.Rows[0]["Tipo_Produto"].ToString();
                txtEmbalagem.Text = dtProduto.Rows[0]["Embalagem_Produto"].ToString();
                txtPreco.Text = dtProduto.Rows[0]["Preco_Produto"].ToString();
                txtMarca.Text = dtProduto.Rows[0]["Marca_Produto"].ToString();
                txtFoto.Text = dtProduto.Rows[0]["Foto_Produto"].ToString();
                if (txtFoto.Text =="")
                {
                }
                else
                {
                    pictureBox1.ImageLocation = txtFoto.Text;
                    pictureBox1.Load();
                }

            
        }

        private void btnAtualizaCadast_Click(object sender, EventArgs e)
        {
            ProdutoTableAdapter taPessoa = new ProdutoTableAdapter();
            taPessoa.UpdateQuery(Convert.ToInt64(txtCodBarras.Text), txtDesc.Text, txtMarca.Text, txtEmbalagem.Text, txtTipo.Text, int.Parse(txtQuantidade.Text), decimal.Parse(txtPreco.Text), txtFoto.Text, int.Parse(txtCod.Text), int.Parse(txtCod.Text));
            MessageBox.Show("Produto Atualizado com sucesso!");
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            DataTable dtProduto;
            dtProduto = taProduto.PesquisaProduto(int.Parse(txtCod.Text));
            if (dtProduto.Rows.Count == 0)
            {
                MessageBox.Show("Pessosa Não Cadastrada");
            }
            else
            {
                txtCodBarras.Text = dtProduto.Rows[0]["CodigoBarra_Produto"].ToString();
                txtDesc.Text = dtProduto.Rows[0]["Descricao_Produto"].ToString();
                txtQuantidade.Text = dtProduto.Rows[0]["Quantidade_Produto"].ToString();
                txtTipo.Text = dtProduto.Rows[0]["Tipo_Produto"].ToString();
                txtEmbalagem.Text = dtProduto.Rows[0]["Embalagem_Produto"].ToString();
                txtPreco.Text = dtProduto.Rows[0]["Preco_Produto"].ToString();
                txtMarca.Text = dtProduto.Rows[0]["Marca_Produto"].ToString();
                txtFoto.Text = dtProduto.Rows[0]["Foto_Produto"].ToString();
                if (pictureBox1.ImageLocation == null)
                {
                }
                else
                {
                    pictureBox1.ImageLocation = txtFoto.Text;
                    pictureBox1.Load();
                }
                if (MessageBox.Show("Deseja Excluir?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    taProduto.Delete2(int.Parse(txtCod.Text));
                txtCod.Focus();
                if (DialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Produto Excluido");
                }
                frmProduto att = new frmProduto();
                att.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmProduto att = new frmProduto();
            att.Show();
            this.Close();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFoto.Text = openFileDialog1.FileName;
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    pictureBox1.Load();
                }
            
        }
    }
}

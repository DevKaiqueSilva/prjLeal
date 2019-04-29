using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjLeal.LealDataSetTableAdapters;

namespace prjLeal
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lealDataSet);

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lealDataSet.Produto);
            txtCod.Focus();
            cbxPesquisa.SelectedItem = "Código";

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                DataTable dtProduto;
                dtProduto = taProduto.PesquisaProduto(int.Parse(txtCod.Text));
                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto Não Cadastrado");
                }
                else
                {
                    int cod;
                    cod = int.Parse(txtCod.Text);
                    frmProdutoConsulta consulta = new frmProdutoConsulta();
                    consulta.Propriedades = txtCod.Text;
                    consulta.Show();
                    this.Close();
                    //txtCodBarras.Text = dtProduto.Rows[0]["CodigoBarra_Produto"].ToString();
                    //txtDesc.Text = dtProduto.Rows[0]["Descricao_Produto"].ToString();
                    //txtQuantidade.Text = dtProduto.Rows[0]["Quantidade_Produto"].ToString();
                    //txtTipo.Text = dtProduto.Rows[0]["Tipo_Produto"].ToString();
                    //txtEmbalagem.Text = dtProduto.Rows[0]["Embalagem_Produto"].ToString();
                    //txtPreco.Text = dtProduto.Rows[0]["Preco_Produto"].ToString();
                    //txtMarca.Text = dtProduto.Rows[0]["Marca_Produto"].ToString();
                    //txtFoto.Text = dtProduto.Rows[0]["Foto_Produto"].ToString();
                    //pictureBox1.ImageLocation = txtFoto.Text;
                    //pictureBox1.Load();

                    //btnConsultar.Text = "Atualizar Produto";
                }
                //}
                //else//gravar
                //{
                //    ProdutoTableAdapter taPessoa = new ProdutoTableAdapter();
                //    taPessoa.Update2(int.Parse(txtCodBarras.Text), txtDesc.Text, txtMarca.Text,txtEmbalagem.Text, txtTipo.Text,int.Parse(txtQuantidade.Text),  int.Parse(txtPreco.Text), txtFoto.Text,int.Parse(txtCod.Text));
                //    btnConsultar.Text = "Consultar";
                //    MessageBox.Show("Produto Atualizado com sucesso!");
                //    Limpar_Caixa();

            }
        }
        private void Limpar_Caixa()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            //DataTable dtProduto;
            //dtProduto = taProduto.PesquisaProduto(int.Parse(txtCod.Text));
            //if (dtProduto.Rows.Count == 0)
            //{
            //    MessageBox.Show("Pessosa Não Cadastrada");
            //}
            //else
            //{
            //    txtCodBarras.Text = dtProduto.Rows[0]["CodigoBarra_Produto"].ToString();
            //    txtDesc.Text = dtProduto.Rows[0]["Descricao_Produto"].ToString();
            //    txtQuantidade.Text = dtProduto.Rows[0]["Quantidade_Produto"].ToString();
            //    txtTipo.Text = dtProduto.Rows[0]["Tipo_Produto"].ToString();
            //    txtEmbalagem.Text = dtProduto.Rows[0]["Embalagem_Produto"].ToString();
            //    txtPreco.Text = dtProduto.Rows[0]["Preco_Produto"].ToString();
            //    txtMarca.Text = dtProduto.Rows[0]["Marca_Produto"].ToString();
            //    txtFoto.Text = dtProduto.Rows[0]["Foto_Produto"].ToString();
            //    pictureBox1.ImageLocation = txtFoto.Text;
            //    pictureBox1.Load();
            //    if (MessageBox.Show("Deseja Excluir?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //        taProduto.Delete2(int.Parse(txtCod.Text));
            //    Limpar_Caixa();
            //    txtCod.Focus();
            //    if (DialogResult == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Produto Excluido");
            //    }
            //    btnConsultar.Text = "Consultar";
            //    Limpar_Caixa();
            //}
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbxPesquisa.SelectedItem == "Descrição")
            {
                produtoBindingSource.Filter = "descricao_produto Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Marca")
            {
                produtoBindingSource.Filter = "marca_produto Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Tipo")
            {
                produtoBindingSource.Filter = "tipo_produto Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Código")
            {
                produtoBindingSource.Filter = "Convert(cod_produto, 'System.String') like '%" + txtFiltro.Text + "%'";
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    txtFoto.Text = openFileDialog1.FileName;
            //    pictureBox1.ImageLocation = openFileDialog1.FileName;
            //    pictureBox1.Load();
            //}
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (cbxPesquisa.SelectedItem == "Descrição")
            {
                produtoBindingSource.Filter = "descricao_produto Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Marca")
            {
                produtoBindingSource.Filter = "marca_produto Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Tipo")
            {
                produtoBindingSource.Filter = "tipo_produto Like '%" + txtFiltro.Text + "%'";
            }
            else if (cbxPesquisa.SelectedItem == "Código")
            {
                produtoBindingSource.Filter = "Convert(cod_produto, 'System.String') like '%" + txtFiltro.Text + "%'";
            }
        }

        private void produtoDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string codd;
            codd = produtoDataGridView.SelectedCells.ToString();
            if (codd == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                DataTable dtProduto;
                dtProduto = taProduto.PesquisaProduto(int.Parse(codd));
                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto Não Cadastrado");
                }
                else
                {
                    int cod;
                    cod = int.Parse(codd);
                    frmProdutoConsulta consulta = new frmProdutoConsulta();
                    consulta.Propriedades = txtCod.Text;
                    consulta.Show();
                    this.Close();
                }  Limpar_Caixa();

            }
        }

        private void produtoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codd;
            codd = produtoDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (codd == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                DataTable dtProduto;
                dtProduto = taProduto.PesquisaProduto(int.Parse(codd));
                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto Não Cadastrado");
                }
                else
                {
                    int cod;
                    cod = int.Parse(codd);
                    frmProdutoConsulta consulta = new frmProdutoConsulta();
                    consulta.Propriedades = codd;
                    consulta.Show();
                    this.Close();
                }
                Limpar_Caixa();

            }
        }
    }
}

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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            btnPagar.Enabled = true;
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtTel.Enabled = true;
            txtNum.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtCel.Enabled = true;
            txtEnd.Enabled = true;
            txtFoto.Enabled = true;
            cbxSex.Enabled = true;
            cbxUF.Enabled = true;
            dtpDataNasc.Enabled = true;
            if (btnConsultar.Text == "Consultar")
            {
                ClienteTableAdapter taPessoa = new ClienteTableAdapter();
                DataTable dtPessoa;
                dtPessoa = taPessoa.PesquisaCliente(int.Parse(txtCod.Text));
                if (dtPessoa.Rows.Count == 0)
                {
                    MessageBox.Show("Pessosa Não Cadastrada");
                }
                else
                {
                    txtNome.Text = dtPessoa.Rows[0]["Nome_Cliente"].ToString();
                    txtSobrenome.Text = dtPessoa.Rows[0]["Sobrenome_Cliente"].ToString();
                    dtpDataNasc.Value = DateTime.Parse(dtPessoa.Rows[0]["DataNascimento_Cliente"].ToString());
                    cbxSex.Text = dtPessoa.Rows[0]["Sexo_Cliente"].ToString();
                    txtEnd.Text = dtPessoa.Rows[0]["Endereco_Cliente"].ToString();
                    txtNum.Text = dtPessoa.Rows[0]["NumeroCasa_Cliente"].ToString();
                    txtBairro.Text = dtPessoa.Rows[0]["Bairro_Cliente"].ToString();
                    txtCidade.Text = dtPessoa.Rows[0]["Cidade_Cliente"].ToString();
                    cbxUF.Text = dtPessoa.Rows[0]["Estado_Cliente"].ToString();
                    txtTel.Text = dtPessoa.Rows[0]["Telefone_Cliente"].ToString();
                    txtCel.Text = dtPessoa.Rows[0]["Celular_Cliente"].ToString();
                    txtFoto.Text = dtPessoa.Rows[0]["Foto_Cliente"].ToString();
                    pictureBox1.ImageLocation = txtFoto.Text;
                    pictureBox1.Load();

                    btnConsultar.Text = "Atualizar Cadastro";
                   
                }

            }
            else//gravar
            {
                ClienteTableAdapter taPessoa = new ClienteTableAdapter();
                taPessoa.Update(txtNome.Text, txtSobrenome.Text,dtpDataNasc.Value, cbxSex.Text, txtEnd.Text, int.Parse(txtNum.Text), txtBairro.Text, txtCidade.Text, cbxUF.Text, txtTel.Text, txtCel.Text, txtFoto.Text,int.Parse(txtCod.Text));
                btnConsultar.Text = "Consultar";
                MessageBox.Show("Pessoa Atualizada com sucesso!");
                Limpar_Caixa();

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

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteTableAdapter tapessoa = new ClienteTableAdapter();
            DataTable dtPessoa;
            dtPessoa = tapessoa.PesquisaCliente(int.Parse(txtCod.Text));
            if (dtPessoa.Rows.Count == 0)
            {
                MessageBox.Show("Pessosa Não Cadastrada");
            }
            else
            {
                txtNome.Text = dtPessoa.Rows[0]["Nome_Cliente"].ToString();
                txtSobrenome.Text = dtPessoa.Rows[0]["Sobrenome_Cliente"].ToString();
                dtpDataNasc.Value = DateTime.Parse(dtPessoa.Rows[0]["DataNascimento_Cliente"].ToString());
                cbxSex.Text = dtPessoa.Rows[0]["Sexo_Cliente"].ToString();
                txtEnd.Text = dtPessoa.Rows[0]["Endereco_Cliente"].ToString();
                txtNum.Text = dtPessoa.Rows[0]["NumeroCasa_Cliente"].ToString();
                txtBairro.Text = dtPessoa.Rows[0]["Bairro_Cliente"].ToString();
                txtCidade.Text = dtPessoa.Rows[0]["Cidade_Cliente"].ToString();
                cbxUF.Text = dtPessoa.Rows[0]["Estado_Cliente"].ToString();
                txtTel.Text = dtPessoa.Rows[0]["Telefone_Cliente"].ToString();
                txtCel.Text = dtPessoa.Rows[0]["Celular_Cliente"].ToString();
                txtFoto.Text = dtPessoa.Rows[0]["Foto_Cliente"].ToString();
                if (MessageBox.Show("Deseja Excluir?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    tapessoa.Delete2(int.Parse(txtCod.Text));
                Limpar_Caixa();
                txtCod.Focus();
                if (DialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Pessoa Excluida");
                }
                btnConsultar.Text = "Consultar";
            }
        }

        private void datagridToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.datagrid(this.lealDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

            ClienteTableAdapter filtro = new ClienteTableAdapter();
            clienteBindingSource.Filter = "Nome_Cliente Like '%" +txtFiltro.Text+"%'";
        
        }

        private void mostrargridToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.mostrargrid(this.lealDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lealDataSet1.Cliente);
            // TODO: This line of code loads data into the 'lealDataSet.Pedido' table. You can move, or remove it, as needed.
            this.pedidoTableAdapter.Fill(this.lealDataSet.Pedido);
            btnExcluir.Enabled = false;
            btnPagar.Enabled = false;
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtTel.Enabled = false;
            txtNum.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtCel.Enabled = false;
            txtEnd.Enabled = false;
            txtFoto.Enabled = false;
            cbxSex.Enabled = false;
            cbxUF.Enabled = false;
            dtpDataNasc.Enabled = false;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

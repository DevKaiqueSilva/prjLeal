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
            if (txtCod.Text == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                int cod;
                cod = int.Parse(txtCod.Text);
                frmClienteConsulta consulta = new frmClienteConsulta();
                consulta.Propriedades = txtCod.Text;
                consulta.Show();
                this.Close();
            }
            //btnExcluir.Enabled = true;
            //btnPagar.Enabled = true;
            //txtNome.Enabled = true;
            //txtSobrenome.Enabled = true;
            //txtTel.Enabled = true;
            //txtNum.Enabled = true;
            //txtCidade.Enabled = true;
            //txtBairro.Enabled = true;
            //txtCel.Enabled = true;
            //txtEnd.Enabled = true;
            //txtFoto.Enabled = true;
            //cbxSex.Enabled = true;
            //cbxUF.Enabled = true;
            //dtpDataNasc.Enabled = true;
            //if (btnConsultar.Text == "Consultar")
            //{
            //    ClienteTableAdapter taPessoa = new ClienteTableAdapter();
            //    DataTable dtPessoa;

            //    if (txtCod.Text == "")
            //    {
            //        MessageBox.Show("Insira um valor no código!");
            //    }
            //    else
            //    {
            //        dtPessoa = taPessoa.Pesquisa_Cliente(int.Parse(txtCod.Text));
            //        if (dtPessoa.Rows.Count == 0)
            //        {
            //            MessageBox.Show("Pessosa Não Cadastrada");
            //        }
            //        else
            //        {
            //            txtNome.Text = dtPessoa.Rows[0]["Nome_Cliente"].ToString();
            //            txtSobrenome.Text = dtPessoa.Rows[0]["Sobrenome_Cliente"].ToString();
            //            dtpDataNasc.Value = DateTime.Parse(dtPessoa.Rows[0]["DataNascimento_Cliente"].ToString());
            //            cbxSex.Text = dtPessoa.Rows[0]["Sexo_Cliente"].ToString();
            //            txtEnd.Text = dtPessoa.Rows[0]["Endereco_Cliente"].ToString();
            //            txtNum.Text = dtPessoa.Rows[0]["NumeroCasa_Cliente"].ToString();
            //            txtBairro.Text = dtPessoa.Rows[0]["Bairro_Cliente"].ToString();
            //            txtCidade.Text = dtPessoa.Rows[0]["Cidade_Cliente"].ToString();
            //            cbxUF.Text = dtPessoa.Rows[0]["Estado_Cliente"].ToString();
            //            txtTel.Text = dtPessoa.Rows[0]["Telefone_Cliente"].ToString();
            //            txtCel.Text = dtPessoa.Rows[0]["Celular_Cliente"].ToString();
            //            txtFoto.Text = dtPessoa.Rows[0]["Foto_Cliente"].ToString();
            //            if (pictureBox1.ImageLocation == null)
            //            {
            //            }
            //            else
            //            {
            //                pictureBox1.ImageLocation = txtFoto.Text;
            //                pictureBox1.Load();
            //            }


            //            btnConsultar.Text = "Atualizar Cadastro";
            //            clienteDataGridView.Refresh();
            //        }
            //    }

    //}
    //        else//gravar
    //        {
    //            ClienteTableAdapter taPessoa = new ClienteTableAdapter();
    //            taPessoa.UpdateQuery1(txtNome.Text, txtSobrenome.Text,dtpDataNasc.Text, cbxSex.Text, txtEnd.Text, int.Parse(txtNum.Text), txtBairro.Text, txtCidade.Text, cbxUF.Text, txtTel.Text, txtCel.Text, txtFoto.Text,int.Parse(txtCod.Text), int.Parse(txtCod.Text));
    //            btnConsultar.Text = "Consultar";
    //            MessageBox.Show("Pessoa Atualizada com sucesso!");
    //            Limpar_Caixa();

    //        }
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

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    //ClienteTableAdapter tapessoa = new ClienteTableAdapter();
        //    //DataTable dtPessoa;
        //    //dtPessoa = tapessoa.Pesquisa_Cliente(int.Parse(txtCod.Text));
        //    //if (dtPessoa.Rows.Count == 0)
        //    //{
        //    //    MessageBox.Show("Pessosa Não Cadastrada");
        //    //}
        //    //else
        //    //{
        //    //    txtNome.Text = dtPessoa.Rows[0]["Nome_Cliente"].ToString();
        //    //    txtSobrenome.Text = dtPessoa.Rows[0]["Sobrenome_Cliente"].ToString();
        //    //    dtpDataNasc.Value = DateTime.Parse(dtPessoa.Rows[0]["DataNascimento_Cliente"].ToString());
        //    //    cbxSex.Text = dtPessoa.Rows[0]["Sexo_Cliente"].ToString();
        //    //    txtEnd.Text = dtPessoa.Rows[0]["Endereco_Cliente"].ToString();
        //    //    txtNum.Text = dtPessoa.Rows[0]["NumeroCasa_Cliente"].ToString();
        //    //    txtBairro.Text = dtPessoa.Rows[0]["Bairro_Cliente"].ToString();
        //    //    txtCidade.Text = dtPessoa.Rows[0]["Cidade_Cliente"].ToString();
        //    //    cbxUF.Text = dtPessoa.Rows[0]["Estado_Cliente"].ToString();
        //    //    txtTel.Text = dtPessoa.Rows[0]["Telefone_Cliente"].ToString();
        //    //    txtCel.Text = dtPessoa.Rows[0]["Celular_Cliente"].ToString();
        //    //    txtFoto.Text = dtPessoa.Rows[0]["Foto_Cliente"].ToString();
        //    //    if (MessageBox.Show("Deseja Excluir?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //    //        tapessoa.Delete2(int.Parse(txtCod.Text));
        //    //    Limpar_Caixa();
        //    //    txtCod.Focus();
        //    //    if (DialogResult == DialogResult.Yes)
        //    //    {
        //    //        MessageBox.Show("Pessoa Excluida");
        //    //    }
        //    //    btnConsultar.Text = "Consultar";
        //    //    clienteDataGridView.Refresh();
        //    //}
        //}

        private void datagridToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.clienteTableAdapter.datagrid(this.lealDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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

        private void mostrargridToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.clienteTableAdapter.mostrargrid(this.lealDataSet.Cliente);
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
            //this.pedidoTableAdapter.Fill(this.lealDataSet.Pedido);
            //btnExcluir.Enabled = false;
            //btnPagar.Enabled = false;
            //txtNome.Enabled = false;
            //txtSobrenome.Enabled = false;
            //txtTel.Enabled = false;
            //txtNum.Enabled = false;
            //txtCidade.Enabled = false;
            //txtBairro.Enabled = false;
            //txtCel.Enabled = false;
            //txtEnd.Enabled = false;
            //txtFoto.Enabled = false;
            //cbxSex.Enabled = false;
            //cbxUF.Enabled = false;
            //dtpDataNasc.Enabled = false;.
            txtCod.Focus();
            cbxPesquisa.SelectedItem = "Código";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

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
                
                frmClienteConsulta consulta = new frmClienteConsulta();
                consulta.Propriedades = codd;
                consulta.Show();
                this.Close();
            }
        }
        }
}

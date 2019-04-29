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
using prjLeal.Formularios;
using prjLeal.Formularios.Cliente;
using prjLeal.Formularios.Caixa;

namespace prjLeal
{
    public partial class frmClienteConsulta : Form
    {
        public frmClienteConsulta()
        {
            InitializeComponent();

            
        }
        //public frmClienteConsulta(int codped)
        //{
        //    InitializeComponent();
        //    txtCodPed.Text = codped.ToString();
        //}
        
        public string Propriedades { get; set; }
        private void btnAtualizaCadast_Click(object sender, EventArgs e)
        {
                ClienteTableAdapter taPessoa = new ClienteTableAdapter();
                taPessoa.UpdateQuery1(txtNome.Text, txtSobrenome.Text, dtpDataNasc.Text, cbxSex.Text, txtEnd.Text, int.Parse(txtNum.Text), txtBairro.Text, txtCidade.Text, cbxUF.Text, txtTel.Text, txtCel.Text, txtFoto.Text, int.Parse(txtCod.Text), int.Parse(txtCod.Text));
                
                MessageBox.Show("Pessoa Atualizada com sucesso!");
                frmCliente att = new frmCliente();
                att.Show();
                this.Close();


            
        }

        private void frmClienteConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Pedido' table. You can move, or remove it, as needed.
            //this.pedidoTableAdapter.Fill(this.lealDataSet.Pedido);
            // TODO: This line of code loads data into the 'lealDataSet.Pedido' table. You can move, or remove it, as needed.
            //this.pedidoTableAdapter.Fill(this.lealDataSet.Pedido);
            
            txtCod.Enabled = false;
                frmCliente usu = new frmCliente();

                if (!this.Propriedades.Equals(""))
                {
                txtCod.Text = this.Propriedades;
                }
            
                ClienteTableAdapter taPessoa = new ClienteTableAdapter();
                DataTable dtPessoa;

                
                    dtPessoa = taPessoa.Pesquisa_Cliente(int.Parse(txtCod.Text));
                    if (dtPessoa.Rows.Count == 0)
                    {
                        MessageBox.Show("Pessosa Não Cadastrada");
                        this.Close();
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
                        if(txtFoto.Text == "")
                        {
                        }
                        else
                        {
                            pictureBox1.ImageLocation = txtFoto.Text;
                            pictureBox1.Load();
                        }
                this.pedidoTableAdapter.FillBy2(this.lealDataSet.Pedido, Convert.ToInt32(txtCod.Text));
                
                //PedidoTableAdapter taPedido = new PedidoTableAdapter();
                //DataTable dt;
                //dt = taPedido.SelectCliente(Convert.ToInt32(txtCod.Text));
                //pedidoDataGridView.DataSource = dt;
            }

           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteTableAdapter tapessoa = new ClienteTableAdapter();
            DataTable dtPessoa;
            dtPessoa = tapessoa.Pesquisa_Cliente(int.Parse(txtCod.Text));
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
                txtCod.Focus();
                if (DialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Pessoa Excluida");
                }
                frmCliente att = new frmCliente();
                att.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmCliente att = new frmCliente();
            att.Show();
            this.Close();
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lealDataSet);

        }

        private void pedidoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lealDataSet);

        }

        private void btnConsultarPed_Click(object sender, EventArgs e)
        {
            if(txtCodPed.Text =="")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
            frmConsultaPedido formDestino = new frmConsultaPedido();
            formDestino.Propriedade = txtCodPed.Text;
            formDestino.Show();
            }
            
        }
    
        public int codped;

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtCodPed.Text == "")
            {
                MessageBox.Show("Insira um valor no código!");
            }
            else
            {
                frmCaixaCli formDestino = new frmCaixaCli();
                formDestino.Propriedade = txtCodPed.Text;
                formDestino.codcli = txtCod.Text;
                formDestino.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pedidoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codd;
            codd = pedidoDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtCodPed.Text = codd;
        }

        
    }
}

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
using System.Globalization;
using prjLeal.Formularios.Caixa;

namespace prjLeal
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
            
        }
       
        public string codcli { get; set; }
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
            try
            {
                txtPag.Text = "Cancelado";
                dateTimePicker1.Text = DateTime.Now.ToString();
                PedidoTableAdapter taPedido = new PedidoTableAdapter();
                string ultimopedido= taPedido.UltimoCOD().ToString();
                txtNumPedido.Text = ultimopedido;
                if (!this.codcli.Equals(""))
                {
                    txtCodCli.Text = this.codcli;
                }
                ClienteTableAdapter taCliente = new ClienteTableAdapter();
                DataTable dtCliente;
                dtCliente = taCliente.Pesquisa_Cliente(int.Parse(txtCodCli.Text));
                if (dtCliente.Rows.Count == 0)
                {
                    MessageBox.Show("Pessosa Não Cadastrada");
                    this.Close();
                }
                else
                {
                    txtNome.Text = dtCliente.Rows[0]["Nome_Cliente"].ToString();
                    txtSobrenome.Text = dtCliente.Rows[0]["Sobrenome_Cliente"].ToString();
                    txtNomeCli.Text = txtNome.Text + " " + txtSobrenome.Text;
                }
                
                    //ClienteTableAdapter taCliente = new ClienteTableAdapter();
                    //DataTable dtCliente;
                    //dtCliente = taCliente.QueyBox2();
                    //cbxClientes.Text = dtCliente.Rows[1]["NomeComp"].ToString(); ;
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDinheiro.Checked)
            {
                chkDebito.Enabled = false;
                chkCredito.Enabled = false;
                txttipPag.Text = "Dinheiro";
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
                txttipPag.Text = "Crédito";
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
                txttipPag.Text = "Débito";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            if (txtCodigoB.Text != "")
            {
               

                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();

                DataTable dtProduto;
                dtProduto = taProduto.PesquisaCodBarra(Convert.ToInt64(txtCodigoB.Text));

                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto não encontrado. Verifique se o mesmo foi cadastrado ou digitado corretamente.");
                }
                else
                {
                    txtCodPro.Text = dtProduto.Rows[0]["Cod_Produto"].ToString();
                    txtDesc.Text = dtProduto.Rows[0]["Descricao_Produto"].ToString();
                    txtQuantidadeEstoq.Text = dtProduto.Rows[0]["Quantidade_Produto"].ToString();
                    txtPrecounid.Text = dtProduto.Rows[0]["Preco_Produto"].ToString();
                    decimal preco = Convert.ToDecimal(txtPrecounid.Text);
                    CultureInfo ci = new CultureInfo("pt-BR");
                    txtPreco.Text = preco.ToString("C2", ci);
                    txtMarca.Text = dtProduto.Rows[0]["Marca_Produto"].ToString();
                }
                

            }
        }
        
        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try {


                int estoque = int.Parse(txtQuantidadeEstoq.Text);
                if (txtQuantComp.Value <= estoque)
                {
                    string marca = txtMarca.Text;
                    //decimal precounit = Convert.ToDecimal(txtPrecounid.Text);
                    ////preco = preco.Replace("R$", "#######,##");
                    CultureInfo ci = new CultureInfo("pt-BR");
                    //txtPreco.Text= precounit.ToString("C2", ci);
                    //decimal total = Convert.ToDecimal(txtVtotal.Text);
                    //txtVtotal.Text = total.ToString("C2", ci);
                    //total = total.Replace("R$ ", "#######,##");
                    if (txtMarca.Text != "")
                    {
                        txtDesc.Text = txtDesc.Text + ", " + txtMarca.Text;
                    }
                    else if (txtMarca.Text == "")
                    {
                        txtDesc.Text = txtMarca.Text;
                    }

                    if (txtQuantComp.Value != 0)
                    {
                        decimal totalvenda = 0;
                        string pag = "";
                        PedidoTableAdapter taPedido = new PedidoTableAdapter();
                        taPedido.Insert(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, totalvenda, pag,0);
                        ItemPedidoTableAdapter taItemPedido = new ItemPedidoTableAdapter();
                        
                        string quantidadeprod = txtQuantComp.Value.ToString();
                        taItemPedido.Insert(Convert.ToInt32(txtNumPedido.Text), int.Parse(quantidadeprod), int.Parse(txtCodPro.Text));
                        dgvPedido.Rows.Add(txtCodigoB.Text, txtDesc.Text, txtPrecounid.Text, txtQuantComp.Value.ToString(), txtTotal.Text);
                        {
                            //decimal total2 = 0;
                            //int i = 0;
                            //for (i = 0; i < dgvPedido.Rows.Count; i++)
                            //{
                            //    total2 = total2 + Convert.ToDecimal(dgvPedido.Rows[i].Cells["Total"].Value);
                            //}

                            //txtVtotal.Text = total2.ToString("C2", ci);
                            
                            string novoEstoque = (Convert.ToDecimal(txtQuantidadeEstoq.Text) - Convert.ToDecimal(txtQuantComp.Text)).ToString();
                            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                            taProduto.UpdateEstoque(int.Parse(novoEstoque), Convert.ToInt64(txtCodigoB.Text));
                            

                        }
                        decimal valorTotal = 0;
                        foreach (DataGridViewRow col in dgvPedido.Rows)
                        {
                            valorTotal = valorTotal +Convert.ToDecimal(col.Cells[4].Value);
                        }

                        //decimal valorall = Convert.ToDecimal(txtValorall.Text);
                        txtValorfin2.Text = valorTotal.ToString();
                        txtValorall.Text = valorTotal.ToString("C2", ci);
                        txtTotalFin.Text = valorTotal.ToString("C2", ci);
                        //txtTotalFin.Text = valorTotal.ToString("C2", ci);

                        txtCodigoB.Focus();
                        txtQuantComp.Text = "";
                        txtPreco.Text = "";
                        txtDesc.Text = "";
                        txtCodigoB.Text = "";
                        txtQuantidadeEstoq.Text = "";
                        txtVtotal.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Adicione um quantidade!");
                    }
                }
                else
                {
                    MessageBox.Show("A quantidade ultrapassa o estoque.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Favor completar os espaços em branco.");
            }
        }
       
       private void txtQuantComp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVtotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQuantComp_ValueChanged(object sender, EventArgs e)
        {
            //if (txtQuantComp.Text == "0")
            //{
            //    string preco2 = txtPreco.Text;
            //    decimal total3 = Convert.ToDecimal(preco2);
            //    txtVtotal.Text = total3.ToString();
            //}
            //else
            //{
            if(txtCodPro.Text =="")
            {
                MessageBox.Show("Pesquisa pelo código de barras!");
            }
            else
            { 
                int quanti = Convert.ToInt32(txtQuantComp.Value);
                decimal precounid = Convert.ToDecimal(txtPrecounid.Text);
                decimal total =  precounid * quanti;
                
                txtVtotal.Text = total.ToString();
                txtTotal.Text = total.ToString();
                CultureInfo ci = new CultureInfo("pt-BR");
                decimal vtotal = Convert.ToDecimal(txtVtotal.Text);
                txtVtotal.Text = vtotal.ToString("C2", ci);
            }

        }

        private void txtQuantComp_DoubleClick(object sender, EventArgs e)
        {
            //if (txtQuantComp.Text == "1")
            //{
            //    string preco2 = txtPreco.Text;
            //    decimal total3 = Convert.ToDecimal(preco2);
            //    txtVtotal.Text = total3.ToString();
            //}
            //else
            //{
            //    int quant = int.Parse(txtQuantComp.Text);
            //    string preco = txtPreco.Text;
            //    decimal total = Convert.ToDecimal(preco) * quant;
            //    txtVtotal.Text = total.ToString();
            //}
        }

        private void txtQuantComp_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuantComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string qtdCancelada = dgvPedido.CurrentRow.Cells[3].Value.ToString();
                txtCancelado.Text = qtdCancelada;
                string codPro = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                txtCodBarra2.Text = codPro;
                dgvPedido.Rows.Remove(dgvPedido.CurrentRow);
                decimal total = 0;
                int i = 0;
                for (i = 0; i < dgvPedido.Rows.Count; i++)
                {
                    total = total + Convert.ToDecimal(dgvPedido.Rows[i].Cells["Total"].Value);
                }
                txtVtotal.Text = "R$" + (total).ToString();
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                DataTable dt;
                dt= taProduto.PesquisaCodBarra(Convert.ToInt64(txtCodBarra2.Text));
                txtQuantestoq.Text = dt.Rows[0]["Quantidade_Produto"].ToString();
                int voltestoq = Convert.ToInt32(txtQuantestoq.Text) + Convert.ToInt32(txtCancelado.Text);
                taProduto.RetornarEstoque(voltestoq, Convert.ToInt64(txtCodBarra2.Text));

                CultureInfo ci = new CultureInfo("pt-BR");
                decimal valorTotal = 0;
                foreach (DataGridViewRow col in dgvPedido.Rows)
                {
                    valorTotal = valorTotal + Convert.ToDecimal(col.Cells[4].Value);
                }

                //decimal valorall = Convert.ToDecimal(txtValorall.Text);
                txtValorfin2.Text = valorTotal.ToString();
                txtValorall.Text = valorTotal.ToString("C2", ci);
                txtTotalFin.Text = valorTotal.ToString("C2", ci);
                ItemPedidoTableAdapter taitem = new ItemPedidoTableAdapter();
                taitem.DeleteQuery(int.Parse(txtNumPedido.Text));

            
                txtCodigoB.Focus();
                txtQuantComp.Text = "";
                txtPreco.Text = "";
                txtDesc.Text = "";
                txtCodigoB.Text = "";
                txtQuantidadeEstoq.Text = "";
                txtVtotal.Text = "";

            }
            catch
            {
                MessageBox.Show("Favor selecionar uma linha para ser cancelada.");
            }
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            //string didndin = txtDinheiro.Text;
            
            //txtDinheiro2.Text = didndin;
            //decimal dinheiro = Convert.ToDecimal(didndin);
            //decimal valortotal = Convert.ToDecimal(txtValorfin2.Text);
            
            //decimal troco;
            //if (dinheiro >= valortotal)
            //{
            //    troco = dinheiro - valortotal;
            //    CultureInfo ci = new CultureInfo("pt-BR");
            //    txtTroco.Text =  troco.ToString("C2", ci);
                
            //}
            //else if (valortotal > dinheiro)
            //{

            //    decimal debito;
            //    debito = valortotal - dinheiro;
            //    txtdebito2.Text = debito.ToString();
            //    CultureInfo ci = new CultureInfo("pt-BR");
            //    txtDebito.Text = debito.ToString("C2", ci);

            //}
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            

            try
            {
                if(chkAberto.Checked || chkFechado.Checked && txtTotalFin.Text != "")
                {
                    if (txtDebito.Text == "")
                    {
                        if (chkComprovante.Checked)
                        {
                            PedidoTableAdapter taPedido = new PedidoTableAdapter();
                            taPedido.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, 0, Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));
                            MessageBox.Show("Venda Concluida com sucesso!");

                            PagamentoTableAdapter taPagamento = new PagamentoTableAdapter();
                            taPagamento.Insert(int.Parse(txtNumPedido.Text), txttipPag.Text);
                            frmNota nota = new frmNota();
                            nota.Cliente = txtCodCli.Text;
                            nota.Pedido = txtNumPedido.Text;
                            nota.Show();
                            this.Dispose();
                            
                        }
                        else
                        {
                            PedidoTableAdapter taPedido = new PedidoTableAdapter();
                            taPedido.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, 0, Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));
                            MessageBox.Show("Venda Concluida com sucesso!");

                            PagamentoTableAdapter taPagamento = new PagamentoTableAdapter();
                            taPagamento.Insert(int.Parse(txtNumPedido.Text), txttipPag.Text);
                            this.Dispose();

                        }

                    }
                    else
                    {
                        if (chkComprovante.Checked )
                        {
                            PedidoTableAdapter taPedido = new PedidoTableAdapter();
                            taPedido.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, Convert.ToDecimal(txtdebito2.Text), Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));
                            MessageBox.Show("Venda Concluida com sucesso!");
                            frmNota nota = new frmNota();
                            nota.Cliente = txtCodCli.Text;
                            nota.Pedido = txtNumPedido.Text;
                            nota.Show();
                            this.Dispose();
                            
                        }
                        else
                        {
                            PedidoTableAdapter taPedido = new PedidoTableAdapter();
                            taPedido.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, Convert.ToDecimal(txtdebito2.Text), Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));
                            MessageBox.Show("Venda Concluida com sucesso!");

                            this.Dispose();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Não deixei campos em branco");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                //dtCliente = taPedido.PesqCodCli(cbxClientes.Items.ToString());
                //if (dtCliente.Rows.Count == 0)
                //{
                //    MessageBox.Show("Pessosa Não Cadastrada");
                //}
                //else
                //{

                //    txtCodCli.Text = dtCliente.Rows[0]["Cod_Cliente"].ToString();
                //}
            }
            catch
            {
            }

        }

        private void cbxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
               
                //ClienteTableAdapter taPedido = new ClienteTableAdapter();
                //DataTable dtCliente;
                //txtTeste.Text = cbxClientes.Text; 
                //dtCliente = taPedido.PesqCod_Cli(txtTeste.Text);
                //txtCodCli.Text = dtCliente.Rows[0]["Cod_Cliente"].ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grbPag_Enter(object sender, EventArgs e)
        {

        }

        private void chkAberto_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAberto.Checked)
            {
                chkFechado.Enabled = false;

                txtPag.Text = "Em Aberto";
            }
            else
            {
                chkFechado.Enabled = true; 
            }

        }

        private void chkFechado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechado.Checked)
            {
                chkAberto.Enabled = false;
                txtPag.Text = "Pago";
            }
            else
            {
                chkAberto.Enabled = true;
            }
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtValorall_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNomeCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCodCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidadeEstoq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCodPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPag_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtValorfin2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinheiro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecounid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValorfin2.Text == "")
                {
                    this.Dispose();
                }
                else if (txtValorall.Text == "R$ 0,00"  || txtValorall.Text == "R$0,00")
                {
                    if (txtdebito2.Text == "")
                    {
                        PedidoTableAdapter taPed = new PedidoTableAdapter();
                        taPed.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, 0, Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));

                        //taPed.Delete(int.Parse(txtNumPedido.Text), int.Parse(txtCodCli.Text), dateTimePicker1.Value, decimal.Parse(txtValorfin2.Text), txttipPag.Text, 0);
                        //taPed.DeleteQuery(int.Parse(txtNumPedido.Text));
                        //this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        PedidoTableAdapter taPed = new PedidoTableAdapter();
                        taPed.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, Convert.ToDecimal(txtdebito2.Text), Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));

                        //taPed.Delete(int.Parse(txtNumPedido.Text), int.Parse(txtCodCli.Text), dateTimePicker1.Value, decimal.Parse(txtValorfin2.Text), txttipPag.Text, decimal.Parse(txtdebito2.Text));
                        //taPed.DeleteQuery(int.Parse(txtNumPedido.Text));
                        //this.Close();
                        this.Dispose();
                    }
                }
                else if (txtValorall.Text != "R$ 0,00"  || txtValorall.Text != "R$0,00")
                {
                    MessageBox.Show("Cancele todos os itens!");
                    
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pedidoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            chkFechado.Checked = false;
            chkAberto.Checked = false;
            string didndin = txtDinheiro.Text;
            txtDebito.Text = "";
            txtTroco.Text = "";
            txtDinheiro2.Text = didndin;
            decimal dinheiro = Convert.ToDecimal(didndin);
            decimal valortotal = Convert.ToDecimal(txtValorfin2.Text);

            decimal troco;
            if (dinheiro >= valortotal)
            {
                troco = dinheiro - valortotal;
                CultureInfo ci = new CultureInfo("pt-BR");
                txtTroco.Text = troco.ToString("C2", ci);
                chkFechado.Checked = true;
                chkAberto.Checked = false;
                groupBox2.Enabled = true;

            }
            else if (valortotal > dinheiro)
            {

                decimal debito;
                debito = valortotal - dinheiro;
                txtdebito2.Text = debito.ToString();
                CultureInfo ci = new CultureInfo("pt-BR");
                txtDebito.Text = debito.ToString("C2", ci);
                chkFechado.Checked = false;
                chkAberto.Checked = true;

            }
        }

        private void frmCaixa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true;

                //if (txtValorfin2.Text == "")
                //{
                //    e.Cancel = false;
                //}
                //else if (txtValorall.Text == "R$0,00")
                //{
                //    if (txtdebito2.Text == "")
                //    {
                //        PedidoTableAdapter taPed = new PedidoTableAdapter();
                //        taPed.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, 0, Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));

                //        //taPed.Delete(int.Parse(txtNumPedido.Text), int.Parse(txtCodCli.Text), dateTimePicker1.Value, decimal.Parse(txtValorfin2.Text), txttipPag.Text, 0);
                //        //taPed.DeleteQuery(int.Parse(txtNumPedido.Text));
                //        this.Dispose();
                //    }
                //    else
                //    {
                //        PedidoTableAdapter taPed = new PedidoTableAdapter();
                //        taPed.Update(Convert.ToInt32(txtCodCli.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, Convert.ToDecimal(txtdebito2.Text), Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));

                //        //taPed.Delete(int.Parse(txtNumPedido.Text), int.Parse(txtCodCli.Text), dateTimePicker1.Value, decimal.Parse(txtValorfin2.Text), txttipPag.Text, decimal.Parse(txtdebito2.Text));
                //        //taPed.DeleteQuery(int.Parse(txtNumPedido.Text));
                //        this.Close();
                //    }
                //}
                //else if (txtValorall.Text != "R$0,00")
                //{
                //    MessageBox.Show("Cancele todos os itens!");
                //    e.Cancel = true;
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodigoB_Enter(object sender, EventArgs e)
        {
            if (txtCodigoB.Text != "")
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();

                DataTable dtProduto;
                dtProduto = taProduto.PesquisaCodBarra(Convert.ToInt64(txtCodigoB.Text));

                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto não encontrado. Verifique se o mesmo foi cadastrado ou digitado corretamente.");
                }
                else
                {
                    txtCodPro.Text = dtProduto.Rows[0]["Cod_Produto"].ToString();
                    txtDesc.Text = dtProduto.Rows[0]["Descricao_Produto"].ToString();
                    txtQuantidadeEstoq.Text = dtProduto.Rows[0]["Quantidade_Produto"].ToString();
                    txtPrecounid.Text = dtProduto.Rows[0]["Preco_Produto"].ToString();
                    decimal preco = Convert.ToDecimal(txtPrecounid.Text);
                    CultureInfo ci = new CultureInfo("pt-BR");
                    txtPreco.Text = preco.ToString("C2", ci);
                    txtMarca.Text = dtProduto.Rows[0]["Marca_Produto"].ToString();
                }

            }
        }

        private void chkDesconto_CheckedChanged(object sender, EventArgs e)
        {
            //if(chkDesconto.Checked == true)
            //{
            //    nudDesconto.Enabled = true;
            //}
            //else
            //{
            //    nudDesconto.Enabled = false;
            //}
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            //if(chkDesconto.Checked == true)
            //{
            //    if(nudDesconto.Value == 0)
            //    {
            //        MessageBox.Show("Não foi selecionado nenhum desconto!");
            //    }
            //    else
            //    {
            //        int desconto;
            //        decimal valortotal;
            //        desconto = Convert.ToInt32(nudDesconto.Value);
            //        valortotal = Convert.ToDecimal(txtValorfin2.Text);
            //        desconto = desconto / 100;
            //        valortotal = valortotal * desconto;
            //        //txtValorfin2.Text = valortotal.ToString();
            //        CultureInfo ci = new CultureInfo("pt-BR");
            //        txtTotalFin.Text = valortotal.ToString("C2", ci);
                    
            //    }
            //}
            //else
            //{
            //    if(txtDesconto.Text == "")
            //    {
            //        MessageBox.Show("Não há nenhum desconto!");
            //    }
            //    else if (txtDesconto.Text == "0")
            //    {
            //        MessageBox.Show("Não há nenhum desconto!");
            //    }
            //    else
            //    {
            //        decimal desconto;
            //        decimal valortotal;
            //        desconto = Convert.ToDecimal(txtDesconto.Text);
            //        valortotal = Convert.ToDecimal(txtValorfin2.Text);
            //        valortotal = valortotal - desconto;
            //        CultureInfo ci = new CultureInfo("pt-BR");
            //        txtTotalFin.Text = valortotal.ToString("C2", ci);
            //    }
            //}
        }

        private void btnComprovante_Click(object sender, EventArgs e)
        {
            try
            {
                frmNota nota = new frmNota();
                nota.Cliente = txtCodCli.Text;
                nota.Pedido = txtNumPedido.Text;
                nota.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmPesquisa_Produto frmPesquisaPro = new frmPesquisa_Produto();
            frmPesquisaPro.ShowDialog();
            txtCodigoB.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCodigoB.Focus();
            
        }
    }
}
    

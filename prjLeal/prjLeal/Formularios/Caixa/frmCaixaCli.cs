using prjLeal.LealDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLeal.Formularios.Caixa
{
    public partial class frmCaixaCli : Form
    {
        public frmCaixaCli()
        {
            InitializeComponent();
        }
        public string Propriedade { get; set; }
        public string codcli { get; set; }
        private void frmCaixaCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.ItemPedido' table. You can move, or remove it, as needed.
            this.itemPedidoTableAdapter.Fill(this.lealDataSet.ItemPedido);
            // TODO: This line of code loads data into the 'lealDataSet.ItemPedido' table. You can move, or remove it, as needed.
            this.itemPedidoTableAdapter.Fill(this.lealDataSet.ItemPedido);
            if (!this.Propriedade.Equals(""))
            { txtNumPedido.Text = this.Propriedade; }
            if (!this.codcli.Equals(""))
            { txtCodClie.Text = this.codcli; }

            try
            {
                ItemPedidoTableAdapter taItemPedido = new ItemPedidoTableAdapter();
                DataTable dtlista;
                dtlista = taItemPedido.ConsultaPedido(Convert.ToInt32(txtNumPedido.Text));
                dataGridView1.DataSource = dtlista;
                ClienteTableAdapter taCli = new ClienteTableAdapter();

                dtlista = taCli.Pesquisa_Cliente(int.Parse(txtCodClie.Text));
                if (dtlista.Rows.Count == 0)
                {
                    MessageBox.Show("Pedido Não Encontrado!");
                    this.Close();
                }
                else
                {
                    txtNome.Text = dtlista.Rows[0]["Nome_Cliente"].ToString();
                    txtSobrenome.Text = dtlista.Rows[0]["Sobrenome_Cliente"].ToString();
                    txtNomeCli.Text = txtNome.Text + " " + txtSobrenome.Text;
                }
                PedidoTableAdapter taPedido = new PedidoTableAdapter();
                dtlista = taPedido.Pesquisa_Pedido(int.Parse(txtNumPedido.Text));
                if (dtlista.Rows.Count == 0)
                {
                    MessageBox.Show("Pedido Não Encontrado");
                    this.Close();
                }
                else
                {
                    
                    txtValorfin2.Text = dtlista.Rows[0]["SubTotal_Pedido"].ToString();
                    txtdebi.Text = dtlista.Rows[0]["Debito_Pedido"].ToString();
                }
                if(txtdebi.Text == "0")
                {
                    decimal valor = Convert.ToDecimal(txtValorfin2.Text);
                    CultureInfo ci = new CultureInfo("pt-BR");
                    txtValorall.Text = valor.ToString("C2", ci);
                    txtTotalFin.Text = valor.ToString("C2", ci);
                }
                else if (txtdebi.Text != "0")
                {
                    decimal valor = Convert.ToDecimal(txtValorfin2.Text);
                    decimal debi = Convert.ToDecimal(txtdebi.Text);
                    CultureInfo ci = new CultureInfo("pt-BR");
                    txtValorall.Text = valor.ToString("C2", ci);
                    txtTotalFin.Text = debi.ToString("C2", ci);
                }
                

            }
            catch
            {

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
            //    txtTroco.Text = troco.ToString("C2", ci);

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

        private void chkAberto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAberto.Checked)
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkAberto.Checked || chkFechado.Checked && txtTotalFin.Text != "")
                {
                    if (txtDebito.Text == "")
                    {
                        PedidoTableAdapter taPedido = new PedidoTableAdapter();
                        taPedido.Update(Convert.ToInt32(txtCodClie.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, 0, Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));
                        MessageBox.Show("Venda Concluida com sucesso!");
                        PagamentoTableAdapter taPagamento = new PagamentoTableAdapter();
                        taPagamento.Insert(int.Parse(txtNumPedido.Text), txttipPag.Text);
                        this.Close();
                    }
                    else
                    {
                       PedidoTableAdapter taPedido = new PedidoTableAdapter();
                        taPedido.Update(Convert.ToInt32(txtCodClie.Text), dateTimePicker1.Value, Convert.ToDecimal(txtValorfin2.Text), txtPag.Text, Convert.ToDecimal(txtdebito2.Text), Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtNumPedido.Text));
                        MessageBox.Show("Venda Concluida com sucesso!");
                        this.Close();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Não deixei campos em branco");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void txtNumPedido_TextChanged(object sender, EventArgs e)
        {
            itemPedidoBindingSource.Filter = "Convert(cod_pedido, 'System.String') like '%" + txtNumPedido.Text + "%'";
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
            decimal sla = Convert.ToDecimal(txtdebi.Text);

            decimal troco;
            if (dinheiro >= sla)
            {
                troco = dinheiro - sla;
                CultureInfo ci = new CultureInfo("pt-BR");
                txtTroco.Text = troco.ToString("C2", ci);
                chkFechado.Checked = true;
                chkAberto.Checked = false;
                groupBox2.Enabled = true;

            }
            else if (sla > dinheiro)
            {
                decimal debito;
                debito = sla - dinheiro;
                txtdebito2.Text = debito.ToString();
                CultureInfo ci = new CultureInfo("pt-BR");
                txtDebito.Text = debito.ToString("C2", ci);
                chkAberto.Checked = true;
                chkFechado.Checked = false;

            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            //if (chkDesconto.Checked == true)
            //{
            //    if (nudDesconto.Value == 0)
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
            //    if (txtDesconto.Text == "")
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

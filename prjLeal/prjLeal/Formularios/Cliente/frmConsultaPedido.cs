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
using System.Data.SqlClient;

namespace prjLeal.Formularios.Cliente
{
    public partial class frmConsultaPedido : Form
    {
        

        public frmConsultaPedido()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-U26BJ62\SQLEXPRESS;Initial Catalog=Leal;Integrated Security=True");
        
        public frmConsultaPedido(string valor)
        {
            InitializeComponent();
            txtCodPed.Text = valor;
        }
        public string Propriedade { get; set; }
        private void itemPedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemPedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lealDataSet);

        }

        private void frmConsultaPedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lealDataSet.Produto' table. You can move, or remove it, as needed.
            //this.produtoTableAdapter.Fill(this.lealDataSet.Produto);
            // TODO: This line of code loads data into the 'lealDataSet1.ItemPedido' table. You can move, or remove it, as needed.
            this.itemPedidoTableAdapter.Fill(this.lealDataSet1.ItemPedido);
            // TODO: This line of code loads data into the 'lealDataSet.ItemPedido' table. You can move, or remove it, as needed.
            this.itemPedidoTableAdapter.Fill(this.lealDataSet.ItemPedido);
            if (!this.Propriedade.Equals(""))
            { txtCodPed.Text = this.Propriedade; }
            try
            {
                //this.itemPedidoTableAdapter.FillBy2(this.lealDataSet.ItemPedido, Convert.ToInt32(txtCodPed.Text));
                ItemPedidoTableAdapter taItemPedido = new ItemPedidoTableAdapter();
                DataTable dtlista;
                dtlista = taItemPedido.ConsultaPedido(Convert.ToInt32(txtCodPed.Text));
                dataGridView1.DataSource = dtlista;



            }
            catch
            {

            }
        }

            

        private void itemPedidoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodPed_Validating(object sender, CancelEventArgs e)
        {
            
            
        }

        private void txtCodPed_Leave(object sender, EventArgs e)
        {
            
        }

        private void consultaPedidoToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void consultaPedidoToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultaPedidoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.itemPedidoTableAdapter.ConsultaPedido(this.lealDataSet.ItemPedido);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtCodPed_TextChanged(object sender, EventArgs e)
        {

            itemPedidoBindingSource.Filter = "Convert(cod_pedido, 'System.String') like '%" + txtCodPed.Text + "%'";
        }

        private void consultaPedidoToolStripButton_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.itemPedidoTableAdapter.FillBy2(this.lealDataSet.ItemPedido, ((int)(System.Convert.ChangeType(cod_PedidoToolStripTextBox.Text, typeof(int)))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}

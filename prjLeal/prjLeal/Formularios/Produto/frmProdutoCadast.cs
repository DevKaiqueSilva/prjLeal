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
    public partial class frmProdutoCadast : Form
    {
        public frmProdutoCadast()
        {
            InitializeComponent();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProdutoTableAdapter taPessoa = new ProdutoTableAdapter();
            taPessoa.Insert(Convert.ToInt64(txtCodBarras.Text), txtDesc.Text, txtMarca.Text, txtEmbalagem.Text, txtTipo.Text, int.Parse(txtQuantid.Text), decimal.Parse(txtPreco.Text),txtFoto.Text);
            MessageBox.Show("Produto Cadastrado com sucesso!");
            Limpar_Caixa();
            txtCod.Text = taPessoa.UltimoCOD().ToString();
            this.Close();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar_Caixa();
            txtCodBarras.Text = "";
            txtDesc.Text = "";
            txtEmbalagem.Text = "";
            txtFoto.Text = "";
            txtMarca.Text = "";
            txtPreco.Text = "";
            txtQuantid.Text = "";
            txtTipo.Text = "";
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double valor;
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            try
            {
            valor = Double.Parse(txtPreco.Text);
            txtPreco.Text = valor.ToString("C" );
            }
            catch(Exception)
            {

            }
            
        }

        private void frmProdutoCadast_Load(object sender, EventArgs e)
        {
            ProdutoTableAdapter taCliente = new ProdutoTableAdapter();

            string ultimopedido = taCliente.UltimoCod1().ToString();
            txtCod.Text = ultimopedido;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjLeal.Formularios.Caixa;
using prjLeal.Formularios.Ferramentas;
using prjLeal.Formularios.Produto;

namespace prjLeal
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }
        public string Propriedades { get; set; }
        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa1 objCx = new frmCaixa1();
            objCx.MdiParent = this;
            objCx.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente objInicioBotoes = new frmCliente();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteCadast objInicioBotoes = new frmClienteCadast();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduto objInicioBotoes = new frmProduto();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutoCadast objInicioBotoes = new frmProdutoCadast();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser objInicioBotoes = new frmNewUser();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup objInicioBotoes = new frmBackup();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestore objRestore = new frmRestore();
            objRestore.MdiParent = this;
            objRestore.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre objSobre = new frmSobre();
            objSobre.MdiParent = this;
            objSobre.Show();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorial objTutorial = new frmTutorial();
            objTutorial.MdiParent = this;
            objTutorial.Show();
        }

        private void frmInicial_Leave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staHoras.Text = DateTime.Now.ToString();
        }

        private void frmInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?","Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
            toolStripStatusLabel1.Text = this.Propriedades;

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelClient relcli = new frmRelClient();
            relcli.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio objInicioBotoes = new frmRelatorio();
            objInicioBotoes.MdiParent = this;
            objInicioBotoes.Show();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelProd relprod = new frmRelProd();
            relprod.Show();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserirProd frminserirprod = new frmInserirProd();
            frminserirprod.Show();
        }

        private void atualizarPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAumentPreco frmaumenta = new frmAumentPreco();
            frmaumenta.Show();
        }
    }
}

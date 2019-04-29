using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjLeal.LealDataSetTableAdapters;

namespace prjLeal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioTableAdapter user = new UsuarioTableAdapter();
            DataTable dtUser;
            dtUser = user.VerificarUser(txtUser.Text);
            dtUser = user.VerificaSenha(txtSenha.Text);

            if (dtUser.Rows.Count == 0)
            {
                MessageBox.Show("Login e senha incorretos!");
            }
            else
            {
                MessageBox.Show("Login Efetuado! Seja Bem Vindo!");
                frmInicial chama = new frmInicial();
                chama.Show();
                frmCaixa chamauser = new frmCaixa();
                chamauser.Propriedade = txtUser.Text;
                chamauser.Show();

                
                


            }
            
            

           
        }
    }
    
}

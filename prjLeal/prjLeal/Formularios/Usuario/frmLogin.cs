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
        private bool CaixasOk()
        {
            if (txtUser.Text == "")
            {
                errorProvider1.SetError(txtUser, "Informar o usuário");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtUser, "");
            }
            if (txtSenha.Text == "")
            {
                errorProvider1.SetError(txtSenha, "Favor informar a Senha");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtSenha, "");
                return true;
            }
        }
             private void btnLogin_Click(object sender, EventArgs e)
            {
            UsuarioTableAdapter user = new UsuarioTableAdapter();
            DataTable dtUser;
            DataTable dtUser1;
            if (txtUser.Text != "" && txtSenha.Text != "")
            {
                dtUser = user.VerificarUser(txtUser.Text.ToLower());
                dtUser1 = user.VerificaSenha(txtSenha.Text.ToLower());
                if (dtUser.Rows.Count == 0 || dtUser1.Rows.Count == 0)
                {
                    MessageBox.Show("Login ou/e senha incorretos!");
                }
                else
                {
                    MessageBox.Show("Login Efetuado! Seja Bem Vindo!");
                    frmInicial chama = new frmInicial();
                    chama.Propriedades = txtUser.Text;
                    chama.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Insira um login e/ou uma senha!!");
            }



            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

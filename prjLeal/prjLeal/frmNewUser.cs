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
using System;

namespace prjLeal
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtRepitaSenha.Text)
            {
                UsuarioTableAdapter taPessoa = new UsuarioTableAdapter();
                taPessoa.Insert(txtUsuario.Text,txtEmail.Text ,txtSenha.Text);
                MessageBox.Show("Usuário Cadastrado com sucesso!");
                Limpar_Caixa();
            }
            else
            {
                MessageBox.Show("Senhas diferentes! /n Tente Novamente!");
                
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (TextBox ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
            }
        }
    }
}

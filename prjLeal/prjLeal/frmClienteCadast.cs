﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjLeal.LealDataSetTableAdapters;

namespace prjLeal
{
    public partial class frmClienteCadast : Form
    {
        public frmClienteCadast()
        {
            InitializeComponent();
        }



        private void frmClienteCadast_Load(object sender, EventArgs e)
        {




        }

        private void endereco_ClienteLabel_Click(object sender, EventArgs e)
        {

        }

        
                
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            ClienteTableAdapter taPessoa = new ClienteTableAdapter();
            taPessoa.Insert(txtNome.Text, txtSobrenome.Text,dtpDataNasc.Value, cbxSex.Text, txtEnd.Text, int.Parse(txtNumer.Text), txtBairro.Text, txtCidade.Text, cbxUF.Text, txtTel.Text, txtCel.Text,txtFoto.Text);
            MessageBox.Show("Cliente Cadastrada com sucesso!");
            Limpar_Caixa();
            txtCod.Text = taPessoa.UltimoCOD().ToString();
        }

        

        private void Limpar_Caixa()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                    txtTel.Clear();
                    txtCel.Clear();
                }
            }
        }

        

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFoto.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Load();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach(TextBox ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
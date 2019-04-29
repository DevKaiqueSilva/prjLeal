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
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace prjLeal
{
    public partial class frmBackup : Form
    {
        //SqlConnection con = new SqlConnection(prjLeal.Properties.Settings.Default.LealConnectionString);
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    txtDiretorio.Text = fbd.SelectedPath;
            //    btnBackup.Enabled = true;

            //}
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
           
                //string sqlConnectionString = @"Data Source=DESKTOP-U26BJ62\SQLEXPRESS; AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Leal.mdf;Database=Leal; Trusted_Connection=Yes;";
                //string aa = @"Data Source=DESKTOP-U26BJ62\SQLEXPRESS; Integrated Security=True; Initial Catalog=Leal";
                string aa = @"Data Source=LOJALEAL-PC\SQLEXPRESS; Integrated Security=True; Initial Catalog=Leal";


            SqlConnection conn = new SqlConnection(aa);
                //Server server = new Server(new ServerConnection(conn));
                conn.Open();
                string str = "USE Leal;";

                DateTime d = DateTime.Now;
                string dd = d.Day + "-" + d.Month;
                //string diretorio = txtDiretorio.Text + "\\";
                string str1 = "BACKUP DATABASE Leal TO DISK = 'C:\\database\\Leal_" + dd + ".Bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of Leal';";
                SqlCommand cmd1 = new SqlCommand(str, conn);
                SqlCommand cmd2 = new SqlCommand(str1, conn);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();


                //string dia = DateTime.Now.Day.ToString();
                //string mes = DateTime.Now.Month.ToString();
                //string ano = DateTime.Now.Year.ToString();
                //string backup = @"BACKUP DATABASE Leal TO DISK = '" + diretorio + "" + dia + "_" + mes + "_" + ano + "_BACKUP.Bak'";
                //server.ConnectionContext.ExecuteNonQuery(backup);

                MessageBox.Show("Backup Realizado com sucesso.");
                conn.Close();

                //string database = con.Database.ToString();
                //string dia = DateTime.Now.Day.ToString();
                //string mes = DateTime.Now.Month.ToString();
                //string ano = DateTime.Now.Year.ToString();
                //string backup = "BACKUP DATABASE [ "+ database + " ]TO DISK = '" + txtDiretorio.Text + "\\"+"Database"+"-" + dia + "_" + mes + "_" + ano + "_BACKUP.bak'";
                //using (SqlCommand command = new SqlCommand(backup, con))
                //{
                //    if(con.State != ConnectionState.Open)
                //    {
                //        con.Open();
                //    }
                //    command.ExecuteNonQuery();
                //    con.Close();
                //    MessageBox.Show("Backup realizado com sucesso.");
                //    btnBackup.Enabled = false;
                //}


            
            
        }
    }
}

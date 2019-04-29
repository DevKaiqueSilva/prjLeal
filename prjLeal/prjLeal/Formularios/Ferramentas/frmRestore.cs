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

namespace prjLeal
{
    public partial class frmRestore : Form
    {
        SqlConnection con = new SqlConnection(prjLeal.Properties.Settings.Default.LealConnectionString);
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup  files|*.bak*";
            dlg.Title = "Database restore";
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                txtdiretori.Text = dlg.FileName;
                btnRestore.Enabled = true;

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE ["+database+"] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + txtdiretori.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Banco de Dados restaurado com sucesso!");
                con.Close();
                btnRestore.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}

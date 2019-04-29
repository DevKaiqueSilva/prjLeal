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
    public partial class frmTutorial : Form
    {
        public frmTutorial()
        {
            InitializeComponent();
        }

        private void frmTutorial_Load(object sender, EventArgs e)
        {
            //string caminho = "C:/Users/T-Gamer/Desktop/ETEC/TCC/prj2/imagens/MANUALDOUSUARIO.pdf";
            //string caminho = "J:/TCC/prj2/prjLeal/prjLeal/MANUALDOUSUARIO.pdf";
            string caminho = "C:/Users/Lucas_Baccas/Desktop/TCC/prj2/imagens/MANUALDOUSUARIO.pdf";
            axAcroPDF1.src = caminho;
            
        }
    }
}

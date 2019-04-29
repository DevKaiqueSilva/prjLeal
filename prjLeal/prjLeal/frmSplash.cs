using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace prjLeal
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            EfectTime();//Chama o procedimento que irá ativar o temporizador(Timer)
        }
        private bool Efect = true;//variavel logica
        

        private void SplashTimer_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            //if (progressBar1.Value == 100) SplashTimer.Stop();
            if (Efect)
            {
                //this.Opacity -= 0.01D;//E diminui a opacidade do frm
                //                      //Equivale a This.Opacity = this.Opacity -0.01
            }
            if (progressBar1.Value == 100)
            {
                Efect = false;
                SplashTimer.Stop();
                SplashTimer.Enabled = false;//desliga o timer
                frmLogin frmLogin = new frmLogin(); //instancia um form Login
                frmLogin.Show();//mostra o login
                this.Hide();//Oculta sem tirar da memoria o formulario Splash
            }
        }
        private void EfectTime()
        {
            SplashTimer.Interval = 100; //define 190 milesegundos para a atuação do time
            SplashTimer.Tick += new EventHandler(SplashTimer_Tick_1);//Dispara o evento Tick
            SplashTimer.Enabled = true;//Ativa o timer

        }
    }
    }


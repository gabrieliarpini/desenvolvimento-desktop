using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApp.Windows
{
    public partial class SplashSreen : Form
    {
        public SplashSreen()
        {
            InitializeComponent();

          
        }

        private void SplashSreen_Shown(object sender, EventArgs e)
        {

            this.Refresh();
            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(10);
            }
            progressBar1.Value = 99;
            Thread.Sleep(200);
            this.Close();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

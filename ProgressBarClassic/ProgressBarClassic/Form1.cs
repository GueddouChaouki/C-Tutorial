using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarClassic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void timer1_Tick( object sender , EventArgs e )
        {

            if (progressBar1.Value <= progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            if (progressBar2.Value <= 100)
            {
                progressBar2.Value += 1;
            }
            if (progressBar3.Value <= 100)
            {
                progressBar3.Value += 1;
            }
        }
    }
}

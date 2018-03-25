using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace ProgressBar
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }

        private void timer1_Tick( object sender , EventArgs e )
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 1;
            }
            if (progressBar3.Value < 100)
            {
                progressBar3.Value += 1;
            }
            if (progressBarX1.Value < 100)
            {
                progressBarX1.Value += 1;
            }
            if (progressBarX2.Value < 100)
            {
                progressBarX2.Value += 1;
            }
            if (progressBarX3.Value < 100)
            {
                progressBarX3.Value += 1;
            }
            if (progressBarX4.Value < 100)
            {
                progressBarX4.Value += 1;
            }
            if (progressBarX5.Value < 100)
            {
                progressBarX5.Value += 1;
            }
            if (progressBarX6.Value < 100)
            {
                progressBarX6.Value += 1;
            }
            if (progressBarX7.Value < 100)
            {
                progressBarX7.Value += 1;
            }
            if (progressBarX10.Value < 100)
            {
                progressBarX10.Value += 1;
            }

            if (circularProgress1.Value < 100)
            {
                circularProgress1.Value += 1;
            }
            if (circularProgress2.Value < 100)
            {
                circularProgress2.Value += 1;
            }
        }
    }
}

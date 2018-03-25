using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace TrackBar
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

        private void trackBar1_Scroll( object sender , EventArgs e )
        {
            pictureBox1.Size = new Size ( trackBar1.Value , trackBar2.Value );
        }

        private void trackBar2_Scroll( object sender , EventArgs e )
        {
            pictureBox1.Size = new Size ( trackBar1.Value , trackBar2.Value );
        }
    }
}

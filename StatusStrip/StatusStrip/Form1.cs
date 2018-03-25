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

namespace StatusStrip
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
            labelItem1.Text = "Today Time is :" + DateTime.Today + " | Computer Name is :" + Environment.MachineName;
            toolStripStatusLabel1.Text = "Today Time is :" + DateTime.Today + " | Computer Name is :" + Environment.MachineName;

        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }
    }
}

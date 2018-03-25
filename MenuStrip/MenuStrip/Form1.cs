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

namespace MenuStrip
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

        private void ouvrirToolStripMenuItem_Click( object sender , EventArgs e )
        {

        }

        private void exitToolStripMenuItem_Click( object sender , EventArgs e )
        {
            this.Close();
        }
    }
}

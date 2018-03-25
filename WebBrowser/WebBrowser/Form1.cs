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

namespace WebBrowser
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX3_Click( object sender , EventArgs e )
        {
            webBrowser1.Navigate ( textBoxX1.Text );
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            webBrowser1.GoForward ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            webBrowser1.GoBack ();
        }
    }
}

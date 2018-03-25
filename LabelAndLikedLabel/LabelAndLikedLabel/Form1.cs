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
using System.Diagnostics;
namespace LabelAndLikedLabel
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

        private void linkLabel1_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            Process.Start ( "http://www.google.com" );
            Process.Start ( "D:/totu/" );

        }
    }
}

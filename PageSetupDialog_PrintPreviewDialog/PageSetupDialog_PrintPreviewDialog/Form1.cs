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


namespace PageSetupDialog_PrintPreviewDialog
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void printDocument1_PrintPage( object sender , System.Drawing.Printing.PrintPageEventArgs e )
        {
            e.Graphics.DrawString (richTextBoxEx1.Text,new Font("Tahoma",18),Brushes.Green,10,10);
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            pageSetupDialog1.ShowDialog ();
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            printPreviewDialog1.ShowDialog ();
        }

        private void buttonX3_Click( object sender , EventArgs e )
        {
            printDialog1.ShowDialog ();
        }

        private void printPreviewControl1_Click( object sender , EventArgs e )
        {
            printPreviewControl1.Show ();
        }
    }
}

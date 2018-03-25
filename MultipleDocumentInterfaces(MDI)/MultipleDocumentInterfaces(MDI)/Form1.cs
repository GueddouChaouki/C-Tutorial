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

namespace MultipleDocumentInterfaces_MDI_
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void gOToForm2ToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Form2 frm2 = new Form2 ();
            frm2.MdiParent = this;
            frm2.Show ();

        }

        private void gOToForm3ToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Form3 frm3 = new Form3 ();
            frm3.MdiParent = this;
            frm3.Show ();
        }
    }
}

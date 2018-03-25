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
using System.IO;
using DevComponents.DotNetBar.Metro;

namespace SaveFileDialog
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void saveTextFileToolStripMenuItem_Click( object sender , EventArgs e )
        {
            saveFileDialog1.Filter = "File type | *.TXT";
            saveFileDialog1.InitialDirectory = "c:\\";

            if (saveFileDialog1.ShowDialog () == DialogResult.OK)
            {
                File.WriteAllText ( saveFileDialog1.FileName , richTextBoxEx1.Text );
                MessageBoxEx.Show ( "saved sucssefuly <3" );
            }
        }
    }
}

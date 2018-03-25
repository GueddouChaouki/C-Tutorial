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

using System.IO;
namespace StreamWriterTest
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            FileStream fs = new FileStream ( "D:\\chaouki.txt" , FileMode.OpenOrCreate );
            StreamWriter sw = new StreamWriter ( fs );
            sw.Write ( richTextBoxEx1.Text );
            sw.Close ();
            MessageBoxEx.Show (" your text has been saved successsfully ");
        }
    }
}

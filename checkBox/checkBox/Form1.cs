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

namespace checkBox
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

        private void buttonX1_Click( object sender , EventArgs e )
        {
            string s = "your favoured language is ";
            if (checkBoxCSharp.Checked.Equals ( true ))
            {
                s += "\n _ Csharp ";
            }
            if (checkBoxJava.Checked.Equals ( true ))
            {
                s += "\n _ Java ";
            }
            if (checkBoxHTML.Checked.Equals ( true ))
            {
                s += "\n _ HTML ";
            }
            if (checkBoxCPlusPlus.Checked.Equals ( true ))
            {
                s += "\n _ C++ ";
            }
            if (checkBoxPaython.Checked.Equals ( true ))
            {
                s += "\n _ Paython ";
            }

            if (checkBoxCSharp.Checked.Equals ( false )&&checkBoxJava.Checked.Equals ( false )&&checkBoxHTML.Checked.Equals ( false )&&checkBoxPaython.Checked.Equals ( false )&& checkBoxCPlusPlus.Checked.Equals ( false ))
            {
                s += " NAN ";
            }

            MessageBoxEx.Show ( s,"answer",MessageBoxButtons.OK,MessageBoxIcon.Information );

        }

        private void checkedListBox1_SelectedIndexChanged( object sender , EventArgs e )
        {

        }
    }
}

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

namespace RadioButton
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

        private void radioButton3_CheckedChanged( object sender , EventArgs e )
        {
            double d = Convert.ToDouble ( textBoxX1.Text ) / Convert.ToDouble ( textBoxX2.Text );
            labelResultat.Text = Convert.ToString ( d );

        }

        private void radioButton1_CheckedChanged( object sender , EventArgs e )
        {
            double d = Convert.ToDouble ( textBoxX1.Text ) + Convert.ToDouble ( textBoxX2.Text );
            labelResultat.Text = Convert.ToString ( d );

        }

        private void radioButtonMult_CheckedChanged( object sender , EventArgs e )
        {
            double d = Convert.ToDouble ( textBoxX1.Text ) * Convert.ToDouble ( textBoxX2.Text );
            labelResultat.Text = Convert.ToString ( d );

        }

        private void radioButtonMinus_CheckedChanged( object sender , EventArgs e )
        {
            double d = Convert.ToDouble ( textBoxX1.Text ) - Convert.ToDouble ( textBoxX2.Text );
            labelResultat.Text = Convert.ToString ( d );

        }

        private void radialMenu1_ItemClick( object sender , EventArgs e )
        {
            if (add.Checked.Equals(true))
            {
                labelResultat.Text = "wawa";
            }
            
        }
    }
}

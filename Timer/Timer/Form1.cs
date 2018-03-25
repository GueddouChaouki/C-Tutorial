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


namespace Timer
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

        private void timer1_Tick( object sender , EventArgs e )
        {
            reflectionLabel1.Text = DateTime.Now.ToLongTimeString ();
            ButtonX btn = new ButtonX ();
            btn.BackColor = buttonX1.BackColor;
            buttonX1.BackColor = buttonX2.BackColor;
            buttonX2.BackColor = btn.BackColor;

        }
    }
}

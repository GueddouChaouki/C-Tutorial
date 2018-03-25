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


namespace ToolStrip
{
    public partial class Form1 : MetroForm
    {
        public int size = 12;
        public Form1()
        {
            InitializeComponent ();
        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }

        

        private void toolStripTextBox1_TextChanged( object sender , EventArgs e )
        {
            this.labelX1.Text = toolStripTextBox1.Text;
        }

        private void toolStripButton1_Click( object sender , EventArgs e )
        {
           

                this.labelX1.Font = new Font ( "tahoma" , size );
                size += 1;
            
        }

        private void toolStripButton2_Click( object sender , EventArgs e )
        {
            if (size <= 0)
            {
                size = 12;
            }
            else
            {
                this.labelX1.Font = new Font ( "tahoma" , size );
                size -= 1;
            }
            
        }
    }
}

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

namespace ScrollBar
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

        private void hScrollBarAdv1_Scroll( object sender , ScrollEventArgs e )
        {
            this.BackColor = Color.FromArgb ( hScrollBarAdv1.Value,hScrollBarAdv2.Value,hScrollBarAdv3.Value);
        }

        private void hScrollBarAdv2_Scroll( object sender , ScrollEventArgs e )
        {
            this.BackColor = Color.FromArgb ( hScrollBarAdv1.Value , hScrollBarAdv2.Value , hScrollBarAdv3.Value );
        }

        private void hScrollBarAdv3_Scroll( object sender , ScrollEventArgs e )
        {
            this.BackColor = Color.FromArgb ( hScrollBarAdv1.Value , hScrollBarAdv2.Value , hScrollBarAdv3.Value );
        }
    }
}

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


namespace NotifyIcon
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
            this.notifyIcon1.Icon = this.Icon;
            //this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            //this.notifyIcon1.BalloonTipText = "please update ";
            //this.notifyIcon1.BalloonTipTitle = "update Error ";
            //this.notifyIcon1.ShowBalloonTip ( 12 );
            this.notifyIcon1.ShowBalloonTip ( 12 , "warning title" , "warrning message" , ToolTipIcon.Warning );
           // this.notifyIcon1.ShowBalloonTip ( 12 , "info title" , "info message" , ToolTipIcon.Info );



        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }

        private void aboutToolStripMenuItem_Click( object sender , EventArgs e )
        {
            MessageBoxEx.Show ( "ce n'est qu'un test de context menu " , "test" , MessageBoxButtons.OK , MessageBoxIcon.Information );
        }

        private void exitToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Close ();
        }
    }
}

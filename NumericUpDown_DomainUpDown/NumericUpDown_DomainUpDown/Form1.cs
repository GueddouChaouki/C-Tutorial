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

namespace NumericUpDown_DomainUpDown
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
            domainUpDown1.Items.Add ( "janvier" );
            domainUpDown1.Items.Add ( "fevrier" );
            domainUpDown1.Items.Add ( "mars" );
            domainUpDown1.Items.Add ( "avril" );
            domainUpDown1.Items.Add ( "mai" );
            domainUpDown1.Items.Add ( "juin" );
            domainUpDown1.Items.Add ( "juillet" );
            domainUpDown1.Items.Add ( "aout" );
            domainUpDown1.Items.Add ( "september" );
            domainUpDown1.Items.Add ( "october" );
            domainUpDown1.Items.Add ( "november" );
            domainUpDown1.Items.Add ( "december" );
            domainUpDown1.SelectedIndex = 0;
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            MessageBoxEx.Show ( "la valeur atteint est : " +numericUpDown1.Value);
        }
    }
}

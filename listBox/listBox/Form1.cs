using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;


namespace listBox
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

        private void addButton_Click( object sender , EventArgs e )
        {
            listBoxAdv1.Items.Add (textBoxX.Text);
        }

        private void removeButton_Click( object sender , EventArgs e )
        {
            listBoxAdv1.Items.Remove (listBoxAdv1.SelectedItem);
        }

        private void removeAllButton_Click( object sender , EventArgs e )
        {
            listBoxAdv1.Items.Clear ();
        }
    }
}

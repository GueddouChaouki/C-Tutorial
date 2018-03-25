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

namespace ComboBoxes
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            string[] names = new string[5];
            names[0] = "aymen";
            names[1] = "youssef";
            names[2] = "nihad";
            names[3] = "ahmed";
            names[4] = "amine";

            InitializeComponent ();
            comboBoxEx1.Items.AddRange ( names );
        //    comboBoxEx1.Items.Add ( "algeria" );
        //    comboBoxEx1.Items.Add ( "morrocco" );
        //    comboBoxEx1.Items.Add ( "tunisia" );
        //    comboBoxEx1.Items.Add ( "france" );
        //    comboBoxEx1.Items.Add ( "switzeland" );
        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }

        private void comboBoxEx1_SelectedIndexChanged( object sender , EventArgs e )
        {
            MessageBoxEx.Show ( comboBoxEx1.Text );
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            comboBoxEx1.Items.Remove ( comboBoxEx1.SelectedItem );
        }
    }
}

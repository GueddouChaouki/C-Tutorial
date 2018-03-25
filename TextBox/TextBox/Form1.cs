
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


namespace TextBox
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s = "";
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("hello Mr: " +text.Text);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            text.Text = "le text a été changé";
        }
    }
}

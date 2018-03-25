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


namespace buttons
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroToolbar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_MouseHover(object sender, EventArgs e)
        {
            buttonX1.Text = "Hello C#";
            buttonX1.BackColor = Color.Red;

        }

        private void buttonX1_MouseLeave(object sender, EventArgs e)
        {
            buttonX1.Text = "MyButton";
            buttonX1.BackColor = Color.Green;
        }

      

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }
        
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Times New Roman",14,FontStyle.Bold);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

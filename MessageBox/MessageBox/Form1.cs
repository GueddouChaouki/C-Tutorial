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


namespace MessageBox
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBoxEx.Show("me taking no for an answer ","salutation",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if(result.Equals(DialogResult.OK))
            {
                MessageBoxEx.Show("you have clicked on OK Button ", "salutation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                MessageBoxEx.Show("you have clicked on CANCEL Button ", "salutation", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBoxEx.Show("voullez-vous sortir ", "salutation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }


        private void EXIT_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBoxEx.Show("voullez-vous sortir ", "saluktation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result2.Equals(DialogResult.Yes))
            {
                Close();
                
                
            }
        }
    }
}

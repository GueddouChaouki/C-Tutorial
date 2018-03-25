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


namespace RichTextBox_ColorDialog_FontDialog
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

        private void buttonX1_Click( object sender , EventArgs e )
        {
            if (colorDialog1.ShowDialog () == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                richTextBoxEx1.SelectionColor = colorDialog1.Color;
            }
        }

        private void colorPickerButton1_SelectedColorChanged( object sender , EventArgs e )
        {
               this.BackColor = colorPickerButton1.SelectedColor;
               richTextBoxEx1.SelectionColor = colorPickerButton1.SelectedColor;

        }

        private void customColorBlender1_SelectedColorChanged( object sender , EventArgs e )
        {
            this.BackColor = customColorBlender1.SelectedColor;
            richTextBoxEx1.SelectionColor = customColorBlender1.SelectedColor;
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            if (fontDialog1.ShowDialog () == DialogResult.OK)
            {
                 richTextBoxEx1.SelectionFont = fontDialog1.Font;
            }
        }
    }
}

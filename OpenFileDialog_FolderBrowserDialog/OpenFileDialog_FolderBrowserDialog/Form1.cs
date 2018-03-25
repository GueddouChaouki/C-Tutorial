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

namespace OpenFileDialog_FolderBrowserDialog
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            openFileDialog1.Filter = "images | *.JPEG; *.GIF; *.PNG; *.JPG";
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog () == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile ( openFileDialog1.FileName );
                this.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBoxEx.Show ( openFileDialog1.FileName );
                
            }
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
           
            if (folderBrowserDialog1.ShowDialog () == DialogResult.OK)
            {
                
                MessageBoxEx.Show (folderBrowserDialog1.SelectedPath);

            }
        }
    }
}

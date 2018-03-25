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
using System.IO;

namespace File_FileInfo
{
    public partial class Form1 : MetroForm
    {
        FileInfo f = new FileInfo ( "d:\\multimedia\\mariage bilal.jpg" );
        FileInfo f2 = new FileInfo ( "d:\\mariage.jpg" );
        public Form1()
        {
            InitializeComponent ();

        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            //on peut le deplacer et le renommer en meme temps
            File.Move ( "d:\\multimedia\\mariage bilal.jpg" , "d:\\mariage bilal.jpg" );

        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            File.Move ( "d:\\mariage bilal.jpg" , "d:\\mariage.jpg" );
        }

        private void buttonX3_Click( object sender , EventArgs e )
        {
            if (File.Exists( "d:\\my file.txt" ) )
            {
                richTextBoxEx1.Lines = File.ReadAllLines ( "d:\\my file.txt" );
                //ou
                richTextBoxEx1.Text = File.ReadAllText ( "d:\\my file.txt" );

            }
        }

        private void buttonX4_Click( object sender , EventArgs e )
        {
            File.WriteAllText ( "d:\\my file.txt" , richTextBoxEx1.Text );
            //ou
            File.WriteAllLines ( "d:\\my file.txt" , richTextBoxEx1.Lines );

        }

        private void buttonX5_Click( object sender , EventArgs e )
        {
            //on peut le deplacer et le renommer en meme temps
            f.MoveTo ( "d:\\mariage bilal.jpg" );
        }

        private void buttonX7_Click( object sender , EventArgs e )
        {
            f.MoveTo ( "d:\\mariage.jpg" );
        }

        private void buttonX8_Click( object sender , EventArgs e )
        {
             f2.CopyTo ( "d:\\mariage2.jpg" , false );
        }

        private void buttonX6_Click( object sender , EventArgs e )
        {
            f2.Delete ();
        }
    }
}

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

namespace BinaryReader_BinaryWriter
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            FileStream fs1 = new FileStream ( @"D:\Disable Uefi and Secure boot windows8.mp4" , FileMode.Open );
            FileStream fs2 = new FileStream ( @"D:\COPY.mp4" , FileMode.Create );

            BinaryReader br_fs1 = new BinaryReader ( fs1 );
            BinaryWriter bw_fs2 = new BinaryWriter ( fs2 );
             
            //une solution qui ne marche pas !!!!
            for (int i = 0 ; i <= bw_fs2.BaseStream.Length-1 ; i++)
            {
                bw_fs2.Write ( br_fs1.ReadByte () );
            }

            br_fs1.Close ();
            bw_fs2.Close ();
            //fs1.Close ();
            //fs2.Close ();

        }
    }
}

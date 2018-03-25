using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;



namespace Directory_DirectoryInfo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
            
            //Directory
            foreach (string fichier in Directory.GetFiles ( "D:\\gueddou united" ))
            {
                listBoxAdv1.Items.Add ( fichier );
            }

            //DirectoryInfo
            DirectoryInfo d = new DirectoryInfo ( "D:\\gueddou united" );
            foreach (FileInfo fichier in d.GetFiles ())
            {
                listBoxAdv2.Items.Add ( d+"\\"+fichier.Name );
            }
        }
    }
}

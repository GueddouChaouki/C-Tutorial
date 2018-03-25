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

namespace DriveInfo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            System.IO.DriveInfo d = new System.IO.DriveInfo ( "C:" );
            double totalSpace = d.TotalSize;
            double freeSpace = d.AvailableFreeSpace;
            double usedSpace = d.TotalSize-d.AvailableFreeSpace;



            usedSpaceProgressBar.Value = Convert.ToInt32((usedSpace * 100) / totalSpace);
            freeSpaceprogressBar.Value = Convert.ToInt32 ( (freeSpace * 100) / totalSpace );
            totalSpaceprogressBar.Value = Convert.ToInt32 ( (totalSpace * 100) / totalSpace );
            MessageBoxEx.Show ( "Les informations de disque C sont:\n "+d.IsReady + "\n" +
                d.Name + "\n" +d.RootDirectory + "\n" +d.TotalFreeSpace + "\n" +d.TotalSize + "\n" +
                d.VolumeLabel + "\n" +d.AvailableFreeSpace + "\n" +d.DriveFormat + "\n" +d.DriveType);
           
        }
    }
}

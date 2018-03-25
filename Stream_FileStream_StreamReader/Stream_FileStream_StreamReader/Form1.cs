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

namespace Stream_FileStream_StreamReader
{
    public partial class Form1 : MetroForm
    {
        //Stream:FileStream
        //Stream:NetworkStream
        //Stream:MemoryStream

        public Form1()
        {
            InitializeComponent ();
            FileStream fs = new FileStream ( "D:\\chaouki.txt" , FileMode.OpenOrCreate );
            StreamReader sr = new StreamReader ( fs/*OU "D:\\chaouki.txt"*/ );
            richTextBoxEx1.Text = sr.ReadToEnd ();
        }
    }
}

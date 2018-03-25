using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barre_code_and_Qr_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void BarreCodeBtn_Click( object sender , EventArgs e )
        {
            Zen.Barcode.Code128BarcodeDraw barrecode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barrecode.Draw ( BarreCodetextBox.Text , 50 );
        }

        private void QrCodeBtn_Click( object sender , EventArgs e )
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw ( QrCodetextBox.Text , 50 );
        }
    }
}

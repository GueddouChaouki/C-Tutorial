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
using System.Data.SqlClient;

namespace Backup_Restore_DataBase_To_From_Disk
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlConnection sqlConnection2 = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=master; Integrated Security=true" );
        SqlCommand Cmd;
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog ();
            saveFileDialog.Filter = "Backup files (*.BAK) | .bak";
            if (saveFileDialog.ShowDialog () == DialogResult.OK)
            {
                Cmd = new SqlCommand ( "Backup Database library_DB To Disk ='" + saveFileDialog.FileName + "'" ,sqlConnection);
                sqlConnection.Open ();
                Cmd.ExecuteNonQuery ();
                sqlConnection.Close ();
                MessageBoxEx.Show ( "backup has been executed successfully" );
            }
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            OpenFileDialog openFileDialog = new OpenFileDialog ();
            openFileDialog.Filter = "Backup files (*.BAK) | *.bak";
            if (openFileDialog.ShowDialog () == DialogResult.OK)
            {
                Cmd = new SqlCommand ( "Restore Database library_DB From Disk ='" + openFileDialog.FileName + "'" , sqlConnection2 );
                sqlConnection2.Open ();
                Cmd.ExecuteNonQuery ();
                sqlConnection2.Close ();
                MessageBoxEx.Show ( "Restauration has been executed successfully" );
            }
        }
    }
}

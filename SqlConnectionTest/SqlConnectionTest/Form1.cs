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

namespace SqlConnectionTest
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        //ou
       // SqlConnection sqlConnection2 = new SqlConnection ( "Server =.;DataBase=library_DB;Integrated Security=false; User ID=user1;Password=pswrd; Time Out ...etc" );
        public Form1()
        {
            InitializeComponent ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            sqlConnection.Open ();
            MessageBoxEx.Show ( "connection state"+sqlConnection.State );
            sqlConnection.Close ();
        }
    }
}

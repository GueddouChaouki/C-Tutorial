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

namespace SqlCommand_SqlDataReader
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        public Form1()
        {
            
            InitializeComponent ();
            sqlCommand = new SqlCommand ( "select * from Books_Table;" , sqlConnection );
            sqlConnection.Open ();
            sqlDataReader = sqlCommand.ExecuteReader ();
            while (sqlDataReader.Read ())
            {
                listBoxAdv1.Items.Add ( sqlDataReader[0].ToString ()+" "+ sqlDataReader["Title"].ToString () + " " + sqlDataReader[2].ToString () + " " + sqlDataReader[3].ToString () + " " + sqlDataReader[4].ToString () );
                

            }
            sqlDataReader.Close ();
            sqlConnection.Close ();
        }
    }
}

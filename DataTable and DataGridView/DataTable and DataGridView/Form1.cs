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

namespace DataTable_and_DataGridView
{
    public partial class Form1 : MetroForm
    {
        //connected mode ==>> SqlDataReader -- SqlCommand
        //non connected mode ==>> SqlDataAdapter Da; DataSet Ds;  DataTable Dt;

        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlDataAdapter Da;
        DataTable Dt = new DataTable ();
       

        public Form1()
        {
            InitializeComponent ();
            Da = new SqlDataAdapter ( "select * from Books_Table" , sqlConnection );
            Da.Fill ( Dt );

            dataGridViewX1.DataSource = Dt;
        }
    }
}

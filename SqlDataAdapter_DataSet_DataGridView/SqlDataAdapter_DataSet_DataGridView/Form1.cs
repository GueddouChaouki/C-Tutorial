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

namespace SqlDataAdapter_DataSet_DataGridView
{
    public partial class Form1 : MetroForm
    {
        //connected mode ==>> SqlDataReader -- SqlCommand
        //non connected mode ==>> SqlDataAdapter Da; DataSet Ds;  DataTable Dt;

        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlDataAdapter Da;
        DataSet Ds1 = new DataSet ();
        DataSet Ds2 = new DataSet ();



        public Form1()
        {
            InitializeComponent ();
            Da = new SqlDataAdapter ( "select * from Books_Table" , sqlConnection );
            Da.Fill ( Ds1 , "livres1" );
            Da.Fill ( Ds2 , "livres2" );
            dataGridViewX1.DataSource = Ds1.Tables["livres1"];//ou Ds.Tables[0];
            dataGridView1.DataSource = Ds2.Tables["livres2"];//ou Ds.Tables[0];

        }
    }
}

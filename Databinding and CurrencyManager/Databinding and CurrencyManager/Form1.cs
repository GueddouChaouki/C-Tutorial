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

namespace Databinding_and_CurrencyManager
{
    public partial class Form1 : MetroForm
    {
        //connected mode ==>> SqlDataReader -- SqlCommand
        //non connected mode ==>> SqlDataAdapter Da; DataSet Ds;  DataTable Dt;

        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlDataAdapter Da;
        DataTable Dt = new DataTable ();
        CurrencyManager Cm;

        public Form1()
        {
            InitializeComponent ();
            Da = new SqlDataAdapter ( "select * from Books_Table" , sqlConnection );
            Da.Fill ( Dt );
            ID.DataBindings.Add ( "Text" , Dt , "ID" );
            Author.DataBindings.Add ( "Text" , Dt , "Author" );
            Title.DataBindings.Add ( "Text" , Dt , "Title" );
            Publishing.DataBindings.Add ( "Text" , Dt , "Publish_Date" );
            Pages.DataBindings.Add ( "Text" , Dt , "Pages_Number" );

            Cm =(CurrencyManager) BindingContext [ Dt ];
            labelX1.Text = (Cm.Position + 1) + " / " + (Dt.Rows.Count);

        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            Cm.Position = 0;
            labelX1.Text = (Cm.Position + 1) + " / " + (Dt.Rows.Count);
        }

        private void buttonX4_Click( object sender , EventArgs e )
        {
            Cm.Position = (Dt.Rows.Count);
            labelX1.Text = (Cm.Position + 1) + " / " + (Dt.Rows.Count);
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            Cm.Position -= 1;
            labelX1.Text = (Cm.Position + 1) + " / " + (Dt.Rows.Count);
        }

        private void buttonX3_Click( object sender , EventArgs e )
        {
            Cm.Position += 1;
            labelX1.Text = (Cm.Position + 1) + " / " + (Dt.Rows.Count);
        }
    }
}

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

namespace Populating_ComboBox
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlDataAdapter Da;
        DataTable Dt = new DataTable ();
        DataTable Dt2 = new DataTable ();


        public Form1()
        {
            InitializeComponent ();
            Da = new SqlDataAdapter ( "select * from Books_Table" , sqlConnection );
            Da.Fill ( Dt );
            comboBoxEx1.DataSource = Dt;
            comboBoxEx1.DisplayMember = "ID";
            comboBoxEx1.ValueMember = "ID";
        }

        private void comboBoxEx1_SelectedIndexChanged( object sender , EventArgs e )
        {
            try
            {
                Dt2.Clear ();
                Da = new SqlDataAdapter ( "select * from Books_Table where ID='" + comboBoxEx1.Text + "'" , sqlConnection );
                Da.Fill ( Dt2 );
                /*Title.Text = Dt2.Rows[0]["Title"].ToString ();
                Author.Text = Dt2.Rows[0]["Author"].ToString ();
                Publishing.Text = Dt2.Rows[0]["Publish_Date"].ToString ();
                Pages.Text = Dt2.Rows[0]["Pages_Number"].ToString ();
                */
                //OR
                DataRowCollection DRC = Dt2.Rows;
                Title.Text = DRC[0]["Title"].ToString ();
                Author.Text = DRC[0]["Author"].ToString ();
                Publishing.Text = DRC[0]["Publish_Date"].ToString ();
                Pages.Text = DRC[0]["Pages_Number"].ToString ();

            }
            catch
            {
                return;
            }
           

        }
    }
}

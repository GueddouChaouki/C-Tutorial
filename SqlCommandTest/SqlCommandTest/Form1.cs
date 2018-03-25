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

namespace SqlCommandTest
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        public Form1()
        {

            InitializeComponent ();
        }

        private void Cancel_Click( object sender , EventArgs e )
        {
            this.Close ();
        }

        private void Validate_Click( object sender , EventArgs e )
        {
            try
            {
                sqlCommand = new SqlCommand ( "insert into Books_Table(ID,Title,Author,Publish_Date,Pages_Number) values ('" + ID.Text + "','" + Title.Text + "','" + Author.Text + "','" + Publishing.Value + "'," + Pages.Text + ")" , sqlConnection );
                sqlConnection.Open ();
                sqlCommand.ExecuteNonQuery ();
                MessageBoxEx.Show ( "added successfully" );
                
            }
            catch (SqlException ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
            finally
            {
                sqlConnection.Close (); // sera executer en toutes serconstences
            }
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            try
            {
                sqlCommand = new SqlCommand ( "delete from Books_Table where ID='"+ IDdelete.Text + "'" , sqlConnection );
                sqlConnection.Open ();
                sqlCommand.ExecuteNonQuery ();
                MessageBoxEx.Show ( "deleted successfully" );

            }
            catch (SqlException ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
            finally
            {
                sqlConnection.Close (); // sera executer en toutes serconstences
            }
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            try
            {
                sqlCommand = new SqlCommand ( "select * from Books_Table where ID='" + UpdateTextBox.Text + "'" , sqlConnection );
                sqlConnection.Open ();
                sqlDataReader = sqlCommand.ExecuteReader ();
                sqlDataReader.Read ();
                    ID.Text = sqlDataReader["ID"].ToString ();
                    Title.Text = sqlDataReader[1].ToString ();
                    Author.Text = sqlDataReader[2].ToString ();
                    Pages.Text = sqlDataReader[4].ToString ();
                    Publishing.Text = sqlDataReader[3].ToString ();
                    this.Size = new Size ( this.Width , 413 );
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
            finally
            {
                sqlConnection.Close (); // sera executer en toutes serconstences
            }
        }

        private void buttonX3_Click( object sender , EventArgs e )
        {
            try
            {
                sqlCommand = new SqlCommand ( "update Books_Table set Pages_Number="+Pages.Text+", Title='"+Title.Text+ "',Author='"+Author.Text+ "',Publish_Date='"+Publishing.Text+"' where ID='" + ID.Text+"'" , sqlConnection );
                sqlConnection.Open ();
                sqlCommand.ExecuteNonQuery ();
                MessageBoxEx.Show ( "updated successfully" );

            }
            catch (SqlException ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
            finally
            {
                sqlConnection.Close (); // sera executer en toutes serconstences
            }
        }
    }
}

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

namespace StoredProcedure
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=library_DB; Integrated Security=true" );
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable ();

        public Form1()
        {
            InitializeComponent ();
            FillDataGridView ();
            
        }

        private void FillDataGridView()
        {
            Dt.Clear ();
            cmd = new SqlCommand ( "SelectBooks" , sqlConnection );
            cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter ( cmd );
            Da.Fill ( Dt );
            dataGridViewX1.DataSource = Dt;
        }

        private void Close_Click( object sender , EventArgs e )
        {
            this.Close();
        }

        private void Add_Click( object sender , EventArgs e )
        {
            try
            {


                cmd = new SqlCommand ( "InsertBooks" , sqlConnection );
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sqlParameter = new SqlParameter[5];
                sqlParameter[0] = new SqlParameter ( "@ID" , SqlDbType.VarChar , 10 );
                sqlParameter[0].Value = ID.Text;
                sqlParameter[1] = new SqlParameter ( "@Title" , SqlDbType.VarChar , 50 );
                sqlParameter[1].Value = Title.Text;
                sqlParameter[2] = new SqlParameter ( "@Author" , SqlDbType.VarChar , 50 );
                sqlParameter[2].Value = Author.Text;
                sqlParameter[3] = new SqlParameter ( "@Pages_Number" , SqlDbType.Int );
                sqlParameter[3].Value = Pages.Text;
                sqlParameter[4] = new SqlParameter ( "@Publish_Date" , SqlDbType.DateTime , 10 );
                sqlParameter[4].Value = Publishing.Text;
                cmd.Parameters.AddRange ( sqlParameter );
                sqlConnection.Open ();
                cmd.ExecuteNonQuery ();
                sqlConnection.Close ();
                FillDataGridView ();
            MessageBoxEx.Show ( "added successfuly" );
        }
            catch(Exception ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
}

        private void New_Click( object sender , EventArgs e )
        {
            ID.Clear ();
            Author.Clear ();
            Publishing.ResetText ();
            Pages.Clear ();
            Title.Clear ();

        }

        private void Delete_Click( object sender , EventArgs e )
        {
            cmd = new SqlCommand ( "DeleteBooks" , sqlConnection );
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter ( "@ID" , SqlDbType.VarChar , 10 );
            sqlParameter.Value = ID.Text;
            cmd.Parameters.Add ( sqlParameter );
            sqlConnection.Open ();
            cmd.ExecuteNonQuery ();
            sqlConnection.Close ();
            FillDataGridView ();
            MessageBoxEx.Show ( "deleted successfuly" );
        }

        private void Update_Click( object sender , EventArgs e )
        {
            try
            {
                cmd = new SqlCommand ( "UpdateBooks" , sqlConnection );
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sqlParameter = new SqlParameter[5];
                sqlParameter[0] = new SqlParameter ( "@ID" , SqlDbType.VarChar , 10 );
                sqlParameter[0].Value = ID.Text;
                sqlParameter[1] = new SqlParameter ( "@Title" , SqlDbType.VarChar , 50 );
                sqlParameter[1].Value = Title.Text;
                sqlParameter[2] = new SqlParameter ( "@Author" , SqlDbType.VarChar , 50 );
                sqlParameter[2].Value = Author.Text;
                sqlParameter[3] = new SqlParameter ( "@Pages_Number" , SqlDbType.Int );
                sqlParameter[3].Value = Pages.Text;
                sqlParameter[4] = new SqlParameter ( "@Publish_Date" , SqlDbType.DateTime , 10 );
                sqlParameter[4].Value = Publishing.Text;
                cmd.Parameters.AddRange ( sqlParameter );
                sqlConnection.Open ();
                cmd.ExecuteNonQuery ();
                sqlConnection.Close ();
                FillDataGridView ();
                MessageBoxEx.Show ( "Updateded successfuly" );
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
        }

        private void dataGridViewX1_Click( object sender , EventArgs e )
        {
            //int position = dataGridViewX1.CurrentRow.Index;
            //ID.Text = dataGridViewX1.Rows[position].Cells[0].Value.ToString ();
            //OR
            ID.Text = dataGridViewX1.CurrentRow.Cells["ID"].Value.ToString ();
            Author.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString ();
            Title.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString ();
            Publishing.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString ();
            Pages.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString ();
  

        }
    }
}

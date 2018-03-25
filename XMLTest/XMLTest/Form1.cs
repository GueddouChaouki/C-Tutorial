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

namespace XMLTest
{
    
    public partial class Form1 : MetroForm
    {
        DataSet dataSet = new DataSet ();
        int position;
        public Form1()
        {
            InitializeComponent ();
            dataSet.ReadXml ( "BooksFile.xml" );
            dataGridViewX1.DataSource = dataSet.Tables[0];
            dataSet.Tables[0].TableName = "Books";
          
        }

        private void New_Click( object sender , EventArgs e )
        {
            ID.Clear ();
            Author.Clear ();
            Title.Clear ();
            Pages.Clear ();
            Publishing.ResetText ();
        }

        private void Close_Click( object sender , EventArgs e )
        {
            this.Close ();
        }

        private void Add_Click( object sender , EventArgs e )
        {
            //ici nous sommes pas besoin de recharger le data grid view
            //parceque elle est relie avec le fichier xml 
            //contrairement à sont traitement avec les bases de données
            DataRow Dr = dataSet.Tables[0].NewRow ();
            Dr[0] = ID.Text;
            Dr[1] = Title.Text;
            Dr[2] = Author.Text;
            Dr[3] = Pages.Text;
            Dr[4] = Publishing.Value;
            dataSet.Tables[0].Rows.Add ( Dr );
            dataSet.WriteXml ( "BooksFile.xml" );
            MessageBoxEx.Show ( "added successfuly " );
        }

        private void Delete_Click( object sender , EventArgs e )
        {
            try
            {
                for (int i = 0 ; i < dataSet.Tables["Books"].Rows.Count ; i++)
                {
                    if (ID.Text == dataSet.Tables["Books"].Rows[i][0].ToString ())
                    {
                        dataSet.Tables[0].Rows[i].Delete ();
                        dataSet.WriteXml ( "BooksFile.xml" );
                        MessageBoxEx.Show ( "deleted successfuly " );
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show ( ex.Message );
            }
            
        }

        private void dataGridViewX1_Click( object sender , EventArgs e )
        {
            ID.Text = dataGridViewX1.CurrentRow.Cells["ID"].Value.ToString ();
            Title.Text = dataGridViewX1.CurrentRow.Cells["Title"].Value.ToString ();
            Author.Text = dataGridViewX1.CurrentRow.Cells["Author"].Value.ToString ();
            Pages.Text = dataGridViewX1.CurrentRow.Cells["Pages_Number"].Value.ToString ();
            Publishing.Text = dataGridViewX1.CurrentRow.Cells["Publish"].Value.ToString ();
            position = dataGridViewX1.CurrentRow.Index;

        }

        private void Update_Click( object sender , EventArgs e )
        {
            for (int i = 0 ; i < dataSet.Tables["Books"].Rows.Count ; i++)
            {
                if (ID.Text == dataSet.Tables["Books"].Rows[i][0].ToString ())
                {
                    DataRow Dr2 = dataSet.Tables["Books"].Rows[i];
                    Dr2[0] = ID.Text;
                    Dr2[1] = Title.Text;
                    Dr2[2] = Author.Text;
                    Dr2[3] = Pages.Text;
                    Dr2[4] = Publishing.Value;
                    dataSet.WriteXml ( "BooksFile.xml" );

                    MessageBoxEx.Show ( "upsdated successfuly " );

                }

            }
        }

        private void MoveData()
        {
            if (position < 0 || position > dataSet.Tables[0].Rows.Count - 1)
            {
                position = 0;
                return;
            }
            else
            {
                ID.Text = dataSet.Tables[0].Rows[position]["ID"].ToString ();
                Title.Text = dataSet.Tables[0].Rows[position]["Title"].ToString ();
                Author.Text = dataSet.Tables[0].Rows[position]["Author"].ToString ();
                Pages.Text = dataSet.Tables[0].Rows[position]["Pages_Number"].ToString ();
                Publishing.Text = dataSet.Tables[0].Rows[position]["Publish"].ToString ();
            }
           
        }
        private void buttonX3_Click( object sender , EventArgs e )
        {
            position = position-1;
            MoveData ();
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            position = 0;
            MoveData ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            position = dataSet.Tables[0].Rows.Count-1;
            MoveData ();
        }

        private void buttonX5_Click( object sender , EventArgs e )
        {
            position = position + 1;
            MoveData ();
        }
    }
}

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

namespace Reporting
{
    public partial class Form1 : MetroForm
    {
        SqlConnection sqlConnection = new SqlConnection ( "Data Source=CHAOUKI-PC; Initial Catalog=employee; Integrated Security=true" );
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public Form1()
        {
            InitializeComponent ();
            Da = new SqlDataAdapter ( "select * from employe" , sqlConnection );
            Da.Fill ( Dt );
            this.dataGridViewX1.DataSource = Dt;
        }

        private void textBoxX1_TextChanged( object sender , EventArgs e )
        {
            Dt.Clear ();
            Da = new SqlDataAdapter ( "select * from employe where convert(varchar,NumEmploye)+Nom+Prenom+convert(varchar,DateNaissance)+Fonction+EstCadre like '%" + textBoxX1.Text+"%'" , sqlConnection );
            Da.Fill ( Dt );
            this.dataGridViewX1.DataSource = Dt;
        }

        private void buttonX4_Click( object sender , EventArgs e )
        {
            Report_Form2 Rf2 = new Report_Form2 ();
            Da = new SqlDataAdapter ( "select * from employe where convert(varchar,NumEmploye)+Nom+Prenom+convert(varchar,DateNaissance)+Fonction+EstCadre like '%" + textBoxX1.Text + "%'" , sqlConnection );
            Da.Fill ( Rf2.employeeDataSet.Employe );
            Rf2.reportViewer1.RefreshReport ();
            Rf2.Show ();
            
        }

        private void buttonX7_Click( object sender , EventArgs e )
        {
            this.Close ();
        }

        private void buttonX3_Click( object sender , EventArgs e )
        {
            Da = new SqlDataAdapter ( "select * from employe where NumEmploye='" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString () + "'" , sqlConnection );
            Report_Form Rf = new Report_Form ();
            Da.Fill ( Rf.employeeDataSet.Employe );
            Rf.reportViewer1.RefreshReport ();
            Rf.Show ();
        }

        private void buttonX2_Click( object sender , EventArgs e )
        {
            Da = new SqlDataAdapter ( "select * from employe where NumEmploye='" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString()+"'" , sqlConnection );
            Report_Form Rf = new Report_Form ();
            Da.Fill ( Rf.employeeDataSet.Employe );
            Rf.reportViewer1.RefreshReport ();
            Rf.Show ();
        }

        private void buttonX1_Click( object sender , EventArgs e )
        {
            Report_Form Rf = new Report_Form ();
            Rf.EmployeTableAdapter.Fill ( Rf.employeeDataSet.Employe );
            Rf.reportViewer1.RefreshReport ();
            Rf.Show ();
        }
    }
}

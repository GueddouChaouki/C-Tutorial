using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace Reporting
{
    public partial class Report_Form : MetroForm
    {
        
        public Report_Form()
        {

            InitializeComponent ();
        }

        private void Report_Form_Load( object sender , EventArgs e )
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employe' table. You can move, or remove it, as needed.
            //this.EmployeTableAdapter.Fill ( this.employeeDataSet.Employe );

            //this.reportViewer1.RefreshReport ();
        }
    }
}
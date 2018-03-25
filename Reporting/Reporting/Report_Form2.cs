using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Reporting
{
    public partial class Report_Form2 : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Report_Form2()
        {
            InitializeComponent ();
        }

        private void Report_Form2_Load( object sender , EventArgs e )
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employe' table. You can move, or remove it, as needed.
            //this.EmployeTableAdapter.Fill ( this.employeeDataSet.Employe );

            //this.reportViewer1.RefreshReport ();
        }
    }
}
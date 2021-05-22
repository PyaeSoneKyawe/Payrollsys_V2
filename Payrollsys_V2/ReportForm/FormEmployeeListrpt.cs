using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payrollsys_V2.ReportForm
{
    public partial class FormEmployeeListrpt : Form
    {
        public FormEmployeeListrpt()
        {
            InitializeComponent();
        }
        private void FormEmployeeListrpt_Load(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            formEmployeeListrptBindingSource.DataSource = emp.GetEmployees();
            this.reportViewer1.RefreshReport();
        }

    }
}

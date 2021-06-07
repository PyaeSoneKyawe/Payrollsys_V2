using MySql.Data.MySqlClient;
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
    public partial class FormEmployeeTotalReport : Form
    {
        employeeattendancedaily empdaily = new employeeattendancedaily();
        private List<employeeatttotreport> m_employees;
        public FormEmployeeTotalReport()
        {
            InitializeComponent();
        }

        private void FormEmployeeTotalReport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empdaily.getemp();
            Employeeatttot emptot = new Employeeatttot();
            employeeatttotreportBindingSource.DataSource = emptot.GetEmployees();
            this.reportViewer1.RefreshReport();
            startdate.Value = DateTime.Now;
            entdate.Value = DateTime.Now;

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            m_employees = new List<employeeatttotreport>();

            if(txtempid.Text == "")
            {
                
                DateTime stdate = startdate.Value;
                DateTime endate = entdate.Value;
                CONNECT conn = new CONNECT();
                MySqlCommand command = new MySqlCommand("SELECT  `Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays` FROM `employee_att_total` WHERE `Status` !=3 and To_Date BETWEEN @from AND @to", conn.getConnetion());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                
                command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
                command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string Name = row["Name"].ToString();
                    string Empid = row["Empid"].ToString();
                    int id = Int32.Parse(Empid);
                    string totwhr = row["Total_WorkingHr"].ToString();
                    string totothr = row["Total_OTHr"].ToString();
                    string totlatehr = row["Total_LateHr"].ToString();
                    string actualhr = row["Actual_WorkingHr"].ToString();
                    string Totwd = row["Total_WorkingDays"].ToString();
                    int totwd = Int32.Parse(Totwd);
                    string Totld = row["Total_LeaveDays"].ToString();
                    int totld = Int32.Parse(Totld);
                    string Actualwd = row["Actual_WorkingDays"].ToString();
                    int actualwd = Int32.Parse(Actualwd);
                    string Fromdate = row["From_Date"].ToString();
                    DateTime fromdate = DateTime.Parse(Fromdate);
                    string Todate = row["To_Date"].ToString();
                    DateTime todate = DateTime.Parse(Todate);


                    m_employees.Add(new employeeatttotreport(id, Name, totwhr, totothr, totlatehr, actualhr, totwd, totld, actualwd, fromdate, todate));
                }
                employeeatttotreportBindingSource.DataSource = m_employees;
                this.reportViewer1.RefreshReport();

            }
            else
            {
                int idd = Convert.ToInt32(txtempid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = entdate.Value;
                CONNECT conn = new CONNECT();
                MySqlCommand command = new MySqlCommand("SELECT  `Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays` FROM `employee_att_total` WHERE `Status` !=3 and `Empid`=@eid and To_Date BETWEEN @from AND @to", conn.getConnetion());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                command.Parameters.Add("@eid", MySqlDbType.Int32).Value = idd;
                command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
                command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string Name = row["Name"].ToString();
                    string Empid = row["Empid"].ToString();
                    int id = Int32.Parse(Empid);
                    string totwhr = row["Total_WorkingHr"].ToString();
                    string totothr = row["Total_OTHr"].ToString();
                    string totlatehr = row["Total_LateHr"].ToString();
                    string actualhr = row["Actual_WorkingHr"].ToString();
                    string Totwd = row["Total_WorkingDays"].ToString();
                    int totwd = Int32.Parse(Totwd);
                    string Totld = row["Total_LeaveDays"].ToString();
                    int totld = Int32.Parse(Totld);
                    string Actualwd = row["Actual_WorkingDays"].ToString();
                    int actualwd = Int32.Parse(Actualwd);
                    string Fromdate = row["From_Date"].ToString();
                    DateTime fromdate = DateTime.Parse(Fromdate);
                    string Todate = row["To_Date"].ToString();
                    DateTime todate = DateTime.Parse(Todate);


                    m_employees.Add(new employeeatttotreport(id, Name, totwhr, totothr, totlatehr, actualhr, totwd, totld, actualwd, fromdate, todate));
                }
                employeeatttotreportBindingSource.DataSource = m_employees;
                this.reportViewer1.RefreshReport();
            }


        }
        public List<employeeatttotreport> GetEmployees()
        {
            return m_employees;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView1.Visible = false;
            int id;
            id = Convert.ToInt32(txtempid.Text);

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}

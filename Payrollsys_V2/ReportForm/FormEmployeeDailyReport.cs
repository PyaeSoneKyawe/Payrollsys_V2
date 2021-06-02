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
    public partial class FormEmployeeDailyReport : Form
    {
        employeeattendancedaily empdaily = new employeeattendancedaily();
        private List<empattreport> m_employees;
        public FormEmployeeDailyReport()
        {
            InitializeComponent();
        }

        private void FormEmployeeDailyReport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empdaily.getemp();
            Employeeatts empatt = new Employeeatts();
            empattreportBindingSource.DataSource = empatt.GetEmployees();
            this.reportViewer1.RefreshReport();
            startdate.Value = DateTime.Now;
            entdate.Value = DateTime.Now;

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            m_employees = new List<empattreport>();




            if (txtempid.Text == ""){



                //int idd = Convert.ToInt32(txtempid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = entdate.Value;
                CONNECT conn = new CONNECT();
                MySqlCommand command = new MySqlCommand("SELECT `Empid`, `Name`, `Date`, `IN_Hr`, `OUT_Hr`, `DailyWork_Hr`, `OT_HR`, `Late_Hr` FROM `employee_att_daily` WHERE `Status` !=3 and DATE BETWEEN @from AND @to", conn.getConnetion());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                //command.Parameters.Add("@eid", MySqlDbType.Int32).Value = idd;
                command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
                command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
                adapter.SelectCommand = command;
                adapter.Fill(table);


                foreach (DataRow row in table.Rows)
                {
                    string Name = row["Name"].ToString();
                    string Empid = row["Empid"].ToString();
                    int id = Int32.Parse(Empid);
                    string Date = row["Date"].ToString();
                    DateTime date = DateTime.Parse(Date);
                    string In = row["IN_Hr"].ToString();
                    TimeSpan IN = TimeSpan.Parse(In);
                    string Out = row["OUT_Hr"].ToString();
                    TimeSpan OUT = TimeSpan.Parse(Out);
                    string Work_hr = row["DailyWork_Hr"].ToString();
                    TimeSpan Wk_hr = TimeSpan.Parse(Work_hr);
                    string Ot_hr = row["OT_HR"].ToString();
                    TimeSpan ot_hr = TimeSpan.Parse(Ot_hr);
                    string Late = row["Late_Hr"].ToString();
                    TimeSpan late = TimeSpan.Parse(Late);

                    m_employees.Add(new empattreport(id, Name, date, IN, OUT, Wk_hr, ot_hr, late));
                }
                empattreportBindingSource.DataSource = m_employees;
                this.reportViewer1.RefreshReport();
            }
            else

            {



                int idd = Convert.ToInt32(txtempid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = entdate.Value;
                CONNECT conn = new CONNECT();
                MySqlCommand command = new MySqlCommand("SELECT `Empid`, `Name`, `Date`, `IN_Hr`, `OUT_Hr`, `DailyWork_Hr`, `OT_HR`, `Late_Hr` FROM `employee_att_daily` WHERE `Status` !=3 and `Empid`=@eid and DATE BETWEEN @from AND @to", conn.getConnetion());
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
                    string Date = row["Date"].ToString();
                    DateTime date = DateTime.Parse(Date);
                    string In = row["IN_Hr"].ToString();
                    TimeSpan IN = TimeSpan.Parse(In);
                    string Out = row["OUT_Hr"].ToString();
                    TimeSpan OUT = TimeSpan.Parse(Out);
                    string Work_hr = row["DailyWork_Hr"].ToString();
                    TimeSpan Wk_hr = TimeSpan.Parse(Work_hr);
                    string Ot_hr = row["OT_HR"].ToString();
                    TimeSpan ot_hr = TimeSpan.Parse(Ot_hr);
                    string Late = row["Late_Hr"].ToString();
                    TimeSpan late = TimeSpan.Parse(Late);

                    m_employees.Add(new empattreport(id, Name, date, IN, OUT, Wk_hr, ot_hr, late));
                }
                empattreportBindingSource.DataSource = m_employees;
                this.reportViewer1.RefreshReport();
            }

        }
        public List<empattreport> GetEmployees()
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
    }
}

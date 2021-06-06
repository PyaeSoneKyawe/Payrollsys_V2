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
    public partial class FormPaySlipReport : Form
    {
        employeeattendancedaily empdaily = new employeeattendancedaily();
        private List<payslipreports> m_employees;
        public FormPaySlipReport()
        {
            InitializeComponent();
        }

        private void FormPaySlipReport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empdaily.getemp();
            startdate.Value = DateTime.Now;
            entdate.Value = DateTime.Now;
            this.reportViewer1.RefreshReport();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            m_employees = new List<payslipreports>();

            if(txtempid.Text == "")
            {
                
                DateTime stdate = startdate.Value;
                DateTime endate = entdate.Value;
                CONNECT conn = new CONNECT();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `payroll_calculation` WHERE `Status`!=3 and `From_Date` BETWEEN @from AND @to", conn.getConnetion());
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
                    string basicpay = row["Basic_Pay"].ToString();
                    int bpay = Int32.Parse(basicpay);
                    string ot_pay = row["OT_Pay"].ToString();
                    int ot = Int32.Parse(ot_pay);
                    string totwh = row["Total_WorkingHr"].ToString(); ;
                    string Totday = row["Total_WorkingDays"].ToString();
                    int totday = Int32.Parse(Totday);
                    string totot = row["Total_OTHr"].ToString();
                    string totlatehr = row["Total_LateHr"].ToString();
                    string Fromdate = row["From_Date"].ToString();
                    DateTime fromdate = DateTime.Parse(Fromdate);
                    string Todate = row["To_Date"].ToString();
                    DateTime todate = DateTime.Parse(Todate);
                    string Leave = row["Total_LeaveDays"].ToString();
                    int leave = Int32.Parse(Leave);
                    string Adv = row["Advance"].ToString();
                    int Advance = Int32.Parse(Adv);
                    string Oth = row["Other"].ToString();
                    int Other = Int32.Parse(Oth);
                    string Bonus = row["Bonus"].ToString();
                    int bonus = Int32.Parse(Bonus);
                    string Deduction = row["Deduction"].ToString();
                    int deduction = Int32.Parse(Deduction);
                    string Netpay = row["Net_Pay"].ToString();
                    int netpay = Int32.Parse(Netpay);
                    string Late = row["Late"].ToString();
                    int late = Int32.Parse(Late);
                    string Total = row["Total_Earning"].ToString();
                    int total = Int32.Parse(Total);

                    m_employees.Add(new payslipreports(id, Name, bpay, ot, totwh, totday, totot, totlatehr, fromdate, todate, leave, Advance, Other, bonus, deduction, netpay, late, total));
                }
                payslipreportsBindingSource.DataSource = m_employees;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                int idd = Convert.ToInt32(txtempid.Text);
                DateTime stdate = startdate.Value;
                DateTime endate = entdate.Value;
                CONNECT conn = new CONNECT();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `payroll_calculation` WHERE `Status`!=3 and `Empid`=@eid and `From_Date` BETWEEN @from AND @to", conn.getConnetion());
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
                    string basicpay = row["Basic_Pay"].ToString();
                    int bpay = Int32.Parse(basicpay);
                    string ot_pay = row["OT_Pay"].ToString();
                    int ot = Int32.Parse(ot_pay);
                    string totwh = row["Total_WorkingHr"].ToString(); ;
                    string Totday = row["Total_WorkingDays"].ToString();
                    int totday = Int32.Parse(Totday);
                    string totot = row["Total_OTHr"].ToString();
                    string totlatehr = row["Total_LateHr"].ToString();
                    string Fromdate = row["From_Date"].ToString();
                    DateTime fromdate = DateTime.Parse(Fromdate);
                    string Todate = row["To_Date"].ToString();
                    DateTime todate = DateTime.Parse(Todate);
                    string Leave = row["Total_LeaveDays"].ToString();
                    int leave = Int32.Parse(Leave);
                    string Adv = row["Advance"].ToString();
                    int Advance = Int32.Parse(Adv);
                    string Oth = row["Other"].ToString();
                    int Other = Int32.Parse(Oth);
                    string Bonus = row["Bonus"].ToString();
                    int bonus = Int32.Parse(Bonus);
                    string Deduction = row["Deduction"].ToString();
                    int deduction = Int32.Parse(Deduction);
                    string Netpay = row["Net_Pay"].ToString();
                    int netpay = Int32.Parse(Netpay);
                    string Late = row["Late"].ToString();
                    int late = Int32.Parse(Late);
                    string Total = row["Total_Earning"].ToString();
                    int total = Int32.Parse(Total);

                    m_employees.Add(new payslipreports(id, Name, bpay, ot, totwh, totday, totot, totlatehr, fromdate, todate, leave, Advance, Other, bonus, deduction, netpay, late, total));
                }
                payslipreportsBindingSource.DataSource = m_employees;
                this.reportViewer1.RefreshReport();

            }


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

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2.ReportForm
{
    
    class Employeeatttot
    {
        private List<employeeatttotreport> m_employees;

        public Employeeatttot()
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT  `Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays` FROM `employee_att_total` WHERE `Status` !=3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            m_employees = new List<employeeatttotreport>();
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
                

                m_employees.Add(new employeeatttotreport(id,Name,totwhr,totothr,totlatehr,actualhr,totwd,totld,actualwd, fromdate, todate));
            }
        }
        public List<employeeatttotreport> GetEmployees()
        {
            return m_employees;
        }
    }
}

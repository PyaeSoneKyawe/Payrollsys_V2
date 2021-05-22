using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2.ReportForm
{
    class Employeeatts
    {
        private List<empattreport> m_employees;
        public Employeeatts()
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT `Empid`, `Name`, `Date`, `IN_Hr`, `OUT_Hr`, `DailyWork_Hr`, `OT_HR`, `Late_Hr` FROM `employee_att_daily` WHERE `Status` !=3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            m_employees = new List<empattreport>();
            
            foreach(DataRow row in table.Rows)
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
        }

        public List<empattreport>GetEmployees()
        {
            return m_employees;
        }
        
        
    }
}

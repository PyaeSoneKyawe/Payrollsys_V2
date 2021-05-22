
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2.ReportForm
{
    class Employees
    {
        
        private List<Emplis> m_employees;
        public Employees()
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_info` WHERE `Status`!=3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            m_employees = new List<Emplis>();
            
            foreach (DataRow row in table.Rows)
            {
                
                string Name = row["Name"].ToString();
                string phone = row["Phone"].ToString();
                string Address = row["Address"].ToString();
                string Empid = row["Empid"].ToString();
                int id = Int32.Parse(Empid);
                string basicpay = row["Basic_Pay"].ToString();
                int bpay = Int32.Parse(basicpay);
                string ot_pay = row["OT_Pay"].ToString();
                int ot = Int32.Parse(ot_pay);
                
                m_employees.Add(new Emplis(id, Name, phone, Address, bpay, ot));
            }
        }
        public List<Emplis> GetEmployees()
        {
            return m_employees;
        }

    }
}

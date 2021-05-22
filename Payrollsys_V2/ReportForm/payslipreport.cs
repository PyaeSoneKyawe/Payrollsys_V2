﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2.ReportForm
{
    class payslipreport
    {
        private List<payslipreports> m_employees;
        public payslipreport()
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `payroll_calculation` WHERE `Status`!=3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            m_employees = new List<payslipreports>();

            foreach (DataRow row in table.Rows)
            {
                string Name = row["Name"].ToString();
                string Empid = row["Empid"].ToString();
                int id = Int32.Parse(Empid);
                string basicpay = row["Basic_Pay"].ToString();
                int bpay = Int32.Parse(basicpay);
                string ot_pay = row["OT_Pay"].ToString();
                int ot = Int32.Parse(ot_pay);
                string totwh = row["Total_WorkingHr"].ToString();;
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

                m_employees.Add(new payslipreports(id,  Name,  bpay,  ot,  totwh,  totday,  totot,  totlatehr,  fromdate,  todate,  leave,  Advance,  Other,  bonus,  deduction,  netpay,  late,  total));
            }
        }
        public List<payslipreports> GetEmployees()
        {
            return m_employees;
        }
    }
}

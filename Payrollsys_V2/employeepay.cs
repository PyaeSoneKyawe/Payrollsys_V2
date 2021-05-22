
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    class employeepay
    {
        CONNECT conn = new CONNECT();

        public bool insertpayment(int id, string nm, int bp, int ot, int totday, string tothr, string totot, string totlate, DateTime stdate, DateTime endate, int leave, int adv, int other, int bonus, int deduction,int late, int netpay,int earning,int state)
        {

            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `payroll_calculation`(`Empid`, `Name`, `Basic_Pay`, `OT_Pay`, `Total_WorkingDays`, `Total_WorkingHr`, `Total_OTHr`, `Total_LateHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Advance`, `Other`, `Bonus`, `Deduction`, `Late`, `Net_Pay`, `Total_Earning`, `Status`) VALUES (@eid,@nm,@bp,@ot,@totday,@tothr,@totot,@totlate,@from,@to,@leave,@adv,@other,@bonus,@deduction,@late,@netpay,@earning,@state)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm,@bp,@totday,@tothr,@totot,@from,@to,@leave,@adv,@other,@netpay
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@bp", MySqlDbType.Int32).Value = bp;
            command.Parameters.Add("@ot", MySqlDbType.Int32).Value = ot;
            command.Parameters.Add("@totday", MySqlDbType.Int32).Value = totday;
            command.Parameters.Add("@tothr", MySqlDbType.VarChar).Value = tothr;
            command.Parameters.Add("@totot", MySqlDbType.VarChar).Value = totot;
            command.Parameters.Add("@totlate", MySqlDbType.VarChar).Value = totlate;
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            command.Parameters.Add("@leave", MySqlDbType.Int32).Value = leave;
            command.Parameters.Add("@adv", MySqlDbType.Int32).Value = adv;
            command.Parameters.Add("@other", MySqlDbType.Int32).Value = other;
            command.Parameters.Add("@bonus", MySqlDbType.Int32).Value = bonus;
            command.Parameters.Add("@deduction", MySqlDbType.Int32).Value = deduction;
            command.Parameters.Add("@netpay", MySqlDbType.Int32).Value = netpay;
            command.Parameters.Add("@late", MySqlDbType.Int32).Value = late;
            command.Parameters.Add("@earning", MySqlDbType.Int32).Value = earning;
            command.Parameters.Add("@state", MySqlDbType.Int32).Value = state;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public bool removeemppay(int eid,int id, string nm, int bp, int ot, int totday, string tothr, string totot, string totlate, DateTime stdate, DateTime endate, int leave, int adv, int other, int bonus, int deduction, int late, int netpay, int earning, int state)
        {
            //UPDATE `payroll_calculation` SET `Empid`=@eid,`Name`=@nm,`Basic_Pay`=@bp,`OT_Pay`=@ot,`Total_WorkingDays`=@totday,`Total_WorkingHr`=@tothr,`Total_OTHr`=@toto,`Total_LateHr`=@totlate,`From_Date`=@from,`To_Date`=@to,`Total_LeaveDays`=@leave,`Advance`=@adv,`Other`=@other,`Bonus`=@bonus,`Deduction`=@deduction,`Late`=@late,`Net_Pay`=@netpay,`Total_Earning`=@earning,`Status`=@state
            //UPDATE `employee_att_total` SET `Empid`=@eid,`Name`=@nm,`Total_WorkingHr`=@tothr,`Total_WorkingDays`=@totday,`Total_OTHr`=@totot,`From_Date`=@from,`To_Date`=@to,`Total_LeaveDays`=@leave,`Total_LateHr`=@totlate,`Actual_WorkingHr`=@totactual,`Actual_WorkingDays`=@actualdays,`Status`= @state
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `payroll_calculation` SET `Empid`=@eid,`Name`=@nm,`Basic_Pay`=@bp,`OT_Pay`=@ot,`Total_WorkingDays`=@totday,`Total_WorkingHr`=@tothr,`Total_OTHr`=@totot,`Total_LateHr`=@totlate,`From_Date`=@from,`To_Date`=@to,`Total_LeaveDays`=@leave,`Advance`=@adv,`Other`=@other,`Bonus`=@bonus,`Deduction`=@deduction,`Late`=@late,`Net_Pay`=@netpay,`Total_Earning`=@earning,`Status`=@state WHERE `Empid`=@eid and `Name`=@nm and `ID`=@id and Status != 3 ";
            command.CommandText = editQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = eid;
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@bp", MySqlDbType.Int32).Value = bp;
            command.Parameters.Add("@ot", MySqlDbType.Int32).Value = ot;
            command.Parameters.Add("@totday", MySqlDbType.Int32).Value = totday;
            command.Parameters.Add("@tothr", MySqlDbType.VarChar).Value = tothr;
            command.Parameters.Add("@totot", MySqlDbType.VarChar).Value = totot;
            command.Parameters.Add("@totlate", MySqlDbType.VarChar).Value = totlate;
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            command.Parameters.Add("@leave", MySqlDbType.Int32).Value = leave;
            command.Parameters.Add("@adv", MySqlDbType.Int32).Value = adv;
            command.Parameters.Add("@other", MySqlDbType.Int32).Value = other;
            command.Parameters.Add("@bonus", MySqlDbType.Int32).Value = bonus;
            command.Parameters.Add("@deduction", MySqlDbType.Int32).Value = deduction;
            command.Parameters.Add("@netpay", MySqlDbType.Int32).Value = netpay;
            command.Parameters.Add("@late", MySqlDbType.Int32).Value = late;
            command.Parameters.Add("@earning", MySqlDbType.Int32).Value = earning;
            command.Parameters.Add("@state", MySqlDbType.Int32).Value = state;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


        public DataTable getemp()
        {
            MySqlCommand command = new MySqlCommand("SELECT employee_info.Empid, employee_info.Name,employee_info.Basic_Pay,employee_info.OT_Pay,employee_att_total.Total_WorkingHr,employee_att_total.Total_WorkingDays,employee_att_total.Total_OTHr,employee_att_total.From_Date,employee_att_total.To_Date,employee_att_total.Total_LeaveDays,employee_att_total.Total_LateHr,employee_att_total.Actual_WorkingHr,employee_att_total.Actual_WorkingDays,employee_att_total.Status FROM employee_info INNER JOIN employee_att_total ON employee_info.Empid = employee_att_total.Empid and employee_att_total.Status !=3 ; ", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public DataTable getemppay()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `payroll_calculation` Where `Status` != 3 ORDER BY `Empid` ,`From_Date` ", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable filterempatt(int id)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM payroll_calculation WHERE `Empid`=@eid and `Status`!=3 ", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool IfDataexits(int id, DateTime stdate, DateTime endate)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM payroll_calculation WHERE `Status`!= 3 and Empid =@eid and `From_Date`= @from and `To_Date`= @to", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;

        }
    }
}

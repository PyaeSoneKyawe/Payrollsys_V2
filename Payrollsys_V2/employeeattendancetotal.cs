using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    
    class employeeattendancetotal
    {
        CONNECT conn = new CONNECT();
        public bool insertempatttot(int id, string nm, string tothr, int totday, string totot, DateTime stdate, DateTime endate, int leave,  string totlate, string totactual, int actualdays,int state,string EID)
        {
           // INSERT INTO `employee_att_total`(`Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays`, `Status`) VALUES(,,,,,,,,,,,)
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `employee_att_total`(`Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays`, `Status`,`Employee_ID`) VALUES (@eid,@nm,@tothr,@totday,@totot,@from,@to,@leave,@totlate,@totactual,@actualdays,@state,@EmpID)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@tothr", MySqlDbType.VarChar).Value = tothr;
            command.Parameters.Add("@totday", MySqlDbType.Int32).Value = totday;
            command.Parameters.Add("@totot", MySqlDbType.VarChar).Value = totot;
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            command.Parameters.Add("@leave", MySqlDbType.Int32).Value = leave;
            command.Parameters.Add("@totactual", MySqlDbType.VarChar).Value = totactual;
            command.Parameters.Add("@totlate", MySqlDbType.VarChar).Value = totlate;
            command.Parameters.Add("@actualdays", MySqlDbType.Int32).Value = actualdays;
            command.Parameters.Add("@state", MySqlDbType.Int32).Value = state;
            command.Parameters.Add("@EmpID", MySqlDbType.VarChar).Value = EID;

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

        public bool editempatttot(int eid,int id, string nm, string tothr, int totday, string totot, DateTime stdate, DateTime endate, int leave, string totlate, string totactual, int actualdays, int state)
        {
            //UPDATE `employee_att_total` SET `Empid`=@eid,`Name`=@nm,`Total_WorkingHr`=@toth,`Total_WorkingDays`=@totday,`Total_OTHr`=@totot,`From_Date`=@from,`To_Date`=@to,`Total_LeaveDays`=@leave,`Total_LateHr`=@totlate,`Actual_WorkingHr`=@totactual,`Actual_WorkingDays`=@actualdays,`Status`= @state
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `employee_att_total` SET `Empid`=@eid,`Name`=@nm,`Total_WorkingHr`=@tothr,`Total_WorkingDays`=@totday,`Total_OTHr`=@totot,`From_Date`=@from,`To_Date`=@to,`Total_LeaveDays`=@leave,`Total_LateHr`=@totlate,`Actual_WorkingHr`=@totactual,`Actual_WorkingDays`=@actualdays,`Status`= @state WHERE `Empid`=@eid and `Name`=@nm and `ID`=@id and Status != 3";
            command.CommandText = editQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = eid;
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@tothr", MySqlDbType.VarChar).Value = tothr;
            command.Parameters.Add("@totday", MySqlDbType.Int32).Value = totday;
            command.Parameters.Add("@totot", MySqlDbType.VarChar).Value = totot;
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            command.Parameters.Add("@leave", MySqlDbType.Int32).Value = leave;
            command.Parameters.Add("@totactual", MySqlDbType.VarChar).Value = totactual;
            command.Parameters.Add("@totlate", MySqlDbType.VarChar).Value = totlate;
            command.Parameters.Add("@actualdays", MySqlDbType.Int32).Value = actualdays;
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

        public DataTable filterempatt(int id)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_att_total` WHERE `Empid`=@eid and `Status`!=3  ", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //// function to get employee_att list
        public DataTable getempatt()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_att_total` Where `Status` != 3 ORDER BY `Empid` ,`From_Date`", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public DataTable getemp()
        {
            MySqlCommand command = new MySqlCommand("SELECT `Empid`,`Name`,`ID` FROM `employee_info` where `Status`!= 3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        //check the data already exit or not
        public bool IfDataexits(int id, DateTime stdate,DateTime endate)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_att_total` WHERE `Status`!= 3 and Empid =@eid and `From_Date`= @from and `To_Date`= @to", conn.getConnetion());
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

        public bool removeemptot(int eid,int id, string nm, string tothr, int totday, string totot, DateTime stdate, DateTime endate, int leave, string totlate, string totactual, int actualdays, int state)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `employee_att_total` SET `Empid`=@eid,`Name`=@nm,`Total_WorkingHr`=@tothr,`Total_WorkingDays`=@totday,`Total_OTHr`=@totot,`From_Date`=@from,`To_Date`=@to,`Total_LeaveDays`=@leave,`Total_LateHr`=@totlate,`Actual_WorkingHr`=@totactual,`Actual_WorkingDays`=@actualdays,`Status`= @state WHERE `Empid`=@eid and `Name`=@nm and `ID`=@id and Status != 3";
            command.CommandText = editQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = eid;
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@tothr", MySqlDbType.VarChar).Value = tothr;
            command.Parameters.Add("@totday", MySqlDbType.Int32).Value = totday;
            command.Parameters.Add("@totot", MySqlDbType.VarChar).Value = totot;
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            command.Parameters.Add("@leave", MySqlDbType.Int32).Value = leave;
            command.Parameters.Add("@totactual", MySqlDbType.VarChar).Value = totactual;
            command.Parameters.Add("@totlate", MySqlDbType.VarChar).Value = totlate;
            command.Parameters.Add("@actualdays", MySqlDbType.Int32).Value = actualdays;
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
        public DataTable getEmployeeAttemdamceTotal()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", Type.GetType("System.String"));
            dt.Columns.Add("Employee ID", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Total Working Hours", Type.GetType("System.String"));
            dt.Columns.Add("Total Working Days", Type.GetType("System.String"));
            dt.Columns.Add("Total OT Hours", Type.GetType("System.String"));
            dt.Columns.Add("From Date", Type.GetType("System.String"));
            dt.Columns.Add("To Date", Type.GetType("System.String"));
            dt.Columns.Add("Total Leave Days", Type.GetType("System.String"));
            dt.Columns.Add("Total Late Hours", Type.GetType("System.String"));
            dt.Columns.Add("Actual Working Hours", Type.GetType("System.String"));
            dt.Columns.Add("Actual Working Days", Type.GetType("System.String"));
            dt.Columns.Add("EID", Type.GetType("System.String"));
            MySqlCommand command = new MySqlCommand("select * from employee_att_total  where `Status`!= 3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = table.Rows[i]["ID"].ToString();
                dr["Employee ID"] = table.Rows[i]["EmpId"].ToString();
                dr["Name"] = table.Rows[i]["Name"].ToString();
                dr["Total Working Hours"] = table.Rows[i]["Total_WorkingHr"].ToString();
                dr["Total Working Days"] = table.Rows[i]["Total_WorkingDays"].ToString();
                dr["Total OT Hours"] = table.Rows[i]["Total_OTHr"].ToString();
                dr["From Date"] = table.Rows[i]["From_Date"].ToString();
                dr["To Date"] = table.Rows[i]["To_Date"].ToString();
                dr["Total Leave Days"] = table.Rows[i]["Total_LeaveDays"].ToString();
                dr["Total Late HOurs"] = table.Rows[i]["Total_LateHr"].ToString();
                dr["Actual Working Hours"] = table.Rows[i]["Actual_WorkingHr"].ToString();
                dr["Actual Working Days"] = table.Rows[i]["Actual_WorkingDays"].ToString();
                dr["EID"] = table.Rows[i]["Employee_ID"].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable GetTotalDays(int id,DateTime stdate,DateTime endate)
        {
            
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`Date`) as Total FROM employee_att_daily WHERE `Status`!=3 and `Empid`= '" + id + "' and Date BETWEEN @from and @to ", conn.getConnetion());
                command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
                command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                return table;
            
        }
        public DataTable GetTotalLeaveDays(int id,DateTime leavetime, DateTime stdate, DateTime endate)
        {

            MySqlCommand command = new MySqlCommand("SELECT COUNT(`Date`) as Total  FROM employee_att_daily WHERE `Status`!=3 and `DailyWork_Hr` = '" + leavetime + "' and Empid ='" + id + "' and Date BETWEEN @from and @to", conn.getConnetion());
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            Console.WriteLine(table);
            return table;

        }
        public int GetActualWorkingDays(int id,DateTime leavetime, DateTime stdate, DateTime endate)
        {
            DataTable t1 = GetTotalDays(id,stdate,endate);
            DataTable t2 = GetTotalLeaveDays(id,leavetime,stdate, endate);
            int totaldays,totalleaves;
            int total = 0;
            if (t1.Rows.Count > 0 && t2.Rows.Count > 0)
            {
                totaldays = int.Parse(t1.Rows[0]["Total"].ToString());
                totalleaves = int.Parse(t2.Rows[0]["Total"].ToString());
                total = totaldays - totalleaves;
            }
            return total;

            
        }
        public DataTable GetTotalLateHours(int id, DateTime stdate, DateTime endate)
        {

            MySqlCommand command = new MySqlCommand("select (sum(time_to_sec(`Late_Hr`)))  as Total from employee_att_daily WHERE `Status`!=3 and Empid ='" + id + "' and Date BETWEEN @from and @to ", conn.getConnetion());
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public DataTable GetTotalWorkingHours(int id, DateTime stdate, DateTime endate)
        {

            MySqlCommand command = new MySqlCommand("select (sum(time_to_sec(`DailyWork_Hr`) ) ) as Total from employee_att_daily WHERE `Status`!=3 and Empid =@empid and Date BETWEEN @from and @to ", conn.getConnetion());
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            command.Parameters.Add("@empid", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public DataTable GetTotalOtTime(int id, DateTime stdate, DateTime endate)
        {

            MySqlCommand command = new MySqlCommand("SELECT (SUM(TIME_TO_SEC(`OT_HR`))) AS Total from employee_att_daily WHERE `Status`!=3 and Empid ='" + id + "' and Date BETWEEN @from and @to ", conn.getConnetion());
            command.Parameters.Add("@from", MySqlDbType.Date).Value = stdate;
            command.Parameters.Add("@to", MySqlDbType.Date).Value = endate;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
    }

}


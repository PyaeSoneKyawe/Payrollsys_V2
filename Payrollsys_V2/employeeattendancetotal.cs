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
        public bool insertempatttot(int id, string nm, string tothr, int totday, string totot, DateTime stdate, DateTime endate, int leave,  string totlate, string totactual, int actualdays,int state)
        {
           // INSERT INTO `employee_att_total`(`Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays`, `Status`) VALUES(,,,,,,,,,,,)
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `employee_att_total`(`Empid`, `Name`, `Total_WorkingHr`, `Total_WorkingDays`, `Total_OTHr`, `From_Date`, `To_Date`, `Total_LeaveDays`, `Total_LateHr`, `Actual_WorkingHr`, `Actual_WorkingDays`, `Status`) VALUES (@eid,@nm,@tothr,@totday,@totot,@from,@to,@leave,@totlate,@totactual,@actualdays,@state)";
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
            MySqlCommand command = new MySqlCommand("SELECT `Empid`,`Name` FROM `employee_info` where `Status`!= 3", conn.getConnetion());
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
    }

}


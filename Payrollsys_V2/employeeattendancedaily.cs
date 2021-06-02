using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    class employeeattendancedaily
    {
        CONNECT conn = new CONNECT();
        //create a function to insert a new employee
        public bool insertempatt(int id, string nm, DateTime dt, DateTime tin, DateTime tout, DateTime wh, DateTime oth, DateTime late,int state,string EID)
        {

            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `employee_att_daily`(`Empid`, `Name`, `Date`, `IN_Hr`, `OUT_Hr`, `DailyWork_Hr`, `OT_HR`, `Late_Hr`, `Status`,`EID`) VALUES (@eid,@nm,@dt,@tin,@tout,@wh,@oth,@late,@state,@EmpID)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = dt;
            command.Parameters.Add("@tin", MySqlDbType.Timestamp).Value = tin;
            command.Parameters.Add("@tout", MySqlDbType.Timestamp).Value = tout;
            command.Parameters.Add("@wh", MySqlDbType.Timestamp).Value = wh;
            command.Parameters.Add("@oth", MySqlDbType.Timestamp).Value = oth;
            command.Parameters.Add("@late", MySqlDbType.Timestamp).Value = late;
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
        public DataTable filterempatt(int id)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_att_daily` WHERE `Empid`=@eid and `Status`!= 3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            //command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable getemp()
        {
             MySqlCommand command = new MySqlCommand("SELECT `ID`,`Empid`,`Name` FROM `employee_info` where `Status`!= 3", conn.getConnetion());
             MySqlDataAdapter adapter = new MySqlDataAdapter();
             DataTable table = new DataTable();

             adapter.SelectCommand = command;
             adapter.Fill(table);

             return table;
        }

        //// function to get employee_att list
        public DataTable getempatt()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_att_daily` WHERE `Status` != 3 ORDER BY `Empid` ,`Date` ", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //check the data already exit or not
        public bool IfDataexits(int id ,DateTime dt)
        {
            MySqlCommand command = new MySqlCommand("SELECT Empid,Date FROM `employee_att_daily` WHERE `Status`!= 3 and `Empid`=@eid and `Date`= @dt", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = dt;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count>0)
                return true;
            else
                return false;
           
        }

        // function to edit employee_att list
        public bool editempatt(int eid,int id, String nm, DateTime dt, DateTime tin, DateTime tout, DateTime wh, DateTime oth, DateTime late, int state,string EmployeeID)
        {
            // UPDATE `employee_att` SET `Name`=@nm,`IN`=@tin,`Out`=@tout,`Work_HR`=@wh,`OT_HR`=@oth,`Late`=@late WHERE `Empid`=@eid and 
            MySqlCommand command = new MySqlCommand();
            //String editQuery = "UPDATE `employee_att_daily` SET `Empid`=@eid,`Name`=@nm,`Date`=@dt,`IN_Hr`=@tin,`OUT_Hr`=@tout,`DailyWork_Hr`=@wh,`OT_HR`=@oth,`Late_Hr`=@late,`Status`=@state ,`EID`=@EmployeeID where `Empid`=@eid and `Date`=@dt and `ID`=@id and Status != 3  ";
            string editQuery = "UPDATE `employee_att_daily` SET `Name`=@nm,`Date`=@dt,`IN_Hr`=@tin,`OUT_Hr`=@tout,`DailyWork_Hr`=@wh,`OT_HR`=@oth,`Late_Hr`=@late,`Status`=@state ,`EID`=@EmployeeID where `Empid`=@eid and `ID`=@id and Status != 3  ";
            command.CommandText = editQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = eid;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = dt;
            command.Parameters.Add("@tin", MySqlDbType.Timestamp).Value = tin;
            command.Parameters.Add("@tout", MySqlDbType.Timestamp).Value = tout;
            command.Parameters.Add("@wh", MySqlDbType.Timestamp).Value = wh;
            command.Parameters.Add("@oth", MySqlDbType.Timestamp).Value = oth;
            command.Parameters.Add("@late", MySqlDbType.Timestamp).Value = late;
            command.Parameters.Add("@state", MySqlDbType.Int32).Value = state;
            command.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = EmployeeID;

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

        //remove employee att 
        public bool removeemp(int eid,int id, String nm, DateTime dt, DateTime tin, DateTime tout, DateTime wh, DateTime oth, DateTime late, int state)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `employee_att_daily` SET `Empid`=@eid,`Name`=@nm,`Date`=@dt,`IN_Hr`=@tin,`OUT_Hr`=@tout,`DailyWork_Hr`=@wh,`OT_HR`=@oth,`Late_Hr`=@late,`Status`=@state where `Empid`=@eid and `Date`=@dt and `ID`=@id and Status != 3 ";
            command.CommandText = editQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @dt, @wh, @oth
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = eid;
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@dt", MySqlDbType.Date).Value = dt;
            command.Parameters.Add("@tin", MySqlDbType.Timestamp).Value = tin;
            command.Parameters.Add("@tout", MySqlDbType.Timestamp).Value = tout;
            command.Parameters.Add("@wh", MySqlDbType.Timestamp).Value = wh;
            command.Parameters.Add("@oth", MySqlDbType.Timestamp).Value = oth;
            command.Parameters.Add("@late", MySqlDbType.Timestamp).Value = late;
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

        public DataTable getEmployeeAttemdamceDaily()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", Type.GetType("System.String"));
            dt.Columns.Add("Employee ID", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Date", Type.GetType("System.String"));
            dt.Columns.Add("In Hour", Type.GetType("System.String"));
            dt.Columns.Add("Out Hour", Type.GetType("System.String"));
            dt.Columns.Add("Daily WorkHour", Type.GetType("System.String"));
            dt.Columns.Add("OT Hour", Type.GetType("System.String"));
            dt.Columns.Add("Late Hour", Type.GetType("System.String"));
            dt.Columns.Add("EID", Type.GetType("System.String"));
            MySqlCommand command = new MySqlCommand("select * from employee_att_daily  where `Status`!= 3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = table.Rows[i]["ID"].ToString();
                dr["Employee ID"] = table.Rows[i]["EID"].ToString();
                dr["Name"] = table.Rows[i]["Name"].ToString();
                dr["Date"] = table.Rows[i]["Date"].ToString();
                dr["In Hour"] = table.Rows[i]["In_Hr"].ToString();
                dr["Out Hour"] = table.Rows[i]["OUT_Hr"].ToString();
                dr["Daily WorkHour"] = table.Rows[i]["DailyWork_Hr"].ToString();
                dr["OT Hour"] = table.Rows[i]["OT_Hr"].ToString();
                dr["Late Hour"] = table.Rows[i]["Late_Hr"].ToString();
                dr["EID"] = table.Rows[i]["Empid"].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}

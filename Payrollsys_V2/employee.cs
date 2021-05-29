using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    class employee
    {
        CONNECT conn = new CONNECT();
        //create a function to insert a new employee
        public bool insertClient(string id,string nm, string ph, string ad, int bp, int otp, int state)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `employee_info`(`EmpID`,`Name`, `Phone`, `Address`, `Salary`, `OT`, `Status`) VALUES(@id,@nm, @ph, @ad, @bp,@otp,@state)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnetion();

            //@nm, @ph, @ad, @bp
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = ph;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@bp", MySqlDbType.Int32).Value = bp;
            command.Parameters.Add("@otp", MySqlDbType.Int32).Value = otp;
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

        // function to get employee list
        public DataTable getemp()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_info`", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        // funtion to get employee list before delete
        public DataTable getdelemp()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_info` where `Status`!= 3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        // function to edit employee list

        public bool editemp(int id,string eid, string nm, string ph, string ad, int bp, int otp,int state)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `employee_info` SET `EmpID`=@eID,`Name`=@nm,`Phone`=@ph,`Address`=@ad,`Salary`=@bp,`OT`=@otp,`Status`=@state WHERE `ID`=@id";
            command.CommandText = editQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @ph, @ad, @bp
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = eid;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = ph;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@bp", MySqlDbType.Int32).Value = bp;
            command.Parameters.Add("@otp", MySqlDbType.Int32).Value = otp;
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

        // create a unction to delete the select employee
        public bool removeemp(int id, String nm, String ph, String ad, int bp, int otp, int state)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "UPDATE `employee_info` SET `Name`=@nm,`Phone`=@ph,`Address`=@ad,`Basic_Pay`=@bp,`OT_Pay`=@otp,`Status`=@state WHERE `Empid`=@eid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnetion();

            //@eid,@nm, @ph, @ad, @bp
            
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nm;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = ph;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@bp", MySqlDbType.Int32).Value = bp;
            command.Parameters.Add("@otp", MySqlDbType.Int32).Value = otp;
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

        public DataTable getEmployees()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", Type.GetType("System.String"));
            dt.Columns.Add("Employee ID", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Phone", Type.GetType("System.String"));
            dt.Columns.Add("Address", Type.GetType("System.String"));
            dt.Columns.Add("Salary", Type.GetType("System.String"));
            dt.Columns.Add("OT", Type.GetType("System.String"));
            MySqlCommand command = new MySqlCommand("select * from employee_info  where `Status`!= 3", conn.getConnetion());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = table.Rows[i]["ID"].ToString();
                dr["Employee ID"] = table.Rows[i]["EmpID"].ToString();
                dr["Name"] = table.Rows[i]["Name"].ToString();
                dr["Phone"] = table.Rows[i]["Phone"].ToString();
                dr["Address"] = table.Rows[i]["Address"].ToString();
                dr["Salary"] = table.Rows[i]["Salary"].ToString();
                dr["OT"] = table.Rows[i]["OT"].ToString();     
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}

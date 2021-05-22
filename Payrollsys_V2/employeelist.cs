using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    class employeelist
    {
       
        public int Empid { get; set; }
        public DateTime Date { get; set; }

        public employeelist(int Empid,DateTime Date)
        {
            this.Empid = Empid;
            this.Date = Date;
        }

    }
}

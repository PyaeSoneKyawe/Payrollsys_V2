using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    public class employeeatttotreport
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Total_WorkingHr { get; set; }
        public string Total_OTHr { get; set; }
        public string Total_lateHr { get; set; }
        public string Actual_WorkingHr { get; set; }
        public int Total_WorkingDays { get; set; }
        public int Total_LeaveDays { get; set; }
        public int Actual_WorkingDays { get; set; }
        public DateTime From_Date { get; set; }
        public DateTime To_Date { get; set; }

        public employeeatttotreport(int Empid,string Name,string totwhr,string totothr,string totlatehr,string actualhr,int totwd,int totld,int actualwd,DateTime fromdate,DateTime todate)
        {
            this.Empid = Empid;
            this.Name = Name;
            this.Total_WorkingHr = totwhr;
            this.Total_OTHr = totothr;
            this.Total_lateHr = totlatehr;
            this.Actual_WorkingHr = actualhr;
            this.Total_WorkingDays = totwd;
            this.Total_LeaveDays = totld;
            this.Actual_WorkingDays = actualwd;
            this.From_Date = fromdate;
            this.To_Date = todate;
        }
    }
}

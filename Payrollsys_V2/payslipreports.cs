using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    public class payslipreports
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public int Basic_Pay { get; set; }
        public int OT_Pay { get; set; }
        public int Total_WorkingDays { get; set; }
        public string Total_WorkingHr { get; set; }
        public string Total_OTHr { get; set; }
        public string Total_LateHr { get; set; }
        public int Total_LeaveDays { get; set; }
        public int Advance { get; set; }
        public int Other { get; set; }
        public int Bonus { get; set; }
        public int Deduction { get; set; }
        public int Late { get; set; }
        public int Net_Pay { get; set; }
        public int Total_Earning { get; set; }
        public DateTime From_Date { get; set; }
        public DateTime To_Date { get; set; }

        public payslipreports(int Empid, string Name, int basicpay, int ot_pay, string totwh, int totday, string totot, string totlatehr, DateTime fromdate, DateTime todate, int leave, int Advance, int Other, int bonus, int deduction, int netpay ,int late,int total)
        {
            this.Empid = Empid;
            this.Name = Name;
            this.Basic_Pay = basicpay;
            this.OT_Pay = ot_pay;
            this.From_Date = fromdate;
            this.To_Date = todate;
            this.Total_WorkingHr = totwh;
            this.Total_WorkingDays = totday;
            this.Total_OTHr = totot;
            this.Total_LateHr = totlatehr;
            this.Total_LeaveDays = leave;
            this.Advance = Advance;
            this.Other = Other;
            this.Bonus = bonus;
            this.Deduction = deduction;
            this.Net_Pay = netpay;
            this.Late = late;
            this.Total_Earning = total;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    public class empattreport
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan In { get; set; }
        public TimeSpan Out { get; set; }
        public TimeSpan Working_hours { get; set; }
        public TimeSpan OT_hours { get; set; }
        public TimeSpan Late { get; set; }

        public empattreport(int Empid, string Name, DateTime Date, TimeSpan In, TimeSpan Out, TimeSpan Working_hours, TimeSpan OT_hours, TimeSpan late)
        {
            this.Empid = Empid;
            this.Name = Name;
            this.Date = Date;
            this.In = In;
            this.Out = Out;
            this.Working_hours = Working_hours;
            this.OT_hours = OT_hours;
            this.Late = late;
        }
    }
}

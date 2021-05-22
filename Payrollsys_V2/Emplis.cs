using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys_V2
{
    public class Emplis
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Basic_pay { get; set; }
        public int OT_Pay { get; set; }

        public Emplis(int Empid, string Name, string Phone, string Address, int basicpay, int ot_pay)
        {
            this.Empid = Empid;
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
            this.Basic_pay = basicpay;
            this.OT_Pay = ot_pay;
        }
    }
}

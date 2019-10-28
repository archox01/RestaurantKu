using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuUI.SupportThings
{
    public class MemberInformation
    {
        public int MemberId{ get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPassword { get; set; }
        public string HandPhone { get; set; }
        public string JoinDate{ get; set; }
        public string BankName { get; set; }
        public string  AccNumber{ get; set; }
        public string  CCNumber{ get; set; }
        public string  Address{ get; set; }
        public string Deleted { get; set; }
    }
}

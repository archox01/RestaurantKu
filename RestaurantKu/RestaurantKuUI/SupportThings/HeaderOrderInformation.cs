using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuUI.SupportThings
{
    public class HeaderOrderInformation
    {
        public int orderid { get; set; }
        public string employeeid { get; set; }
        public int memberid { get; set; }
        public System.DateTime date { get; set; }
        public string payment { get; set; }
        public string bank { get; set; }
    }
}

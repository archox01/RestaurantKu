using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuUI.SupportThings
{
    public class DetailOrderInformation
    {
        public int detailid { get; set; }
        public int orderid { get; set; }
        public int menuid { get; set; }
        public int qty { get; set; }
        public int total { get; set; }
        public string status { get; set; }
    }
}

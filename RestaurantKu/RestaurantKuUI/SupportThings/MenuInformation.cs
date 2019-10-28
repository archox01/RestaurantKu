using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuUI.SupportThings
{
    public class MenuInformation
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public byte[] photo { get; set; }
        public string PhotoPath { get; set; }
    }
}

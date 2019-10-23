using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuUI.SupportThings
{
    public class EmployeeInformation
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeeHandPhone { get; set; }
        public string EmployeePosition { get; set; }

        public EmployeeInformation()
        {

        }
        public EmployeeInformation(string EmployeeIds,string EmployeeNames,string EmployeeEmails,string EmployeePasswords,
            string EmployeeHandphones,string EmployeePositions)
        {
            EmployeeIds = EmployeeId;
            EmployeeNames = EmployeeName;
            EmployeeEmail = EmployeeEmails;
            EmployeePassword = EmployeePasswords;
            EmployeeHandphones = this.EmployeeeHandPhone;
            EmployeePosition = EmployeePositions;

        }
    }
    
}

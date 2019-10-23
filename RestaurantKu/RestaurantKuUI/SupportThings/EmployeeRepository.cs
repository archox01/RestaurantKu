using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantKuUI.Properties;

namespace RestaurantKuUI.SupportThings
{
    public class EmployeeRepository
    {
        
        public List<EmployeeInformation> GetEmpData()
        {
            using (var Context = new RestaurantkuContext())
            {
                return Context.msemployees.Select(a => new EmployeeInformation()
                {
                    EmployeeId = a.employeeid,
                    EmployeeEmail = a.email,
                    EmployeeName = a.name,
                    EmployeePassword = a.password,
                    EmployeeeHandPhone = a.handphone,
                    EmployeePosition = a.position
                }).ToList();
                
            }

        }
        public EmployeeInformation InsertData (EmployeeInformation Information)
        {
            //using (RestaurantkuContext Context = new RestaurantkuContext())
            //{
            //    string EmployeeId = Information.EmployeeId;
            //    string EmployeeName = Information.EmployeeName;
            //    string EmployeeEmail = Information.EmployeeEmail;
            //    string EmployeePassword = Information.EmployeePassword;
            //    string EmployeeHP = Information.EmployeeeHandPhone;
            //    string EmployeePosition = Information.EmployeePosition;

            //    var Go = Context.spMsEmployee_Action(EmployeeId, EmployeeName, EmployeeEmail, EmployeePassword, EmployeeHP, EmployeePosition, "insert");
            //    return Context;
            //}
            return Information;
        }
    }
}

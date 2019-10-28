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
        public List<MemberInformation> MemberInfo()
        {
            using(var Context = new RestaurantkuContext())
            {
                return Context.msmembers.Select(a => new MemberInformation()
                {
                    MemberId = a.memberid,
                    MemberEmail = a.email,
                    MemberName = a.name,
                    MemberPassword = a.password,
                    JoinDate = a.joindate.ToString(),
                    HandPhone = a.handphone,
                    BankName = a.BankName,
                    AccNumber = a.AccNumber,
                    CCNumber = a.CCNumber,
                    Address = a.Address,
                    Deleted = a.Deleted
                    
                }).ToList();
            }
        }
        public List<MenuInformation> MenuInfo()
        {
            using(var Context = new RestaurantkuContext())
            {
                return Context.msmenus.Select(a => new MenuInformation()
                {
                    MenuId = a.menuid,
                    Name = a.name,
                    price = a.price,
                    photo = a.photo,
                    PhotoPath = a.path
                 
                }).ToList();
            }
        }
      
        
    }
}

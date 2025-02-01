using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__adv_04
{

    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee e)
        {
            Staff.Add(e);
            e.EmployeeLayOff += RemoveStaff;
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = (Employee)sender;
            Staff.Remove(emp);
            Console.WriteLine($"Department {DeptName} removed employee {emp.EmployeeID} due to {e.Cause}");
        }
    }
}

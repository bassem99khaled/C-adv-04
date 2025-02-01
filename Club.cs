using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C__adv_04.Program;

namespace C__adv_04
{
    class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee e)
        {
            Members.Add(e);
            e.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = sender as Employee;

            if (e.Cause == LayOffCause.VacationStock && !(sender is BoardMember))
            {
                Members.Remove(emp);
                Console.WriteLine($"Club {ClubName} removed employee {emp.EmployeeID} due to {e.Cause}");
            }
        }
    }
}

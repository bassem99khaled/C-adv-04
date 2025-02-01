using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C__adv_04.Program;

namespace C__adv_04
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        private int requiredTarget;

        public override int VacationStock
        {
            get => throw new InvalidOperationException("SalesPerson doesn't have vacation stock");
            set => throw new InvalidOperationException("SalesPerson doesn't have vacation stock");
        }

        public override void EndOfYearOperation()
        {
         
        }

        public bool CheckTarget(int quota)
        {
            if (AchievedTarget < quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedTarget });
                return false;
            }
            return true;
        }
    }
}

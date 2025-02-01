using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C__adv_04.Program;

namespace C__adv_04
{
    class BoardMember : Employee
    {
        public override int VacationStock
        {
            get => throw new InvalidOperationException("BoardMember doesn't have vacation stock");
            set => throw new InvalidOperationException("BoardMember doesn't have vacation stock");
        }

        public override void EndOfYearOperation()
        {
           
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resignation });
        }
    }
}

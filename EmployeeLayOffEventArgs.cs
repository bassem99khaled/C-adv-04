using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C__adv_04.Program;

namespace C__adv_04
{
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }

}

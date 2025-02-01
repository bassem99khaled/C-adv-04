using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C__adv_04.Program;

namespace C__adv_04
{
    class Employee
    {
    

        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

        private int vacationStock;
        public virtual int VacationStock
        {
            get => vacationStock;
            set => vacationStock = value;
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {
            int requestedDays = (to - from).Days;
            if (VacationStock >= requestedDays)
            {
                VacationStock -= requestedDays;
                return true;
            }
            VacationStock -= requestedDays; // Allowing negative values
            return false;
        }


        public virtual void EndOfYearOperation()
        {
            if (VacationStock < 0)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStock });

            int age = DateTime.Now.Year - BirthDate.Year;
            if (age > 60)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Age });
        }
    }
}

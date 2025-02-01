namespace C__adv_04;
using System;
using System.Collections.Generic;


    internal class Program
    {
    public enum LayOffCause
    {
        VacationStock,
        Age,
        Resignation,
        FailedTarget
    }
    static void Main(string[] args)
        {
        

     
                Department salesDept = new Department { DeptID = 1, DeptName = "Sales" };
                Club socialClub = new Club { ClubID = 1, ClubName = "Social Club" };

                Employee emp1 = new Employee
                {
                    EmployeeID = 1,
                    BirthDate = new DateTime(1950, 1, 1),
                    VacationStock = -5
                };

                SalesPerson emp2 = new SalesPerson
                {
                    EmployeeID = 2,
                    BirthDate = new DateTime(1980, 1, 1)
                };

                BoardMember emp3 = new BoardMember
                {
                    EmployeeID = 3,
                    BirthDate = new DateTime(1940, 1, 1)
                };

                salesDept.AddStaff(emp1);
                salesDept.AddStaff(emp2);
                salesDept.AddStaff(emp3);

                socialClub.AddMember(emp1);
                socialClub.AddMember(emp2);
                socialClub.AddMember(emp3);

                emp1.EndOfYearOperation(); 
                emp2.CheckTarget(100); 
                emp3.Resign();             
      
    }
    }


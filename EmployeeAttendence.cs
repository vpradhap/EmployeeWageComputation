using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUUR = 4;
        int WORKING_DAY_PER_MONTH = 20;
        Random Generate = new Random();
        public void DailyWage()
        {
            int emphrs = 0;
            int dailywage = 0;
            int monthlywage = 0;
            int day =0;
            for  (day=1 ; day <= WORKING_DAY_PER_MONTH; day++)
            {
                int empcheck = Generate.Next(0, 3);

                switch (empcheck)
                {
                    case 0:
                        Console.WriteLine("Employee is Present\nFull Time Employee");
                        emphrs = FULL_DAY_HOUR;
                        break;

                    case 1:
                        Console.WriteLine("Employee is Present\nPart Time Employee");
                        emphrs = PART_TIME_HOUUR;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        emphrs = 0;
                        break;
                }
                dailywage = emphrs * WAGE_PER_HOUR;
                Console.WriteLine("Employee Daily Wage : " + dailywage);
                monthlywage += dailywage; 
            }
            Console.WriteLine("\nEmployee Monthly Wage : " +monthlywage);
        }
    }    
}

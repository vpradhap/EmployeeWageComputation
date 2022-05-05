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
        Random Generate = new Random();
        public void DailyWage()
        {
            int emphrs = 0;
            int dailywage = 0;
            int empcheck = Generate.Next(0, 3);

            if (empcheck == 0)
            {
                Console.WriteLine("Employee is Present\nFull Time Employee");
                emphrs = 8;
            }
            else if (empcheck == 1)
            {
                Console.WriteLine("Employee is Present\nPart Time Employee");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                emphrs = 0;
            }
            dailywage = emphrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage : " + dailywage);
        }
            
    
          

        
    }
}

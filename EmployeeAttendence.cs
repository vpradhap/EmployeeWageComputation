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
        Random Generate = new Random();
        public void DailyWage()
        {
            int emphrs = 0;
            int dailywage = 0;
            int empcheck = Generate.Next(0, 2);

            if (empcheck == 0)
            {
                Console.WriteLine("Employee is Present");
                emphrs = 8;
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

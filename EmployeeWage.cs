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
        int PART_TIME_HOUR = 4;
        int TOTAL_WORKING_DAYS_PER_MONTH = 20;
        int TOTAL_WORKING_HOURS = 100;

        Random Generate = new Random();
        public void employeeWage()
        {
            int emphrs = 0;
            int monthlywage = 0;
            int totalemphrs = 0;
            int day =0;
            int empcheck = 0;
            while  (totalemphrs < TOTAL_WORKING_HOURS && day < TOTAL_WORKING_DAYS_PER_MONTH )
            {
                if (totalemphrs >= (TOTAL_WORKING_HOURS - PART_TIME_HOUR))
                {
                    empcheck = 1;
                }
                else
                {
                    empcheck = Generate.Next(0, 3);

                }

                switch (empcheck)
                {
                    case 0:
                        Console.WriteLine("Employee is Present\nFull Time Employee");
                        emphrs = FULL_DAY_HOUR;
                        break;

                    case 1:
                        Console.WriteLine("Employee is Present\nPart Time Employee");
                        emphrs = PART_TIME_HOUR;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        emphrs = 0;
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("Day:"+day + "\tEmphrs:" + totalemphrs);
                day++;
            }
            monthlywage = totalemphrs * WAGE_PER_HOUR;
            Console.WriteLine("\nTotal Monthly Wage : " +monthlywage);
        }
    }    
}

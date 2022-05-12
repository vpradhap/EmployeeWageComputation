using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;

        Random Generate = new Random();
        public void EmployeeComputation(string company,int wage_per_hour,int workingdayspermonth,int workinghrspermonth)
        {
            int emphrs = 0;
            int monthlywage = 0;
            int totalemphrs = 0;
            int day =1;
            int empcheck = 0;
            Console.WriteLine("\n\tEmployee Wage Computation For The Company : \""+company+"\"");
            while  (totalemphrs < workinghrspermonth && day <= workingdayspermonth )
            {
                if (totalemphrs >= (workinghrspermonth - PART_TIME_HOUR))
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
                        Console.WriteLine("\nEmployee is Present\tFull Time Employee");
                        emphrs = FULL_DAY_HOUR;
                        break;
                    case 1:
                        Console.WriteLine("\nEmployee is Present\tPart Time Employee");
                        emphrs = PART_TIME_HOUR;
                        break;
                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        emphrs = 0;
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("\n\tDay:"+day + "\tEmphrs: " + totalemphrs+" hrs");
                day++;
            }
            monthlywage = totalemphrs * wage_per_hour;
            Console.WriteLine("\n\t--------------< Total Monthly Wage : " +monthlywage+" >----------------");
        }
    }    
}

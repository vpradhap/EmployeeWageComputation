using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageBuilderObject    
    {
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;

        string company;
        int wage_per_hour;
        int workingdayspermonth;
        int workinghrspermonth;
        int monthlywage;
        public EmployeeWageBuilderObject(string company, int wage_per_hour, int workingdayspermonth, int workinghrspermonth)
        {
            this.company = company;
            this.wage_per_hour = wage_per_hour;
            this.workingdayspermonth = workingdayspermonth;
            this.workinghrspermonth = workinghrspermonth;
        }    

        public void EmployeeComputation()
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int day =1;
            int empcheck = 0;
            Console.WriteLine("\n\tEmployee Wage Computation For The Company : \""+company+"\"");
            while  (totalemphrs < workinghrspermonth && day <= workingdayspermonth )
            {
                Random Generate = new Random();

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
            Console.WriteLine("\n--------------< Total Monthly Wage For "+company+ " is : " +monthlywage+" >----------------");
        }

    }    
}

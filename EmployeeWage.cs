using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmployeeWageComputation
{
    public class EmployeeWageBuilder : IEmployeeComputation
    {
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;

        private List<CompanyEmpWage> companyarray;
        public EmployeeWageBuilder()
        {
            this.companyarray = new List<CompanyEmpWage>(); 
        }    
        public void AddCompany(string company, int wage_per_hour, int workingdayspermonth, int workinghrspermonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, wage_per_hour, workingdayspermonth, workinghrspermonth);
            this.companyarray.Add(companyEmpWage);    
        }
        public void EmployeeComputation()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyarray)
            {
                companyEmpWage.TotalEmpWage(this.EmployeeComputation(companyEmpWage));
                Console.WriteLine(companyEmpWage.Output());
            }
        }
        private int EmployeeComputation(CompanyEmpWage companyEmpWage)
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int day =1;
            int empcheck = 0;
            Console.WriteLine("\n\tEmployee Wage Computation For The Company : \""+companyEmpWage.company+"\"");
            while  (totalemphrs < companyEmpWage.workinghrspermonth && day <= companyEmpWage.workingdayspermonth )
            {
                Random Generate = new Random();

                if (totalemphrs >= (companyEmpWage.workinghrspermonth - PART_TIME_HOUR))
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
            return totalemphrs * companyEmpWage.wage_per_hour;
        }
        public int TotalEmpWage(string company)
        {
            foreach(var comp in companyarray)
            {
                if (comp.company == company)
                {
                    return comp.monthlywage;
                }
            }
            return 0;
        }
    }    
}

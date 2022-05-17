using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        public int wage_per_hour;
        public int workingdayspermonth;
        public int workinghrspermonth;
        public int monthlywage;

        public CompanyEmpWage(string company, int wage_per_hour, int workingdayspermonth, int workinghrspermonth)
        {
            this.company = company;
            this.wage_per_hour = wage_per_hour;
            this.workingdayspermonth = workingdayspermonth;
            this.workinghrspermonth = workinghrspermonth;
        }
        public void TotalEmpWage(int monthlywage)
        {
            this.monthlywage = monthlywage;
        }
        public string Output()
        {
            return "\n--------------< Total Monthly Wage For " + this.company + " is : " + this.monthlywage + " >----------------";

        }
    }
}

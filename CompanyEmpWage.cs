using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IEmployeeComputation
    {
        public void AddCompany(string company, int wage_per_hour, int workingdayspermonth, int workinghrspermonth);
        public void EmployeeComputation();
        public int TotalEmpWage(string company);
    }
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
            this.monthlywage = 0;
        }
        public void TotalEmpWage(int monthlywage)
        {
            this.monthlywage = monthlywage;
        }
        public string Output()
        {
            return "\nTotal Monthly Wage : " + this.monthlywage;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeAttendence
    {
        Random Generate = new Random();
        public void CheckPresentOrNot()
        {
            int empcheck = Generate.Next(0,2);
            if (empcheck == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

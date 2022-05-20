using EmployeeWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation");
EmployeeWageBuilder empwagebuilder = new EmployeeWageBuilder();
empwagebuilder.AddCompany("Microsoft",20,30,100);
Console.WriteLine("\n***************************************************************");
empwagebuilder.AddCompany("Tencent", 25, 20, 120);
empwagebuilder.EmployeeComputation();
Console.WriteLine("\n***************************************************************");
Console.WriteLine("\n\tTotal wage for Microsoft company : " + empwagebuilder.TotalEmpWage("Microsoft"));
Console.WriteLine("\n\tTotal wage for Tencent company : " + empwagebuilder.TotalEmpWage("Tencent"));
Console.WriteLine("\n***************************************************************");
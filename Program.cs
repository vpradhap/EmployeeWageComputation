using EmployeeWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation");
EmployeeWageBuilder empwagebuilder = new EmployeeWageBuilder();
empwagebuilder.AddCompany("Microsoft",20,30,100);
Console.WriteLine("\n***************************************************************");
empwagebuilder.AddCompany("Tencent", 25, 20, 120);
empwagebuilder.EmployeeComputation();
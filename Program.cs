using EmployeeWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation");
EmployeeWageBuilderObject microsoft = new EmployeeWageBuilderObject("Microsoft",20,25,100);
EmployeeWageBuilderObject tencent = new EmployeeWageBuilderObject("Tencent",30,20,120);
microsoft.EmployeeComputation();
Console.WriteLine("\n***************************************************************");
tencent.EmployeeComputation();
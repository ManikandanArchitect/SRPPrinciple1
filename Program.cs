using System;

namespace SRPPrinciple1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependency Injection Setup
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            IEmployeeService employeeService = new EmployeeService(employeeRepository);

            Employee employee = new Employee { Name = "Manikandan Arumugam", Salary = 1200000 };
            Console.WriteLine($"Initial Salary : {employee.Salary}");

            //Increase Salary
            employeeService.IncreaseSalary(employee, 100000);
            Console.WriteLine($"Updated Salary :{employee.Salary}");

        }
    }
}

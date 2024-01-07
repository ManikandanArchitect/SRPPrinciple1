//Manikandan Arumugam Created Employee Repsoitory

using System;

public class EmployeeRepository : IEmployeeRepository
{
    

    public void Save(Employee employee)
    {
        Console.WriteLine(employee.Name + " " + employee.Salary);
    }
}
//Manikandan Arumugam Created Employee Service

public class EmployeeService : IEmployeeService
{
    // Its value can only be set during object construction and cannot be changed afterward
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }

    public void IncreaseSalary(Employee employee,decimal amount)
    {
        employee.Salary += amount;

        employeeRepository.Save(employee);
    }
}
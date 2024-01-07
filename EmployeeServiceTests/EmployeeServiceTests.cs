using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeServiceTests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        [TestMethod]
        public void IncreaseSalary_SholudUpdateSalaryAndSaveToRepository()
        {
            //Arrange
            Employee employee = new Employee { Name = "Manikandan Arumugam", Salary = 1000 };
            MockEmployeeRepository mockRepository = new MockEmployeeRepository();
            EmployeeService employeeService = new EmployeeService(mockRepository);


            //Act
            employeeService.IncreaseSalary(employee, 1000);

            //Assert
            Assert.AreEqual(2000, employee.Salary);
            Assert.IsTrue(mockRepository.SaveCalled, "Save method on the repository should have been called");
            Assert.AreEqual(employee, mockRepository.SavedEmployee, "Save method should have been called with the correct employee");
        }
    }


    public class MockEmployeeRepository : IEmployeeRepository
    {
        public bool SaveCalled { get; private set; }
        public Employee SavedEmployee { get; private set; }

        public void Save(Employee employee)
        {
            SaveCalled = true;
            SavedEmployee = employee;
        }
    }
}

using EmployeeApplication.Entities;
using EmployeeApplication.Repository;
using EmployeeApplication.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace EmployeeApplication.ServicesTest
{
    [TestClass]
    public class EmployeeServiceTest
    {
        private Mock<IEmployeeService> mockService = new Mock<IEmployeeService>();
        private Mock<IEmployeeRepository> mockRepository = new Mock<IEmployeeRepository>();
        private readonly List<Employee> employees = new List<Employee>
            {
                new EmployeeHourly() { Id = 1, ContractTypeName = "HourlySalaryEmployee", HourlySalary = 10, Name="Employee 1", RoleId = 1},
                new EmployeeMontly() { Id = 2, ContractTypeName = "MonthlySalaryEmployee", MonthlySalary = 20, Name="Employee 2", RoleId = 1 },
                new EmployeeHourly() { Id = 3, ContractTypeName = "HourlySalaryEmployee", HourlySalary = 30, Name="Employee 3", RoleId = 1 }
            };
        private readonly List<ExternalEmployee> externalEmployees = new List<ExternalEmployee>
            {
                new ExternalEmployee() { Id = 1, ContractTypeName = "HourlySalaryEmployee", HourlySalary = 10, Name="Employee 1", RoleId = 1},
                new ExternalEmployee() { Id = 2, ContractTypeName = "MonthlySalaryEmployee", MonthlySalary = 20, Name="Employee 2", RoleId = 1 },
                new ExternalEmployee() { Id = 3, ContractTypeName = "HourlySalaryEmployee", HourlySalary = 30, Name="Employee 3", RoleId = 1 }
            };
        private readonly Employee employee = new EmployeeHourly() { Id = 1, ContractTypeName = "HourlySalaryEmployee", HourlySalary = 10, Name="Employee 1", RoleId = 1};

        [TestMethod]
        public void GetEmployee()
        {
            //Assemble
            mockService.Setup(x => x.GetEmployees()).Returns(employees);
            mockRepository.Setup(x => x.GetEmployees()).Returns(externalEmployees);
            EmployeeService service = new EmployeeService(mockRepository.Object);

            //Action       
            List<Employee> response = service.GetEmployees();

            //Assert
            Assert.AreEqual(employees.Count, response.Count);
        }

        [TestMethod]
        public void GetEmployeeById()
        {
            //Assemble
            Mock<IEmployeeService> mockService = new Mock<IEmployeeService>();
            mockService.Setup(x => x.GetEmployee(1)).Returns(employee);
            mockRepository.Setup(x => x.GetEmployees()).Returns(externalEmployees);
            EmployeeService service = new EmployeeService(mockRepository.Object);

            //Action          
            Employee response = service.GetEmployee(1);

            //Assert
            Assert.AreEqual(employee.Id, response.Id);
        }

        [TestMethod]
        public void GetEmployeeById_ContractTypeName()
        {
            //Assemble
            Mock<IEmployeeService> mockService = new Mock<IEmployeeService>();
            mockService.Setup(x => x.GetEmployee(1)).Returns(employee);
            mockRepository.Setup(x => x.GetEmployees()).Returns(externalEmployees);
            EmployeeService service = new EmployeeService(mockRepository.Object);

            //Action          
            Employee response = service.GetEmployee(1);

            //Assert
            Assert.AreEqual(employee.ContractTypeName, response.ContractTypeName);
        }

        [TestMethod]
        public void GetEmployeeById_AnnualSalary()
        {
            //Assemble
            Mock<IEmployeeService> mockService = new Mock<IEmployeeService>();
            mockService.Setup(x => x.GetEmployee(1)).Returns(employee);
            mockRepository.Setup(x => x.GetEmployees()).Returns(externalEmployees);
            EmployeeService service = new EmployeeService(mockRepository.Object);

            //Action          
            Employee response = service.GetEmployee(1);

            //Assert
            Assert.AreEqual(employee.AnnualSalary, response.AnnualSalary);
        }
    }
}

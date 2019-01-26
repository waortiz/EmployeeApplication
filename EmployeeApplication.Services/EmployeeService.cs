using EmployeeApplication.Entities;
using EmployeeApplication.Factory;
using EmployeeApplication.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApplication.Service
{
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// Represents a repository for the employee.
        /// </summary>
        private IEmployeeRepository employeeRepository;

        /// <summary>
        /// Constructor of the class.
        /// </summary>
        public EmployeeService()
        {
            this.employeeRepository = new EmployeeRepository();
        }

        /// <summary>
        /// Constructor of the class.
        /// </summary>
        /// <param name="employeeRepository">Repository for the employee.</param>
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Get the employee.
        /// </summary>
        /// <param name="id">Id of the employee to get.</param>
        /// <returns>An employee.</returns>
        public Employee GetEmployee(int id)
        {
            var externalEmployee = employeeRepository.GetEmployees().FirstOrDefault(e => e.Id == id);

            return EmployeeFactory.GetEmployee(externalEmployee);
        }

        /// <summary>
        /// Get all the employees.
        /// </summary>
        /// <returns>List of the employees.</returns>
        public List<Employee> GetEmployees()
        {
            var externalEmployees = employeeRepository.GetEmployees();
            var employess = new List<Employee>();
            foreach (var externalEmployee in externalEmployees)
            {
                employess.Add(EmployeeFactory.GetEmployee(externalEmployee));
            }

            return employess;
        }
    }
}

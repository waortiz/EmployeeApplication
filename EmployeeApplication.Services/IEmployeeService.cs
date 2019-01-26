using EmployeeApplication.Entities;
using System.Collections.Generic;

namespace EmployeeApplication.Service
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Get all the employees stored.
        /// </summary>
        /// <returns>List of the employees.</returns>
        List<Employee> GetEmployees();

        /// <summary>
        /// Get the employee.
        /// </summary>
        /// <param name="id">Id of the employee to get.</param>
        /// <returns>An employee.</returns>
        Employee GetEmployee(int id);
    }
}
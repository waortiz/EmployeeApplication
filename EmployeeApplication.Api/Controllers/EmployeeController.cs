using EmployeeApplication.Entities;
using EmployeeApplication.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeeApplication.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        /// <summary>
        /// Represents a service for the employee.
        /// </summary>
        private IEmployeeService employeeService;

        /// <summary>
        /// Constructor of the controller.
        /// </summary>
        /// <param name="employeeService">Service of the employee.</param>
        public EmployeeController()
        {
            this.employeeService = new EmployeeService();
        }

        /// <summary>
        /// Constructor of the controller.
        /// </summary>
        /// <param name="employeeService">Service of the employee.</param>
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET api/employees
        [Route("api/employees")]
        [HttpGet]
        public List<Employee> Get()
        {
            return employeeService.GetEmployees();
        }

        // GET api/employees/5
        [Route("api/employees/{id}")]
        public Employee Get(int id)
        {
            return employeeService.GetEmployee(id);
        }
    }
}

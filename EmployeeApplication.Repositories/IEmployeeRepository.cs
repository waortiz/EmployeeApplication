using EmployeeApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Repository
{
    public interface IEmployeeRepository
    {
        List<ExternalEmployee> GetEmployees();
    }
}

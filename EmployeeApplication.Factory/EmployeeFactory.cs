using EmployeeApplication.Entities;

namespace EmployeeApplication.Factory
{
    public class EmployeeFactory
    {
        public static Employee GetEmployee(ExternalEmployee externalEmployee)
        {
            Employee employee = null;
            if (externalEmployee != null)
            {
                if (externalEmployee.ContractTypeName == "HourlySalaryEmployee")
                {
                    employee = new EmployeeHourly()
                    {
                        ContractTypeName = externalEmployee.ContractTypeName,
                        Id = externalEmployee.Id,
                        Name = externalEmployee.Name,
                        RoleDescription = externalEmployee.RoleDescription,
                        RoleId = externalEmployee.RoleId,
                        RoleName = externalEmployee.RoleName,
                        HourlySalary = externalEmployee.HourlySalary
                    };
                }
                else if (externalEmployee.ContractTypeName == "MonthlySalaryEmployee")
                {
                    employee = new EmployeeMontly()
                    {
                        ContractTypeName = externalEmployee.ContractTypeName,
                        Id = externalEmployee.Id,
                        Name = externalEmployee.Name,
                        RoleDescription = externalEmployee.RoleDescription,
                        RoleId = externalEmployee.RoleId,
                        RoleName = externalEmployee.RoleName,
                        MonthlySalary = externalEmployee.MonthlySalary
                    };
                }
            }

            return employee;
        }

    }
}

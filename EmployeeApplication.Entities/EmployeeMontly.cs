using Newtonsoft.Json;

namespace EmployeeApplication.Entities
{
    public class EmployeeMontly : Employee 
    {
        /// <summary>
        /// Gets or sets the month salary of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "monthlySalary")]
        public long MonthlySalary { get; set; }

        /// <summary>
        /// Gets or sets the annual salary of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "annualSalary")]
        public new long AnnualSalary { get { return MonthlySalary * 12; } set { } }
    }
}

using Newtonsoft.Json;

namespace EmployeeApplication.Entities
{
    public class EmployeeHourly : Employee 
    {
        /// <summary>
        /// Gets or sets the hourly salary of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "hourlySalary")]
        public long HourlySalary { get; set; }

        /// <summary>
        /// Gets or sets the annual salary of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "annualSalary")]
        public new long AnnualSalary { get { return 120 * HourlySalary * 12; } set { } }
    }
}

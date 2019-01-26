using Newtonsoft.Json;

namespace EmployeeApplication.Entities
{
    public class ExternalEmployee
    {
        /// <summary>
        /// Gets or sets the identifier of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the contract type name of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "contractTypeName")]
        public string ContractTypeName { get; set; }

        /// <summary>
        /// Gets or sets the role id of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role name of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the role description of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "roleDescription")]
        public string RoleDescription { get; set; }

        /// <summary>
        /// Gets or sets the hourly salary of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "hourlySalary")]
        public long HourlySalary { get; set; }

        /// <summary>
        /// Gets or sets the monthly salary of the employee.
        /// </summary>
        [JsonProperty(PropertyName = "monthlySalary")]
        public long MonthlySalary { get; set; }
    }
}

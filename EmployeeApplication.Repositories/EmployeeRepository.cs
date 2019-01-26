using EmployeeApplication.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace EmployeeApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Represents the client rest service for the employee.
        /// </summary>
        private RestClient client;

        /// <summary>
        /// Constructor of the class.
        /// </summary>
        public EmployeeRepository()
        {
            client = new RestClient() { BaseUrl = new Uri(ConfigurationManager.AppSettings["WebApiBaseUrl"]) };
        }

        /// <summary>
        /// Constructor of the class.
        /// </summary>
        /// <param name="baseUrl">Base URL</param>
        public EmployeeRepository(string baseUrl)
        {
            client = new RestClient() { BaseUrl = new Uri(baseUrl) };
        }

        /// <summary>
        /// Get all the employees stored.
        /// </summary>
        /// <returns>List of the employees.</returns>
        public List<ExternalEmployee> GetEmployees()
        {

            RestRequest request = new RestRequest("employees", Method.GET) { RequestFormat = DataFormat.Json };
            IRestResponse<List<ExternalEmployee>> employees = client.Execute<List<ExternalEmployee>>(request);

            return employees.Data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Models;

namespace TekDesk_Server.Acceptance.Tests.Brokers
{
    public partial class EmployeeApiBroker
    {
        private const string EmployeesRelativeUrl = "api/employees";

        public async ValueTask<Employee> PostEmployeeAsync(Employee employee) =>
            await this.apiFactoryClient.PostContentAsync(EmployeesRelativeUrl,employee);

        public async ValueTask<Employee> GetEmployeeByIdAsync(int EmployeeID) =>
            await this.apiFactoryClient.GetContentAsync<Employee>($"{EmployeesRelativeUrl}/{EmployeeID}");

        public async ValueTask<Employee> DeleteEmployeeByIdAsync(int EmployeeID) =>
          await this.apiFactoryClient.DeleteContentAsync<Employee>($"{EmployeesRelativeUrl}/{EmployeeID}");
    }
}

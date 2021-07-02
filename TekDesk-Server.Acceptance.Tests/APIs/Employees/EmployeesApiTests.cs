using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Brokers;
using TekDesk_Server.Acceptance.Tests.Models;
using TekDesk_Server.Controllers;
using Tynamix.ObjectFiller;
using Xunit;

namespace TekDesk_Server.Acceptance.Tests.APIs.Employees
{
    [Collection(nameof(ApiTestCollection))]
   public class EmployeesApiTests
    {
        
        private readonly EmployeeApiBroker employeeApiBroker;

        public EmployeesApiTests(EmployeeApiBroker employeeApiBroker) =>
            this.employeeApiBroker = employeeApiBroker;

        private Employee CreateRandomEmployee() =>
            new Filler<Employee>().Create();

        //[Fact]
        public async Task ShouldPostEmployeeAsync() {
            //Arrange

            Employee randomEmployee = CreateRandomEmployee();
            Employee inputEmployee = randomEmployee;
            Employee expectedEmployee = inputEmployee;

            //Act

            await this.employeeApiBroker.PostEmployeeAsync(inputEmployee);

            Employee actualEmployee =
                await this.employeeApiBroker.GetEmployeeByIdAsync(79);
            //await this.employeeApiBroker.GetEmployeeByIdAsync(inputEmployee.EmployeeID);

            //Assert
            actualEmployee.Should().BeEquivalentTo(expectedEmployee);

            await this.employeeApiBroker.DeleteEmployeeByIdAsync(79);
            //await this.employeeApiBroker.DeleteEmployeeByIdAsync(actualEmployee.EmployeeID);
        }
    }
}

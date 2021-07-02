using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Brokers;
using TekDesk_Server.Acceptance.Tests.Models;
using Tynamix.ObjectFiller;
using Xunit;

namespace TekDesk_Server.Acceptance.Tests.APIs.Queries
{
    [Collection(nameof(ApiTestCollection3))]

    public class QueriesApiTests
    {
        private readonly QueryApiBroker queryApiBroker;

        public QueriesApiTests(QueryApiBroker queryApiBroker) =>
            this.queryApiBroker = queryApiBroker;

        private Query CreateRandomQuery() =>
            new Filler<Query>().Create();

        //[Fact]
        public async Task ShouldPostQueryAsync()
        {
            //Arrange

            Query randomQuery = CreateRandomQuery();
            Query inputQuery = randomQuery;
            Query expectedQuery = inputQuery;

            //Act

            await this.queryApiBroker.PostQueryAsync(inputQuery);

            Query actualQuery =
                await this.queryApiBroker.GetQueryByIdAsync(44);
            //await this.employeeApiBroker.GetEmployeeByIdAsync(inputEmployee.EmployeeID);

            //Assert
            //actualQuery.Should().BeEquivalentTo(expectedQuery);

            await this.queryApiBroker.DeleteQueryByIdAsync(44);
            //await this.employeeApiBroker.DeleteEmployeeByIdAsync(actualEmployee.EmployeeID);
        }

    }
}

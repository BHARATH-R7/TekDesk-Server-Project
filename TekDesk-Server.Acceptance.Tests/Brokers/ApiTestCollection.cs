using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TekDesk_Server.Acceptance.Tests.Brokers
{
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection : ICollectionFixture<EmployeeApiBroker>
    {
    }

    [CollectionDefinition(nameof(ApiTestCollection2))]
    public class ApiTestCollection2 : ICollectionFixture<CategoryApiBroker>
    {
    }

    [CollectionDefinition(nameof(ApiTestCollection3))]
    public class ApiTestCollection3 : ICollectionFixture<QueryApiBroker>
    {
    }

    [CollectionDefinition(nameof(ApiTestCollection4))]
    public class ApiTestCollection4 : ICollectionFixture<SolutionApiBroker>
    {
    }
}

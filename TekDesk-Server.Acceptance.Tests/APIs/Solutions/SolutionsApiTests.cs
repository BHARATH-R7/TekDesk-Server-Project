using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Brokers;
using TekDesk_Server.Acceptance.Tests.Models;
using Tynamix.ObjectFiller;
using Xunit;

namespace TekDesk_Server.Acceptance.Tests.APIs.Employees
{
    [Collection(nameof(ApiTestCollection4))]
    public class SolutionsApiTests
    {
        

        private readonly SolutionApiBroker solutionApiBroker;

        public SolutionsApiTests(SolutionApiBroker solutionApiBroker) =>
            this.solutionApiBroker = solutionApiBroker;

        private Solution CreateRandomSolution() =>
            new Filler<Solution>().Create();

        //[Fact]
        public async Task ShouldPostSolutionAsync()
        {
            //Arrange

            Solution randomSolution = CreateRandomSolution();
            Solution inputSolution = randomSolution;
            Solution expectedSolution = inputSolution;

            //Act

            await this.solutionApiBroker.PostSolutionAsync(inputSolution);

            Solution actualSolution =
                await this.solutionApiBroker.GetSolutionByIdAsync(30);
            //await this.solutionApiBroker.GetSolutionByIdAsync(inputSolution.SolutionID);

            //Assert
            //actualSolution.Should().BeEquivalentTo(expectedSolution);

            await this.solutionApiBroker.DeleteSolutionByIdAsync(30);
            //await this.solutionApiBroker.DeleteSolutionByIdAsync(actualSolution.SolutionID);
        }
    }
}

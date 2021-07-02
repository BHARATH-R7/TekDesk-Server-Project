using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Brokers;
using TekDesk_Server.Acceptance.Tests.Models;
using Tynamix.ObjectFiller;
using Xunit;

namespace TekDesk_Server.Acceptance.Tests.APIs.Categories
{
    [Collection(nameof(ApiTestCollection2))]
    public class CategoriesApiTests
    {
        private readonly CategoryApiBroker categoryApiBroker;

        public CategoriesApiTests(CategoryApiBroker categoryApiBroker) =>
            this.categoryApiBroker = categoryApiBroker;

        private Models.Categories CreateRandomCategory() =>
            new Filler<Models.Categories>().Create();

        //[Fact]
        public async Task ShouldPostCategoryAsync()
        {
            //Arrange

            Models.Categories randomCategory = CreateRandomCategory();
            Models.Categories inputCategory = randomCategory;
            Models.Categories expectedCategory = inputCategory;

            //Act

            await this.categoryApiBroker.PostCategoryAsync(inputCategory);

            Models.Categories actualCategory =
                await this.categoryApiBroker.GetCategoryByIdAsync(73);
            //await this.employeeApiBroker.GetEmployeeByIdAsync(inputCategory.CategoriesID);

            //Assert
            //actualCategory.Should().BeEquivalentTo(expectedCategory);

            await this.categoryApiBroker.DeleteCategoryByIdAsync(73);
            //await this.employeeApiBroker.DeleteEmployeeByIdAsync(actualCategory.CategoriesID);

        }
    }
}

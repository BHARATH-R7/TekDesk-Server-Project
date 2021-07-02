using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Models;

namespace TekDesk_Server.Acceptance.Tests.Brokers
{
    public partial class SolutionApiBroker
    {
        private const string SolutionsRelativeUrl = "api/solutions";

        public async ValueTask<Solution> PostSolutionAsync(Solution solution) =>
            await this.apiFactoryClient.PostContentAsync(SolutionsRelativeUrl, solution);

        public async ValueTask<Solution> GetSolutionByIdAsync(int SolutionID) =>
            await this.apiFactoryClient.GetContentAsync<Solution>($"{SolutionsRelativeUrl}/{SolutionID}");

        public async ValueTask<Solution> DeleteSolutionByIdAsync(int SolutionID) =>
          await this.apiFactoryClient.DeleteContentAsync<Solution>($"{SolutionsRelativeUrl}/{SolutionID}");
    }
}

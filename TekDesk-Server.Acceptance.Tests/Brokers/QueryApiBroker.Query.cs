using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Models;

namespace TekDesk_Server.Acceptance.Tests.Brokers
{
   public partial class QueryApiBroker
    {
        private const string QueriesRelativeUrl = "api/queries";

        public async ValueTask<Query> PostQueryAsync(Query query) =>
            await this.apiFactoryClient.PostContentAsync(QueriesRelativeUrl, query);

        public async ValueTask<Query> GetQueryByIdAsync(int QueryID) =>
            await this.apiFactoryClient.GetContentAsync<Query>($"{QueriesRelativeUrl}/{QueryID}");

        public async ValueTask<Query> DeleteQueryByIdAsync(int QueryID) =>
          await this.apiFactoryClient.DeleteContentAsync<Query>($"{QueriesRelativeUrl}/{QueryID}");
    }
}

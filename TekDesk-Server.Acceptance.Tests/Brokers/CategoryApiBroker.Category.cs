using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekDesk_Server.Acceptance.Tests.Models;

namespace TekDesk_Server.Acceptance.Tests.Brokers
{
   public partial class CategoryApiBroker
    {
        private const string CategoriesRelativeUrl = "api/categories";

        public async ValueTask<Categories> PostCategoryAsync(Categories category) =>
            await this.apiFactoryClient.PostContentAsync(CategoriesRelativeUrl, category);

        public async ValueTask<Categories> GetCategoryByIdAsync(int CategoriesID) =>
            await this.apiFactoryClient.GetContentAsync<Categories>($"{CategoriesRelativeUrl}/{CategoriesID}");

        public async ValueTask<Categories> DeleteCategoryByIdAsync(int CategoriesID) =>
          await this.apiFactoryClient.DeleteContentAsync<Categories>($"{CategoriesRelativeUrl}/{CategoriesID}");
    }
}

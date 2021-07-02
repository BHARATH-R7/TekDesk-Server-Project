using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TekDesk_Server.Models
{
    [ExcludeFromCodeCoverage]
    public class Categories
    {
        [Key]
        public int CategoriesID { get; set; }
        public string CatName { get; set; }
    }
}

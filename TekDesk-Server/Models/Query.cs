using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TekDesk_Server.Models
{
    [ExcludeFromCodeCoverage]
    public class Query
    {
        [Key]
        public int QueryID { get; set; }
        [Required]
        public string QContent { get; set; }
        public string Status { get; set; }
        public string SContent { get; set; }
        public string References { get; set; }
        [Required]
        public int UserofQueryEmployeeID { get; set; }
        [Required]
        public int CategoryCategoriesID { get; set; }
        public Employee UserofQuery { get; set; }
        public Categories Category { get; set; }
    }
}

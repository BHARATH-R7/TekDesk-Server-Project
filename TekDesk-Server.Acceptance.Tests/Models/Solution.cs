using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TekDesk_Server.Acceptance.Tests.Models
{
    public class Solution
    {
        //[Key]
        //public int SolutionID { get; set; }
        [Required]
        public string sContent { get; set; }
        public string references { get; set; }
        [Required]
        public int SolutionForQueryID { get; set; }
        public Query SolutionForQuery { get; set; }
    }
}

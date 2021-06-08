using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TekDesk_Server.Models;

namespace TekDesk_Server.Data
{
    public class TekDesk_ServerContext : DbContext
    {
        public TekDesk_ServerContext (DbContextOptions<TekDesk_ServerContext> options)
            : base(options)
        {
        }

        public DbSet<TekDesk_Server.Models.Employee> Employee { get; set; }

        public DbSet<TekDesk_Server.Models.Categories> Categories { get; set; }

        public DbSet<TekDesk_Server.Models.Query> Query { get; set; }

        public DbSet<TekDesk_Server.Models.Solution> Solution { get; set; }
    }
}

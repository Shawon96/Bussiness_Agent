using Business_Agent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Agent.Infrastructure
{
    public class BussinessClientDbContext :DbContext
    {
        public BussinessClientDbContext() : base("BussinessClientConnectionString")
        {
        }
        public DbSet<CreateAgent> createAgents { set; get; }
    }
}

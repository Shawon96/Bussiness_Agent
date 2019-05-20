using Business_Agent.Core.Entities;
using Business_Agent.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Agent.Core.Service
{
    public class AgentService :ServiceBase<CreateAgent>, IAgentService
    {
        public AgentService(DbContext context) : base(context) { }
    }
}

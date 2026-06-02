using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFlow.Infrastructure.Entities;

namespace TalentFlow.Infrastructure
{
    public class TalentFlowDbContext : IdentityDbContext<ApplicationUser>
    {
        public TalentFlowDbContext(DbContextOptions<TalentFlowDbContext> options) : base(options) { }
    }
}

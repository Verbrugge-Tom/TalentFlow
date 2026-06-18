using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFlow.Domain.Entities
{
    public class Platform
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? WebsiteUrl { get; set; }
        public ICollection<Audition> Auditions { get; set; } = new List<Audition>();
    }
}

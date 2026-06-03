using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFlow.Domain.Enums;

namespace TalentFlow.Domain.Entities
{
    public class Audition
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string? Role { get; set; }
        public string? Language { get; set; }
        public string? ClientName { get; set; }
        public bool CustomAuditionRequired { get; set; }
        public AuditionStatus Status { get; set; } = AuditionStatus.Interested;
        public DateTime? Deadline { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
        public Guid? PlatformId { get; set; }
        public Platform? Platform { get; set; }
        public ICollection<AuditionFile> AuditionFiles { get; set; } = new List<AuditionFile>();
    }
}

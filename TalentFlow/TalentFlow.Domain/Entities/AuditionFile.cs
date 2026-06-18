using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFlow.Domain.Enums;

namespace TalentFlow.Domain.Entities
{
    public class AuditionFile
    {
        public Guid Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public AuditionFileType FileType { get; set; } = AuditionFileType.Other;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
        public Guid AuditionId { get; set; }
        public Audition Audition { get; set; } = null!;
    }
}

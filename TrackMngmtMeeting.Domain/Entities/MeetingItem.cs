using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.BaseEntity;

namespace TrackMngmtMeeting.Domain.Entities
{
    public class MeetingItem : BaseEntity<int>
    {
        public string Description { get; set; } = string.Empty;
        public int MeetingId { get; set; }
        public int StatusId { get; set; }
        [JsonIgnore]
        public virtual Meeting? Meeting { get; set; }
        public virtual Status? Status { get; set; }
        public virtual List<ActionItem>? ActionItems { get; set; }
        public virtual List<MeetingItemHistory>? MeetingItemHistory { get; set; }
    }
}
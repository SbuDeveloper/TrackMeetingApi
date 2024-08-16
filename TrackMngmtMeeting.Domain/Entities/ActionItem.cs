using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.BaseEntity;

namespace TrackMngmtMeeting.Domain.Entities
{
    public class ActionItem : BaseEntity<int>
    {
        public string Description { get; set; } = string.Empty;
        public int MeetingItemId { get; set; }
        public virtual MeetingItem? MeetingItem { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.BaseEntity;

namespace TrackMngmtMeeting.Domain.Entities
{
    public class Meeting : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public int MeetingTypeId { get; set; }
        public virtual MeetingType? MeetingType { get; set; }
        public virtual ICollection<MeetingItem>? MeetingItems { get; set; }

    }
}
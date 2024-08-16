using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.BaseEntity;

namespace TrackMngmtMeeting.Domain.Entities
{
    public class MeetingItemHistory : BaseEntity<int>
    {
        public int StatusId { get; set; }
        public int MeetingItemId { get; set; }
        public virtual Status? Status { get; set; }
        public virtual MeetingItem? MeetingItem { get; set; }
    }
}
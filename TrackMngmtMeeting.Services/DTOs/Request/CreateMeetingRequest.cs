using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Entities;

namespace TrackMngmtMeeting.Services.DTOs.Request
{
    public class CreateMeetingRequest
    {
        public string? Name { get; set; }
        public int MeetingTypeId { get; set; }
        public virtual ICollection<MeetingItemDto>? MeetingItems { get; set; }
        public virtual ICollection<MeetingItemHistoryDto>? MeetingItemHistory { get; set; }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMngmtMeeting.Services.DTOs.Request
{
    public class UpdateMeetingItemStatusRequest
    {
        public int MeetingItemId { get; set; }
        public int StatusId { get; set; }
    }
}
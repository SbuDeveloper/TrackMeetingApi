using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMngmtMeeting.Services.DTOs.Response
{
    public class CreateMeetingResponse
    {
        public MeetingDto? MeetingDto { get; set; }
        public List<MeetingItemsResponse>? MeetingItemsResponses { get; set; }
    }
}
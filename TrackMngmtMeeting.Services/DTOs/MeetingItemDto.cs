using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMngmtMeeting.Services.DTOs
{
    public class MeetingItemDto
    {
        public string Description { get; set; } = string.Empty;
        public StatusDto? Status { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Entities;

namespace TrackMngmtMeeting.Services.DTOs.Response
{
    public class MeetingItemsResponse
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? MeetingType { get; set; }
        public string? Meeting { get; set; }
        public string? Status { get; set; }
        public ICollection<ActionItemDto>? ActionItems { get; set; }
        public virtual ICollection<MeetingItemHistoryDto>? MeetingItemHistory { get; set; }
    }
}
namespace TrackMngmtMeeting.Services.DTOs.Request
{
    public class CreateMeetingRequest
    {
        public string? Name { get; set; }
        public int MeetingTypeId { get; set; }
        public ICollection<MeetingItemDto>? MeetingItems { get; set; }
    }
}




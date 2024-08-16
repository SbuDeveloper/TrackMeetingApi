namespace TrackMngmtMeeting.Services.DTOs.Response
{
    public class MeetingResponse
    {
        public string Name { get; set; } = string.Empty;
        public string? MeetingType { get; set; }
        public List<MeetingItemDto>? MeetingItems { get; set; }
    }
}
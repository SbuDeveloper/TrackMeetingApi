namespace TrackMngmtMeeting.Services.DTOs
{
    public class MeetingDto
    {
         public string Name { get; set; } = string.Empty;
        public int MeetingTypeId { get; set; }
        public MeetingTypeDto? MeetingType { get; set; }
        public ICollection<MeetingItemDto>? MeetingItems { get; set; }
    }
}
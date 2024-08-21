namespace TrackMngmtMeeting.Services.DTOs
{
    public class MeetingItemDto
    {
        public string Description { get; set; } = string.Empty;
        public int StatusId { get; set; }
        public StatusDto? Status { get; set; }
        public virtual ICollection<ActionItemDto>? ActionItems { get; set; }
        public ICollection<MeetingItemHistoryDto>? MeetingItemHistory { get; set; }
    }
}
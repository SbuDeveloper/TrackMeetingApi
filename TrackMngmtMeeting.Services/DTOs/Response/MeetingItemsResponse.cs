namespace TrackMngmtMeeting.Services.DTOs.Response
{
    public class MeetingItemsResponse
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int StatusId { get; set; }
        public MeetingDto? Meeting { get; set; }
        public StatusDto? Status { get; set; }
        public ICollection<ActionItemDto>? ActionItems { get; set; }
        public virtual ICollection<MeetingItemHistoryDto>? MeetingItemHistory { get; set; }
    }
}
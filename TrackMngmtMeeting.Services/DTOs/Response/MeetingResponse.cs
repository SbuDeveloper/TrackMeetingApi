using System.ComponentModel.DataAnnotations;

namespace TrackMngmtMeeting.Services.DTOs.Response
{
    public class MeetingResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedOn { get; set; }
        public MeetingTypeDto? MeetingType { get; set; }
        public List<MeetingItemDto>? MeetingItems { get; set; }
    }
}
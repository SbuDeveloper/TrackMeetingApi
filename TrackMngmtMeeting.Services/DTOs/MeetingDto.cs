using System.ComponentModel.DataAnnotations;

namespace TrackMngmtMeeting.Services.DTOs
{
    public class MeetingDto
    {
         public string Name { get; set; } = string.Empty;
        public int MeetingTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public MeetingTypeDto? MeetingType { get; set; }
    }
}
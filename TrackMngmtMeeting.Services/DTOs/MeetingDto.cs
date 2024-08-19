using System.ComponentModel.DataAnnotations;

namespace TrackMngmtMeeting.Services.DTOs
{
    public class MeetingDto
    {
        public int Id { get; set; }
         public string Name { get; set; } = string.Empty;
        public int MeetingTypeId { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedOn { get; set; }
        public MeetingTypeDto? MeetingType { get; set; }
    }
}
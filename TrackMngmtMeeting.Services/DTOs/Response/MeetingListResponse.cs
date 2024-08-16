using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMngmtMeeting.Services.DTOs.Response
{
    public class MeetingListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public  string? MeetingType { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedOn { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime UpdatedOn { get; set; }
    }
}
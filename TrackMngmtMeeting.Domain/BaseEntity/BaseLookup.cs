using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMngmtMeeting.Domain.BaseEntity
{
    public class BaseLookup
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMngmtMeeting.Domain.BaseEntity
{
    public class BaseEntity<TKey>
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public TKey? Id { get; set; }
		[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime CreatedOn { get; init; } = DateTime.UtcNow;
		[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
		public bool IsActive { get; set; } = true;
		public bool Deleted { get; set; } = false;

	}
}
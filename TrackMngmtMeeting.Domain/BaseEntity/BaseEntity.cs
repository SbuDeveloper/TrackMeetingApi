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
		public DateTime CreatedOn { get; init; } = DateTime.UtcNow;
		public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
		public bool IsActive { get; set; } = true;
		public bool Deleted { get; set; } = false;

	}
}
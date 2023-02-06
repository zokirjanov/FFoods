using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Commons
{
	public class Auditable : BaseEntity
	{
		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}

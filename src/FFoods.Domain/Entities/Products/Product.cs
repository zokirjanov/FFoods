using FFoods.Domain.Commons;
using FFoods.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Products
{
	public class Product : Auditable
	{
		public long CategoryId { get; set; }
		public virtual Category Category { get; set; } = default!;
		public string ProductName { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string ImagePath { get; set; } = string.Empty;
		public double Price { get; set; }
	}
}

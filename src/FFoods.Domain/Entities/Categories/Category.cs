using FFoods.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Categories;

public class Category : BaseEntity
{
	public string CategoryName { get; set; } = string.Empty;
}

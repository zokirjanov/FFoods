using FFoods.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Products
{
    public class ProductDiscount : Auditable
    {
        public long ProductId { get; set; }
        public virtual Product Product { get; set; } = default!;

        public double Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; } = String.Empty;
    }
}

using FFoods.Domain.Commons;
using FFoods.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Orders;
public class OrderDetail :  Auditable
{
    public long OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public long ProductId { get; set; }
    public virtual Product Product { get; set; } = default!;

    public int Amount { get; set; }

    public double Price { get; set; }
}

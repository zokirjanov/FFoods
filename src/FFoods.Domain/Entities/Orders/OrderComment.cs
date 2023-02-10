using FFoods.Domain.Commons;
using FFoods.Domain.Entities.Employee;
using FFoods.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Ordersl;

public class OrderComment : Auditable
{
    public long OperatorId { get; set; }
    public virtual Operator Operator { get; set; } = default!;

    public long OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public string Comment { get; set; } = String.Empty;
}

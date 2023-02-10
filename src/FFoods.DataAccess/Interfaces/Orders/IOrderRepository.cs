using FFoods.Domain.Entities.Orders;
using FFoods.Domain.Entities.Ordersl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Interfaces.Orders
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}

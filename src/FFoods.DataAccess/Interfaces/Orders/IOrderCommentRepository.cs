using FFoods.Domain.Entities.Ordersl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Interfaces.Orders
{
    public interface IOrderCommentRepository : IRepository<OrderComment>
    {
        IQueryable<OrderComment> GetAll(long orderId);
    }
}

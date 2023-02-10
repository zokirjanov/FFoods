using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Orders;
using FFoods.DataAccess.Repositories;
using FFoods.Domain.Entities.Ordersl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Repositories.Orders;

public class OrderCommentRepository : GenericRepository<OrderComment>, IOrderCommentRepository
{
    public OrderCommentRepository(AppDbContext context) : base(context)
    {
    }
    public IQueryable<OrderComment> GetAll(long orderId)
    {
        throw new NotImplementedException();
    }
}

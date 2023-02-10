using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Orders;
using FFoods.Domain.Entities.Orders;
using FFoods.Domain.Entities.Ordersl;

namespace FFoods.DataAccess.Repositories.Orders;


public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(AppDbContext context) : base(context)
    {
    }

    public IQueryable<OrderComment> GetAll(long orderId)
    => (IQueryable<OrderComment>)_dbSet.Where(x => x.OrderId == orderId);
}
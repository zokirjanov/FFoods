using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Orders;
using FFoods.DataAccess.Repositories;
using FFoods.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Repositories.Orders;

public class OrderRepository: GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context) : base(context)
    {
    }
}

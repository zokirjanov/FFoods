using FFoods.DataAccess.Interfaces.Categories;
using FFoods.DataAccess.Interfaces.Employees;
using FFoods.DataAccess.Interfaces.Orders;
using FFoods.DataAccess.Interfaces.Products;
using FFoods.DataAccess.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        public ICategoryRepository Categories { get; }

        public IAdminstratorRepository Administrators { get; }
        public IDeliverRepository Delivers { get; }
        public IOperatorRepository Operators { get; }

        public IOrderCommentRepository OrderComments { get; }
        public IOrderDetailRepository OrderDetails { get; }
        public IOrderRepository Orders { get; }

        public IProductRepository Products { get; }
        public IProductCommentRepository ProductComments { get; }
        public IProductDiscountRepository ProductDiscounts { get; }

        public IUserRepository Users { get; }

        public Task<int> SaveChangesAsync();
    }
}

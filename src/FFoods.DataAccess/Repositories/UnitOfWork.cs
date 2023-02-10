using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Categories;
using FFoods.DataAccess.Interfaces.Employees;
using FFoods.DataAccess.Interfaces.Orders;
using FFoods.DataAccess.Interfaces.Products;
using FFoods.DataAccess.Interfaces.Users;
using FFoods.DataAccess.Interfaces;
using FFoods.DataAccess.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFoods.DataAccess.Repositories.Employees;
using FFoods.DataAccess.Repositories.Orders;
using FFoods.DataAccess.Repositories.Users;
using FFoods.DataAccess.Repositories.Products;

namespace FFoods.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;
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

    public UnitOfWork(AppDbContext appDbContext)
    {
        this.dbContext = appDbContext;
        Categories = new CategoryRepository(appDbContext);

        Administrators = new AdministratorRepository(appDbContext);
        Delivers = new DeliverRepository(appDbContext);
        Operators = new OperatorRepository(appDbContext);

        Orders = new OrderRepository(appDbContext);
        OrderDetails = new OrderDetailRepository(appDbContext);
        OrderComments = new OrderCommentRepository(appDbContext);

        ProductDiscounts = new ProductDiscountRepository(appDbContext);
        ProductComments = new ProductCommentRepository(appDbContext);
        Products = new ProductRepository(appDbContext);

        Users = new UserRepository(appDbContext);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}

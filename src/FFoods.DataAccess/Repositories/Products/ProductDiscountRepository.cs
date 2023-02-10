using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Products;
using FFoods.Domain.Entities.Products;

namespace FFoods.DataAccess.Repositories.Products;

public class ProductDiscountRepository : GenericRepository<ProductDiscount>, IProductDiscountRepository
{
    public ProductDiscountRepository(AppDbContext context) : base(context)
    {
    }
}

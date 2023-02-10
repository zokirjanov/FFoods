using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Products;
using FFoods.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Repositories.Products;

public class ProductCommentRepository : GenericRepository<ProductComment>, IProductCommentRepository
{
    public ProductCommentRepository(AppDbContext context) : base(context)
    {
    }

    public IQueryable<ProductComment> GetAll(long productId)
        => _dbcontext.ProductComments.Where(productComment => productComment.ProductId == productId);
}

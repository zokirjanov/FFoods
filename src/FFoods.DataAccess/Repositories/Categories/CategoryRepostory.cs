using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Categories;
using FFoods.DataAccess.Repositories;
using FFoods.Domain.Entities.Categories;

namespace FFoods.DataAccess.Repositories.Categories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}

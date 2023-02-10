using FFoods.Domain.Commons;
using System.Linq.Expressions;

namespace FFoods.DataAccess.Interfaces;

public interface IGenericRepository<T> : IRepository<T> where T : BaseEntity
{
    public IQueryable<T> GetAll();

    public IQueryable<T> Where(Expression<Func<T, bool>> expression);
}
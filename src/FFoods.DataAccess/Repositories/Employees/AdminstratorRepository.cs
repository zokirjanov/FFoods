using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Employees;
using FFoods.DataAccess.Repositories;
using FFoods.Domain.Entities.Employee;

namespace FFoods.DataAccess.Repositories.Employees;

public class AdministratorRepository : GenericRepository<Adminstrator>,
    IAdminstratorRepository
{
	public AdministratorRepository(AppDbContext context) : base(context)
    {
			
	}
}

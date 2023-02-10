using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces.Employees;
using FFoods.DataAccess.Repositories;
using FFoods.Domain.Entities.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.DataAccess.Repositories.Employees;

public class OperatorRepository : GenericRepository<Operator>,
IOperatorRepository
{
    public OperatorRepository(AppDbContext context) : base(context)
    {
    }
}

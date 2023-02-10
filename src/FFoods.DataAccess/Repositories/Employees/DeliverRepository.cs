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

public class DeliverRepository : GenericRepository<Deliver>,
    IDeliverRepository
{
    public DeliverRepository(AppDbContext context) : base(context)
    {
    }
}
using FFoods.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Users
{
    public class User : Person
    {
        public string PasswordHash { get; set; } = String.Empty;

        public string Salt { get; set; } = String.Empty;
    }
}

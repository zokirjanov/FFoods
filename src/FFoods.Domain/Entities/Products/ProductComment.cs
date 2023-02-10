using FFoods.Domain.Commons;
using FFoods.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Products
{
    public class ProductComment : Auditable
    {
        public long UserId { get; set; }

        public virtual User User { get; set; } = default!;

        public long ProductId { get; set; }

        public virtual Product Product { get; set; } = default!;

        public string Comment { get; set; } = String.Empty;

        public bool Updated { get; set; } = false;
    }
}

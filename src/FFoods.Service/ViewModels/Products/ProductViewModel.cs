using FFoods.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Service.ViewModels.Products;

public class ProductViewModel : ProductBaseViewModel
{
   
    public string Description { get; set; } = string.Empty;

    public virtual Category Category { get; set; } = default!;
}

using FFoods.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Service.ViewModels.Products
{
    public class ProductBaseViewModel
    {
        public long Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public double OriginalPrice { get; set; }

        public double DiscountPrice { get; set; }

        public double ResultPrice { get; set; }

        public string ImagePath { get; set; } = string.Empty;



    }
}

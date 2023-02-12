using FFoods.Service.Commons.Utils;
using FFoods.Service.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Service.Interfaces.Products;

public interface IProductsService
{
    public Task<IEnumerable<ProductBaseViewModel>> GetAllAsync(PaginationParams @params);

    public Task<ProductViewModel> GetAsync(long productId);
}

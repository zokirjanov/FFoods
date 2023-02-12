using FFoods.DataAccess.Interfaces;
using FFoods.Domain.Entities.Products;
using FFoods.Service.Commons.Helpers;
using FFoods.Service.Commons.Utils;
using FFoods.Service.Interfaces.Products;
using FFoods.Service.ViewModels.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Service.Services.Products;

public class ProductService : IProductsService
{
    private readonly IUnitOfWork _repository;

    public ProductService(IUnitOfWork unitOfWork)
    {
        this._repository = unitOfWork;
    }
    public async Task<IEnumerable<ProductBaseViewModel>> GetAllAsync(PaginationParams @params)
    {
        var query = from product in _repository.Products.GetAll()
                    let discountPrice = _repository.ProductDiscounts.GetAll().Where(discount =>
                        discount.StartDate < TimeHelper.GetCurrentServerTime()
                        && discount.EndDate > TimeHelper.GetCurrentServerTime()
                        && discount.ProductId == product.Id).Sum(x => x.Price)
                    orderby product.CreatedAt descending

                    select new ProductBaseViewModel()
                    {
                        Id = product.Id,
                        ProductName = product.ProductName,
                        ImagePath = product.ImagePath,
                        OriginalPrice = product.Price,
                        DiscountPrice = discountPrice,
                        ResultPrice = product.Price - discountPrice
                    };
        return await query.Skip((@params.PageNumber - 1) * @params.PageSize)
                         .Take(@params.PageSize).AsNoTracking()
                         .ToListAsync();
    }

    public async Task<ProductViewModel> GetAsync(long productId)
    {
        var product = await _repository.Products.GetAll().Include(x =>
            x.Category).FirstOrDefaultAsync(product => product.Id == productId);
        if (product is null) throw new Exception("not found");

        double discount = _repository.ProductDiscounts.GetAll().Where(discount =>
                        discount.StartDate < TimeHelper.GetCurrentServerTime()
                        && discount.EndDate > TimeHelper.GetCurrentServerTime()
                        && discount.ProductId == product.Id).Sum(x => x.Price);

        return new ProductViewModel()
        {
            Id = product.Id,
            ProductName = product.ProductName,
            ImagePath = product.ImagePath,
            OriginalPrice = product.Price,
            DiscountPrice = discount,
            ResultPrice = product.Price - discount,
            Category = product.Category,
            Description = product.Description
        };
    }
}

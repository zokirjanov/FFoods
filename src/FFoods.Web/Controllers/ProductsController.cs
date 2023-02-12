using FFoods.Service.Commons.Utils;
using FFoods.Service.Interfaces.Products;
using FFoods.Service.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace FFoods.Web.Controllers;
[Route("products")]

public class ProductsController : Controller
{
	private readonly IProductsService _service;
	private readonly int _pageSize =30;

	public ProductsController(IProductsService service)
	{
		this._service = service;
	}
	public async Task<IActionResult> Index(int page=1)
	{
		var products = await _service.GetAllAsync(new PaginationParams(page, _pageSize));
		return View("Index", products);
	}

    [HttpGet("{productId}")]
    public async Task<ViewResult> GetAsync(long productId)
    {
        var product = await _service.GetAsync(productId);
        return View(product);
    }

}

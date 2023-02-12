using FFoods.Service.Interfaces.Products;
using FFoods.Service.Services.Products;
using System.Runtime.CompilerServices;

namespace FFoods.Web.Configurations.LayerConfigurations;

public static class ServiceLayerConfigurations
{
    public static void AddService(this IServiceCollection service)
    {
        service.AddScoped<IProductsService, ProductService>();
    }
}

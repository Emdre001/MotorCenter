using System.Drawing;


namespace Motorcenter.Data.Services;

public class VehicleDbService(MotorcenterContext db, IMapper mapper) : DbService(db, mapper)
{

    //public override async Task<List<TDto>> GetAsync<TEntity, TDto>()
    //{
    //    IncludeNavigationsFor<Filter>();
    //    IncludeNavigationsFor<Color>();
    //    var result = await base.GetAsync<TEntity, TDto>();
    //    ////        return result;

    //}

    //public async Task<List<VGetDTO>> GetProductsByCategoryAsync(int categoryId)
    //{
    //    IncludeNavigationsFor<Color>();
    //    IncludeNavigationsFor<Size>();
    //    var productIds = GetAsync<ProductCategory>(pc => pc.CategoryId.Equals(categoryId))
    //        .Select(pc => pc.ProductId);
    //    var products = await GetAsync<Product>(p => productIds.Contains(p.Id)).ToListAsync();
    //    return MapList<Product, ProductGetDTO>(products);
    //}




}



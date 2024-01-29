namespace Motorcenter.Data.Services;

public class TypeDbService(MotorcenterContext db, IMapper mapper) : DbService(db, mapper)
{
    public override async Task<List<TDto>> GetAsync<TEntity, TDto>()
    {
        //IncludeNavigationsFor<Filter>();
        //IncludeNavigationFor<Vehicle>();
        var result = await base.GetAsync<TEntity, TDto>();
        return result;
    }

}
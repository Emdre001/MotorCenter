
using Motorcenter.API.DTO;
using Motorcenter.Data.Entities;
using System.Drawing;

namespace Motorcenter.Data.Services;

public class VehicleDbService(MotorcenterContext db, IMapper mapper) : DbService(db, mapper)
{

    public override async Task<List<TDto>> GetAsync<TEntity, TDto>()
    {
        var result = await base.GetAsync<TEntity, TDto>();
                return result;
    }

    public async Task<List<VehicleGetDTO>> GetVehiclesByTypeAsync(int typeId)
    {
        IncludeNavigationsFor<Entities.Color>();
        IncludeNavigationsFor<Year>();
        var VehicleIds = GetAsync<Vehicle>(pc => pc.TypeId.Equals(typeId))
            .Select(pc => pc.TypeId);
        var vehicles = await GetAsync<Vehicle>(p => VehicleIds.Contains(p.Id)).ToListAsync();
        return MapList<Vehicle, VehicleGetDTO>(vehicles);
    }

    public List<TDto> MapList<TEntity, TDto>(List<TEntity> entities)
    where TEntity : class
    where TDto : class
    {
        return mapper.Map<List<TDto>>(entities);
    }
}

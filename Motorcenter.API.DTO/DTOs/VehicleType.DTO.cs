using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;
// DTO-klass för att överföra data om kopplingen mellan VehicleType, Brand och Vehicle
public class VehicleTypeDTO
{
    // BrandId representerar id för ett varumärke (Brand)
    public int BrandId { get; set; }

    // VehicleId representerar id för ett fordon (Vehicle)
    public int VehicleId { get; set; }
}



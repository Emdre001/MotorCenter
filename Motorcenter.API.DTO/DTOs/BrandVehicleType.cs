using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

// DTO-klass för att överföra data om kopplingen mellan Brand och VehicleType
public class BrandVehicleTypeDTO
{
    // BrandId representerar id för ett varumärke (Brand)
    public int BrandId { get; set; }

    // VehicleTypeId representerar id för en fordonstyp (VehicleType)
    public int VehicleTypeId { get; set; }
}


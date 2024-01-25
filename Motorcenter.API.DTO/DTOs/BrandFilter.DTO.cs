using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;
// DTO-klass för att överföra data om kopplingen mellan Brand och Filter
public class BrandFilterDTO
{
    // FilterId representerar id för ett filter
    public int FilterId { get; set; }

    // BrandId representerar id för ett varumärke (Brand)
    public int BrandId { get; set; }
}

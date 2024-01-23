using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

public class YearPostDTO
{

    public string Name { get; set; }

}

public class YearPutDTO :YearPostDTO
{
    public int Id { get; set; }
}

public class YearGetDTO : YearPutDTO
{

}




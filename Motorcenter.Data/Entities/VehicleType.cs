using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.Data.Entities;

public class VehicleType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Suv { get; set; }

    public string Sedan { get; set; }

    public string Kombi { get; set; }

    public string Van { get; set; }


    public List<Brand> Brands  { get; set; }

    public int VehicleId {  get; set; }

    public Vehicle Vehicle { get; set; } 

    public List<Filter> Filters { get; set; }
   
}

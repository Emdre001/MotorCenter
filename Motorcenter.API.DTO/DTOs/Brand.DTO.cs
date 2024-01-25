using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs
{
    // DTO (Data Transfer Object) för att skapa en ny Brand
    public class BrandPostDTO
    {
        // Namnet på varumärket som ska skapas, standardvärdet är en tom sträng
        public string Name { get; set; } = string.Empty;
    }

    // DTO för att uppdatera befintligt Brand, ärver från BrandPostDTO för att återanvända egenskaper
    public class BrandPutDTO : BrandPostDTO
    {
        // Id för det befintliga varumärket som ska uppdateras
        public int Id { get; set; }
    }

    // DTO för att hämta information om ett Brand, ärver från BrandPutDTO för att inkludera Id och andra egenskaper
    public class BrandGetDTO : BrandPutDTO
    {
        // En lista av VehicleGetDTO, vilket är ett annat DTO för att hämta information om fordon associerade med varumärket
        public List<VehicleGetDTO>? Vehicles { get; set; }
    }
}




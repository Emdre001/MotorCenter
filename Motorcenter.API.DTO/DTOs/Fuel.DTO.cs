using Motorcenter.API.DTO.DTOs;
using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

// DTO-klass för att skapa en ny Fuel (bränsletyp)
public class FuelPostDTO
{
    // Namnet på bränsletypen som ska skapas, standardvärdet är en tom sträng
    public string Name { get; set; } = string.Empty;

    // Typ av bränsletyp, standardvärdet är en tom sträng
    public string TypeName { get; set; } = string.Empty;

    // OptionType representerar typen av alternativ för bränsletypen
    public OptionType OptionType { get; set; }
}

// DTO-klass för att uppdatera befintlig Fuel, ärver från FuelPostDTO för att återanvända egenskaper
public class FuelPutDTO : FuelPostDTO
{
    // Id för den befintliga bränsletypen som ska uppdateras
    public int Id { get; set; }
}

// DTO-klass för att hämta information om en Fuel, ärver från FuelPutDTO för att inkludera Id och andra egenskaper
public class FuelGetDTO : FuelPutDTO
{
    // Inga ytterligare egenskaper, ärver från FuelPutDTO för att inkludera Id och andra egenskaper
}


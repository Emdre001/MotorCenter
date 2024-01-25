using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;
// DTO-klass för att skapa en ny Mileage (körsträcka)
public class MileagePostDTO
{
    // Namnet på körsträckan som ska skapas, standardvärdet är en tom sträng
    public string Name { get; set; } = string.Empty;

    // Intervall eller omfång för körsträckan
    public string Range { get; set; }

    // OptionType representerar typen av alternativ för körsträckan
    public OptionType OptionType { get; set; }
}

// DTO-klass för att uppdatera befintlig Mileage, ärver från MileagePostDTO för att återanvända egenskaper
public class MileagePutDTO : MileagePostDTO
{
    // Id för den befintliga körsträckan som ska uppdateras
    public int Id { get; set; }
}

// DTO-klass för att hämta information om en Mileage, ärver från MileagePutDTO för att inkludera Id och andra egenskaper
public class MileageGetDTO : MileagePutDTO
{
    // Inga ytterligare egenskaper, ärver från MileagePutDTO för att inkludera Id och andra egenskaper
}


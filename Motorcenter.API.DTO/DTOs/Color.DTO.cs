using Motorcenter.Data.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcenter.API.DTO.DTOs;

// DTO-klass för att skapa en ny Color
public class ColorPostDTO
{
    // Namnet på färgen som ska skapas, standardvärdet är en tom sträng
    public string Name { get; set; } = string.Empty;

    // OptionType representerar typen av alternativ för färgen
    public OptionType OptionType { get; set; }

    // IsSelected indikerar om färgen är vald eller inte
    public bool IsSelected { get; set; }
}

// DTO-klass för att uppdatera befintlig Color, ärver från ColorPostDTO för att återanvända egenskaper
public class ColorPutDTO : ColorPostDTO
{
    // Id för den befintliga färgen som ska uppdateras
    public int Id { get; set; }
}

// DTO-klass för att hämta information om en Color, ärver från ColorPutDTO för att inkludera Id och andra egenskaper
public class ColorGetDTO : ColorPutDTO
{
    // Inga ytterligare egenskaper, ärver från ColorPutDTO för att inkludera Id och andra egenskaper
}


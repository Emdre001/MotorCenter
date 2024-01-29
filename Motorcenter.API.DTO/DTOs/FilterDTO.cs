namespace Motorcenter.API.DTO;

// DTO-klass för att skapa en ny Filter
public class FilterPostDTO
{
    // Namnet på filtret som ska skapas, standardvärdet är en tom sträng
    public string Name { get; set; } = string.Empty;

    // Typ av filter, standardvärdet är en tom sträng
    public string TypeName { get; set; } = string.Empty;

    // OptionType representerar typen av alternativ för filtret
    public OptionType OptionType { get; set; }
}

// DTO-klass för att uppdatera befintligt Filter, ärver från FilterPostDTO för att återanvända egenskaper
public class FilterPutDTO : FilterPostDTO
{
    // Id för den befintliga filtret som ska uppdateras
    public int Id { get; set; }
}

// DTO-klass för att hämta information om ett Filter, ärver från FilterPutDTO för att inkludera Id och andra egenskaper
public class FilterGetDTO : FilterPutDTO
{
    // Inga ytterligare egenskaper, ärver från FilterPutDTO för att inkludera Id och andra egenskaper
}




namespace Motorcenter.API.DTO;

// DTO-klass för att skapa en ny Vehicle (fordon)
public class VehiclePostDTO
{
    // Namnet på fordonet som ska skapas
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public string PictureURL { get; set; } = string.Empty;

}

// DTO-klass för att uppdatera befintligt Vehicle, ärver från VehiclePostDTO för att återanvända egenskaper
public class VehiclePutDTO : VehiclePostDTO
{
    // Id för det befintliga fordonet som ska uppdateras
    public int Id { get; set; }
}

// DTO-klass för att hämta information om en Vehicle, ärver från VehiclePutDTO för att inkludera Id och andra egenskaper
public class VehicleGetDTO : VehiclePutDTO
{
    // Inga ytterligare egenskaper, ärver från VehiclePutDTO för att inkludera Id och andra egenskaper
}

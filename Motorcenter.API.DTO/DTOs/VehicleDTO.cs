﻿namespace Motorcenter.API.DTO;

// DTO-klass för att skapa en ny Vehicle (fordon)
public class VehiclePostDTO
{
    // Namnet på fordonet som ska skapas
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PictureURL { get; set; } = string.Empty;
    public int TypeId { get; set; }

}

public class VehiclePutDTO : VehiclePostDTO
{
    public int Id { get; set; }

}

public class VehicleGetDTO : VehiclePutDTO
{
    public List<ColorGetDTO>? Colors { get; set; }
    public List<YearGetDTO>? Years { get; set; }

}


public class CartItemDTO : VehiclePutDTO
{
    public ColorGetDTO? Color { get; set; }
    public YearGetDTO? Year { get; set; }

}



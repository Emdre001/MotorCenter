﻿namespace Motorcenter.Data.Entities;

public class Year : IEntity
{
    public int Id { get; set; }
    public string Range { get; set; }
    public List<Vehicle>? Vehicles { get; set; }
}
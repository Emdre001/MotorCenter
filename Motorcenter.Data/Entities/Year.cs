namespace Motorcenter.Data.Entities;

public class Year : IEntity
{
    public int Id { get; set; }
    public string Range { get; set; }
    public Vehicle Vehicles { get; set; }
}
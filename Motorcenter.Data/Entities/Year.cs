namespace Motorcenter.Data.Entities;

public class Year : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
    public List<Vehicle>? Vehicles { get; set; }
}
namespace Motorcenter.Data.Entities;

public class Filter : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TypeName { get; set; }
    public List<VehicleType>? VehicleTypes { get; set; }
    public OptionType OptionType { get; set; }
}
using System.Drawing;

namespace Motorcenter.Data.Entities;

public class Vehicle : IEntity
{
    public int Id { get; set; }
    public int TypeId {  get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public string PictureURL { get; set; } = string.Empty;
    public Type? Type{ get; set; }
    public List<Color>? Colors { get; set; }
    public List<Year>? Years { get; set; }
    //public List<Vehicle>? Vehicles { get; set; }
}

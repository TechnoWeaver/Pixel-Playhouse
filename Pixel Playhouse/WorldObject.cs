namespace Pixel_Playhouse;

public abstract class WorldObject
{
    public string? Name { get; set; }
    public bool Lootable { get; set; }
    public bool Removeable { get; set; }
}

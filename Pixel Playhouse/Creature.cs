namespace Pixel_Playhouse;

public abstract class Creature
{
    protected string? Name { get; set; }
    protected int HitPoint { get; set; }
    protected int MaxItemsCarry { get; set; }
    protected List<WorldObject> Items { get; set; } = new List<WorldObject>();

    protected int Hit(AttackItem attackItem)
    {
        return attackItem.Hit;
    }

    protected void RecieveHit(int hit)
    {
        HitPoint -= hit;
    }

    protected void Loot(WorldObject worldObject)
    {
        if (Items.Count >= MaxItemsCarry)
        {
            throw new Exception("Cannot carry more items");
        }

        Items.Add(worldObject);
    }
}

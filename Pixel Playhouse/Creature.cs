namespace Pixel_Playhouse;

/// <summary>
/// An abstract class representing a creature.
/// </summary>
public class Creature
{
    /// <summary>
    /// A variable representing the name of the creature.
    /// 
    protected string? name;

    /// <summary>
    /// A variable representing the hit points of the creature.
    /// 
    protected int hitPoints;

    /// <summary>
    /// A variable representing the maximum items the creature can carry.
    /// 
    protected int maxItemsCarry;

    /// <summary>
    /// A list containing all the world objects.
    /// 
    protected List<WorldObject> worldObjects = new List<WorldObject>();

    /// <summary>
    /// Gets the name of the creature.
    /// </summary>
    public string? Name => name;

    /// <summary>
    /// Gets the hit points of the creature.
    /// 
    public int HitPoints => hitPoints;

    /// <summary>
    /// Gets the maximum items the creature can carry.
    /// 
    public int MaxItemsCarry => maxItemsCarry;

    /// <summary>
    /// Gets the items the creature is carrying.
    /// 
    public List<WorldObject> Items => worldObjects;

    /// <summary>
    /// A method to return the attack damage of an attack item.
    /// <paramref name="attackItem"/>The attack item used to deal damage.</param>
    /// 
    protected int Hit(AttackItem attackItem)
    {
        return attackItem.Hit;
    }

    /// <summary>
    /// A method to reduce the hit points of the creature.
    /// </summary>
    /// <param name="hit">The amount of damage the creature is hit with.</param>
    protected void RecieveHit(int hit)
    {
        hitPoints -= hit;
    }


    /// <summary>
    /// A method to loot a world object.
    /// 
    /// <paramref name="worldObject"/>The world object to loot.</param>
    protected void Loot(WorldObject worldObject)
    {
        if (Items.Count >= MaxItemsCarry)
        {
            throw new Exception("Cannot carry more items");
        }

        Items.Add(worldObject);
    }
}

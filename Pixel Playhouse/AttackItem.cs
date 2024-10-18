namespace Pixel_Playhouse;

/// <summary>
/// An abstract class for attack items.
/// </summary>
public abstract class AttackItem : WorldObject
{
    /// <summary>
    /// A variable representing the amount of damage the attack item deals.
    /// </summary>
    protected int hit;

    /// <summary>
    /// A variable representing the range of the attack item.
    /// </summary>
    protected int range;

    /// <summary>
    /// Gets the damage of the attack item.
    /// </summary>
    public int Hit => hit;

    /// <summary>
    /// Gets the range of the attack item.
    /// 
    public int Range => range;


    /// <summary>
    /// A constructor for the attack item.
    /// 
    protected AttackItem()
    {
        InitializeWorldObject();
    }

    /// <summary>
    /// A method to initialize the AttackItem.
    /// 
    protected new void InitializeWorldObject()
    {
        SetName();
        SetHit();
        SetRange();
        SetLootableState();
        SetRemoveableState();
    }

    /// <summary>
    /// A method which must be implemented to set the hit points of the attack item.
    public abstract void SetHit();

    /// <summary>
    /// A method which must be implemented to set the range of the attack item.
    public abstract void SetRange();
}

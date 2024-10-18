namespace Pixel_Playhouse;

/// <summary>
/// An abstract class representing a defence item.
/// </summary>
public abstract class DefenceItem: WorldObject
{
    /// <summary>
    /// A variable representing the hit points that the attack item is reduced by.
    protected int defensePoints;

    /// <summary>
    /// Gets the defense points of the item.
    /// 
    public int DefensePoints => defensePoints;

    /// <summary>
    /// A constructor for the defence item.
    /// 
    protected DefenceItem()
    {
        InitializeWorldObject();
    }

    /// <summary>
    /// A method to initialize the DefenceItem.
    /// 
    protected new void InitializeWorldObject()
    {
        SetName();
        SetDefensePoints();
        SetLootableState();
        SetRemoveableState();
    }

    /// <summary>
    /// A method which must be implemented to set the defense points of the item.
    /// 
    public abstract void SetDefensePoints();
}

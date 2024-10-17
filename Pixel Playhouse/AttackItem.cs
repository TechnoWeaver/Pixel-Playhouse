namespace Pixel_Playhouse;

public abstract class AttackItem : WorldObject
{
    /// <summary>
    /// Gets or sets the hit points of the attack item.
    /// </summary>
    public int Hit { get; set; }

    /// <summary>
    /// Gets or sets the range of the attack item.
    /// 
    public int Range { get; set; }


    /// <summary>
    /// A constructor for the attack item.
    /// 
    protected AttackItem()
    {
        InitializeWorldObject();
    }

    /// <summary>
    /// A method to initialize the world object.
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

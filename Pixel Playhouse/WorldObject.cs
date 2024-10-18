namespace Pixel_Playhouse;

/// <summary>
/// An abstract class representing a world object.
/// </summary>
public abstract class WorldObject
{
    /// <summary>
    /// A string representing the name of the world object.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// A boolean representing the lootable state of the world object.
    /// 
    public bool Lootable { get; set; }

    /// <summary>
    /// A boolean representing the removeable state of the world object.
    /// 
    public bool Removeable { get; set; }


    /// <summary>
    /// A constructor for the world object.
    protected WorldObject()
    {
        InitializeWorldObject();
    }

    /// <summary>
    /// A method to initialize the world object.
    /// 
    protected void InitializeWorldObject()
    {
        SetName();
        SetLootableState();
        SetRemoveableState();
    }

    /// <summary>
    /// A method which must be implemented to set the name of the world object.
    /// 
    public abstract void SetName();

    /// <summary>
    /// A method which must be implemented to set the lootable state of the world object.
    /// 
    public abstract void SetLootableState();

    /// <summary>
    /// A method which must be implemented to set the removeable state of the world object.
    /// 
    public abstract void SetRemoveableState();
}

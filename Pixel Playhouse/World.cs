namespace Pixel_Playhouse;

/// <summary>
/// Represents an abstract based class for the world.
/// </summary>
public abstract class World
{
    /// <summary>
    /// Gets or sets the maximum world coordinate X.
    /// </summary>
    public int MaxX { get; set; }

    /// <summary>
    /// Gets or sets the maximum world coordinate Y.
    /// </summary>
    public int MaxY { get; set; }

    /// <summary>
    /// Represents a matrix of the game world.
    /// </summary>
    public int[,] GameWorld { get; set; }

    /// <summary>
    /// A list containing all the world objects.
    /// </summary>
    public List<WorldObject> WorldObjects { get; set; } = new List<WorldObject>();

    /// <summary>
    /// A list containing all the creatures.
    /// </summary>
    public List<Creature> Creatures { get; set; } = new List<Creature>();

    /// <summary>
    /// Initializes a new instance of the <see cref="World"/> class.
    /// </summary>
    protected World()
    {
        GameWorld = SetWorldSize();
        InitializeGameWorld();
    }

    /// <summary>
    /// Initializes the game world.
    /// </summary>
    protected void InitializeGameWorld()
    {
        AddWorldObjects();
        AddCreatures();
    }

    /// <summary>
    /// A method which must be implemented to set the world size.
    /// </summary>
    /// <returns>The world size as a matrix.</returns>
    public abstract int[,] SetWorldSize();

    /// <summary>
    /// A method which must be implemented to add world objects.
    /// </summary>
    public abstract void AddWorldObjects();

    /// <summary>
    /// A method which must be implemented to add creatures.
    /// </summary>
    public abstract void AddCreatures();
}

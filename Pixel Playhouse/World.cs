namespace Pixel_Playhouse;

public class World
{
    public int MaxX { get; set; }
    public int MaxY { get; set; }
    
    protected int[,] GameWorld { get; set; }

    protected World()
    {
        if (MaxX <= 0 || MaxY <= 0)
        {
            throw new Exception("Invalid world size");
        }

        GameWorld = new int[--MaxX, --MaxY];
    }
}

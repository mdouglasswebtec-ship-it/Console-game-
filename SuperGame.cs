public class SuperGame
{
    public static void UpdatePosition(string key, out int xChange, out int yChange)
    {
        xChange = 0;
        yChange = 0;
    }

    public static char UpdateCursor(string key)
    {
        return 'O';
    }

    public static int KeepInBounds(int coordinate, int maxCoordinate)
    {
        return coordinate;
    }

    public static bool DidScore(int xChar, int yChar, int xFruit, int yFruit)
    {
        return false;
    }
}

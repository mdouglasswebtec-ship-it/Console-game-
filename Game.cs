public class Game : SuperGame
{
    public new static void UpdatePosition(string key, out int xChange, out int yChange)
    {
        xChange = 0;
        yChange = 0;

        if (key == "LeftArrow")
        {
            xChange = -1;
        }
        else if (key == "RightArrow")
        {
            xChange = 1;
        }
        else if (key == "UpArrow")
        {
            yChange = -1;
        }
        else if (key == "DownArrow")
        {
            yChange = 1;
        }
    }

    public new static char UpdateCursor(string key)
    {
        if (key == "LeftArrow") return '<';
        if (key == "RightArrow") return '>';
        if (key == "UpArrow") return '^';
        if (key == "DownArrow") return 'v';

        return 'O';
    }

    public new static int KeepInBounds(int coordinate, int maxCoordinate)
    {
        if (coordinate < 0)
        {
            return 0;
        }

        if (coordinate >= maxCoordinate)
        {
            return maxCoordinate - 1;
        }

        return coordinate;
    }

    public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit)
    {
        return xChar == xFruit && yChar == yFruit;
    }
}

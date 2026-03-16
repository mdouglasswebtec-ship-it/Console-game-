using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.CursorVisible = false;

int width = 30;
int height = 15;

int x = width / 2;
int y = height / 2;
char player = 'O';

var random = new Random();
int fruitX = random.Next(0, width);
int fruitY = random.Next(0, height);
int score = 0;

while (true)
{
    DrawBoard(width, height, x, y, player, fruitX, fruitY, score);

    var keyInfo = Console.ReadKey(intercept: true);
    if (keyInfo.Key == ConsoleKey.Q)
    {
        break;
    }

    string key = keyInfo.Key.ToString();

    Game.UpdatePosition(key, out int xChange, out int yChange);
    x = Game.KeepInBounds(x + xChange, width);
    y = Game.KeepInBounds(y + yChange, height);

    player = Game.UpdateCursor(key);

    if (Game.DidScore(x, y, fruitX, fruitY))
    {
        score++;

        do
        {
            fruitX = random.Next(0, width);
            fruitY = random.Next(0, height);
        }
        while (Game.DidScore(x, y, fruitX, fruitY));
    }
}

Console.Clear();
Console.WriteLine($"Final Score: {score}");

static void DrawBoard(int width, int height, int x, int y, char player, int fruitX, int fruitY, int score)
{
    Console.Clear();
    Console.WriteLine("Use arrow keys to move. Press Q to quit.");
    Console.WriteLine($"Score: {score}");

    for (int row = 0; row < height; row++)
    {
        for (int col = 0; col < width; col++)
        {
            if (col == x && row == y)
            {
                Console.Write(player);
            }
            else if (col == fruitX && row == fruitY)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }

        Console.WriteLine();
    }
}

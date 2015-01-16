//Incomplete.
using System;
using System.Threading;
class FallingRocks
{
    static void Main()
    {
        bool gameIsOn = true;
        ConsoleKeyInfo userKey;
        int dwarfCoordinateX = 37;
        int dwarfCoordinateY = 23;

        while (gameIsOn)
        {
            if (Console.KeyAvailable)
            {
                userKey = Console.ReadKey(true);

                switch (userKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (dwarfCoordinateX > 0)
                        {
                            dwarfCoordinateX = dwarfCoordinateX - 1;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (dwarfCoordinateX < 76)
                        {
                            dwarfCoordinateX = dwarfCoordinateX + 1;
                        }
                        break;
                    case ConsoleKey.Escape:
                        gameIsOn = false;
                        break;
                }
            }
            Console.Clear();
            Console.SetCursorPosition(dwarfCoordinateX, dwarfCoordinateY);
            Console.WriteLine("(O)");
            Random random = new Random();
            Console.SetCursorPosition(random.Next(75), 0);
            Console.Write("X");
            Thread.Sleep(150);
        }
    }
}
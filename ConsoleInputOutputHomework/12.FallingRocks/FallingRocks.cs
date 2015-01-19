using System;
using System.Collections.Generic;
using System.Threading;

//Defines a structure, where all the properties of our dwarf will be stored.
struct Dwarf
{
    public int x;
    public int y;
    public string str;
    public ConsoleColor color;
}

//Defines a structure, where all the properties of every single rock will be stored.
struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
class FallingRocks
{
    //Defines a method, which prints a given string being a rock at a given position on the console.
    static void PrintOnConsole(int x, int y, string str, ConsoleColor color = ConsoleColor.DarkBlue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    //Defines a method, which prints a given string at a given position on the console.
    static void PrintStringOnConsole(int x, int y, string str, ConsoleColor color = ConsoleColor.DarkBlue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        //Sets the borders of the console window.
        Console.BufferHeight = Console.WindowHeight = 3 * Console.WindowWidth / 10;
        Console.BufferWidth = Console.WindowWidth = 70;

        Console.Title = "-----FALLING--ROCKS-----";

        //Defines main parameters of the game.
        int playfieldWidth = 3 * Console.WindowWidth / 4;
        int livesCount = 5;
        decimal speed = 0;
        int score = 0;
        int highScore = 0;

        //Defines the dwarf and its starting position on the console.
        Dwarf userDwarf = new Dwarf();
        userDwarf.x = playfieldWidth / 2;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.str = "(O)";
        userDwarf.color = ConsoleColor.Green;

        Random randomGenerator = new Random();

        //Defines the list in which each rock will be stored.
        List<Rock> rocks = new List<Rock>();
        char[] typeOfRocks = { '@', '#', '$', '%', '^', '&', '/', '+', '¤', };

        ConsoleColor[] colors = { ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.White };

        //Initializes the execution of the game.
        while (true)
        {
            speed += 0.2M;
            score += (int)(5 * speed);
            if (speed > 70)
            {
                speed = 70;
            }
            bool isHit = false;
            {
                int probability = randomGenerator.Next(0, 100);

                //Prints a new rock on the console and
                //draws a connection between the rock density and
                //the play speed.
                if (probability >= 90 - speed)
                {
                    Rock smallRock = new Rock();
                    smallRock.x = randomGenerator.Next(0, playfieldWidth + 1);
                    smallRock.y = 0;
                    int chanceOfAppearance = randomGenerator.Next(0, 100);
                    int chanceOfTypeOfRock = randomGenerator.Next(0, 9);
                    int chanceOfColor = randomGenerator.Next(0, 4);
                    smallRock.c = typeOfRocks[chanceOfTypeOfRock];
                    smallRock.color = colors[chanceOfColor]; ;
                    //if (chance < 15)
                    //{
                    //    smallRock.str = "%";
                    //    smallRock.color = ConsoleColor.DarkGray;
                    //}
                    //else if (chance > 7 && chance < 50)
                    //{
                    //    smallRock.str = "@";
                    //    smallRock.color = ConsoleColor.DarkMagenta;
                    //}
                    //else if (chance > 50 && chance < 80)
                    //{
                    //    smallRock.str = "+";
                    //    smallRock.color = ConsoleColor.Yellow;
                    //}
                    //else
                    //{
                    //    smallRock.str = "/";
                    //    smallRock.color = ConsoleColor.Blue;
                    //}
                    rocks.Add(smallRock);
                }
            }

            //Defines dwarf movement.
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable == true) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userDwarf.x - 1 >= 0)
                    {
                        userDwarf.x = userDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userDwarf.x + 1 <= playfieldWidth)
                    {
                        userDwarf.x = userDwarf.x + 1;
                    }
                }
            }

            //Defines movement of rocks.
            List<Rock> newRocks = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;

                //Checks for collisions with the dwarf.
                if ((newRock.x == userDwarf.x || newRock.x == userDwarf.x + 1 || newRock.x == userDwarf.x + 2) && newRock.y == userDwarf.y)
                {
                    livesCount--;
                    isHit = true;
                    PrintStringOnConsole(userDwarf.x, userDwarf.y, userDwarf.str, userDwarf.color);

                    //Defines the end of the game when there are no more lives left.
                    if (livesCount <= 0)
                    {
                        PrintOnConsole(userDwarf.x, userDwarf.y, "X", ConsoleColor.Red);
                        PrintOnConsole(userDwarf.x + 1, userDwarf.y, "X", ConsoleColor.Red);
                        PrintOnConsole(userDwarf.x + 2, userDwarf.y, "X", ConsoleColor.Red);
                        PrintStringOnConsole(4 * Console.WindowWidth / 5, 12, "GAME OVER!!!", ConsoleColor.Red);
                        Console.SetCursorPosition(0, 0);
                        Environment.Exit(0);
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newRocks.Add(newRock);
                }
            }
            rocks = newRocks;

            //Clear the console.
            Console.Clear();

            //Redraw playfield.
            if (isHit == true)
            {
                rocks.Clear();
                speed = 0;
                if (highScore < score)
                {
                    highScore = score;
                }
                score = 0;
                PrintOnConsole(userDwarf.x, userDwarf.y, "X", ConsoleColor.Red);
                PrintOnConsole(userDwarf.x + 1, userDwarf.y, "X", ConsoleColor.Red);
                PrintOnConsole(userDwarf.x + 2, userDwarf.y, "X", ConsoleColor.Red);
                userDwarf.x = playfieldWidth / 2;
                userDwarf.y = Console.WindowHeight - 1;
            }
            else
            {
                PrintOnConsole(userDwarf.x, userDwarf.y, userDwarf.str, userDwarf.color);
            }
            foreach (Rock rock in rocks)
            {
                PrintOnConsole(rock.x, rock.y, rock.c.ToString(), rock.color);
            }

            //Draw info.
            PrintStringOnConsole(4 * Console.WindowWidth / 5, 6, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnConsole(4 * Console.WindowWidth / 5, 8, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnConsole(4 * Console.WindowWidth / 5, 10, "Score: " + score, ConsoleColor.White);
            PrintStringOnConsole(4 * Console.WindowWidth / 5, 15, "High Score:", ConsoleColor.DarkCyan);
            PrintStringOnConsole(4 * Console.WindowWidth / 5, 16, highScore.ToString(), ConsoleColor.DarkCyan);

            //Slow down program.
            Thread.Sleep((int)(100 - speed));
        }
    }
}
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
    public string str;
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
        Console.BufferHeight = Console.WindowHeight = 34;
        Console.BufferWidth = Console.WindowWidth = 121;

        //Defines main parameters of the game.
        int playfieldWidth = 81;
        int livesCount = 5;
        decimal speed = 0;
        int score = 0;
        int highScore = 0;

        //Defines the dwarf and its starting position on the console.
        Dwarf userDwarf = new Dwarf();
        userDwarf.x = 39;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.str = "(O)";
        userDwarf.color = ConsoleColor.DarkGreen;

        Random randomGenerator = new Random();

        //Defines the list in which each rock will be stored.
        List<Rock> rocks = new List<Rock>();

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
                    Rock newRock = new Rock();
                    newRock.x = randomGenerator.Next(0, playfieldWidth);
                    newRock.y = 0;
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 15)
                    {
                        newRock.str = "%";
                        newRock.color = ConsoleColor.DarkGray;
                    }
                    else if (chance > 7 && chance < 50)
                    {
                        newRock.str = "@";
                        newRock.color = ConsoleColor.DarkMagenta;
                    }
                    else if (chance > 50 && chance < 80)
                    {
                        newRock.str = "+";
                        newRock.color = ConsoleColor.Yellow;
                    }
                    else
                    {
                        newRock.str = "/";
                        newRock.color = ConsoleColor.Blue;
                    }
                    rocks.Add(newRock);
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
                newRock.str = oldRock.str;
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
                        PrintStringOnConsole(95, 17, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnConsole(95, 18, "Press [enter] to exit...", ConsoleColor.Red);
                        Console.ReadLine();
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
                userDwarf.x = 39;
                userDwarf.y = Console.WindowHeight - 1;
            }
            else
            {
                PrintOnConsole(userDwarf.x, userDwarf.y, userDwarf.str, userDwarf.color);
            }
            foreach (Rock rock in rocks)
            {
                PrintOnConsole(rock.x, rock.y, rock.str, rock.color);
            }
            //Draw info.
            PrintStringOnConsole(95, 10, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnConsole(95, 12, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnConsole(95, 14, "Score: " + score, ConsoleColor.White);
            PrintStringOnConsole(95, 22, "High Score: " + highScore, ConsoleColor.Cyan);
            //Slow down program.
            Thread.Sleep((int)(100 - speed));
        }
    }
}
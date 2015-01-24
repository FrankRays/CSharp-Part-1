using System;
class Flame
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());

        //Top half of flame;
        for (int i = width / 2; i > 0; i--)
        {
            Console.WriteLine(new string('.', (i - 1)) + "#" + new string('.', (width - 2 * i)) + "#" + new string('.', (i - 1)));
        }

        //Bottom half of flame.
        for (int i = 0; i < width / 4; i++)
        {
            Console.WriteLine(new string('.', (i)) + "#" + new string('.', (width - 2 * i - 2)) + "#" + new string('.', (i)));
        }

        //Edge of torch.
        Console.WriteLine(new string('-', width));

        //Torch.
        for (int i = 0; i < width / 2; i++)
        {
            Console.WriteLine(new string('.', (i)) + new string('\\', (width / 2 - i)) + new string('/', (width / 2 - i)) + new string('.', (i)));
        }

        Console.WriteLine();
    }
}


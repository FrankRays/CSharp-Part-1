using System;
class LettersDNA
{
    static void Main()
    {
        //INPUT
        int height = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        //SOLUTION
        int width = 7;
        int dots = width / 2;
        for (int i = 0; i < height; i++)
        {
            if (dots == -width / 2 - 1)
                dots = width / 2;
            Console.Write(new string('.', Math.Abs(dots)));
            for (int j = 1; j <= width - 2 * Math.Abs(dots); j++)
            {
                if (letter >= 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter);
                letter++;
            }
            Console.Write(new string('.', Math.Abs(dots)));
            dots--;
            Console.WriteLine();
        }
    }
}
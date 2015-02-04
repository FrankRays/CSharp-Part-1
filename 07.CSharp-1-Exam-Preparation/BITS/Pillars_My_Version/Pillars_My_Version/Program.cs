using System;
class Pillars
{
    static void Main()
    {
        int height = 8;
        int width = 8;
        char[,] matrix = new char[height, width];

        int sum = 0;
        int pillar = 8;
        bool isBit = false;

        for (int row = 0; row < height; row++)
        {
            char[] binary = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0').ToCharArray();
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = binary[col];
            }
        }

        for (int i = 7; i >= 0; i--)
        {
            int leftSide = 0;
            int rightSide = 0;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < i; col++)
                {
                    if (matrix[row, col] == '1')
                    {
                        leftSide++;
                    }
                }
                for (int col = 7; col > i; col--)
                {
                    if (matrix[row, col] == '1')
                    {
                        rightSide++;
                    }
                }
            }
            if (leftSide == rightSide)
            {
                
                if (pillar > i)
                {
                    pillar = i;
                    sum = leftSide;
                }
            }
        }
        if (pillar == 8)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(7 - pillar);
            Console.WriteLine(sum);
        }
    }
}
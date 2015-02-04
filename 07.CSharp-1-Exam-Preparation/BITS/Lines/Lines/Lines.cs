using System;
class Lines
{
    static void Main()
    {
        //input
        int height = 8;
        int width = 8;
        int[,] matrix = new int[height, width];
        for (int i = 0; i < height; i++)
        {
            string input = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            for (int j = 0; j < width; j++)
            {
                matrix[i, j] = Convert.ToInt32(input[j].ToString());
            }
        }

        //solution
        int bestCount = 0;
        int bestLength = 0;

        for (int row = 0; row < height; row++)
        {
            int length = 0;
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 1)
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestCount = 0;
                    }
                    if (length == bestLength)
                    {
                        bestCount++;
                    }
                }
                else
                {
                    length = 0;
                }

            }
        }
        for (int col = 0; col < width; col++)
        {
            int length = 0;
            for (int row = 0; row < height; row++)
            {
                if (matrix[row, col] == 1)
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestCount = 0;
                    }
                    if (length == bestLength)
                    {
                        bestCount++;
                    }
                }
                else
                {
                    length = 0;
                }
            }
        }
        if(bestLength == 1)
        {
            bestCount /= 2;
        }
        //output
        Console.WriteLine(bestLength);
        Console.WriteLine(bestCount);
    }
}

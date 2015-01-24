using System;
class TelerikLogoMatrix
{
    static void Main()
    {
        //input
        int x = int.Parse(Console.ReadLine());

        //solution
        int z = x / 2 + 1;
        int width = 3 * x - 2;
        int[,] matrix = new int[width, width];

        int currRow = x / 2;
        int currCol = 0;
        while (currRow >= 0)
        {
            matrix[currRow, currCol] = 1;
            currRow--;
            currCol++;
        }

        currRow = 0;
        currCol = z - 1;
        while (currCol <= width - z )
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol++;
        }

        currRow = width - x;
        currCol = width - z;
        while (currCol >= width - x - z + 1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol--;
        }

        currRow = width - 1;
        currCol = width / 2;
        while (currCol >= z - 1)
        {
            matrix[currRow, currCol] = 1;
            currRow--;
            currCol--;
        }

        currRow = width - x;
        currCol = z - 1;
        while (currRow >= 0)
        {
            matrix[currRow, currCol] = 1;
            currRow--;
            currCol++;
        }
        currRow = 0;
        currCol = width - z;
        while (currCol<=width-1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol++;
        }
        //output
        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                    Console.Write('.');
                else if (matrix[row, col] == 1)
                    Console.Write('*');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

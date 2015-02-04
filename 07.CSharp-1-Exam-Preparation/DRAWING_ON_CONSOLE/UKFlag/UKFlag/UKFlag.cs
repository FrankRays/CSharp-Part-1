using System;
class UKFlag
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solution
        int height = n;
        int width = n;
        int[,] matrix = new int[height, width];
        int currRow = 0;
        int currCol = 0;

        while (currRow < height / 2)
        {
            matrix[currRow, currCol] = 3;
            matrix[currRow, width - 1 - currCol] = 2;
            matrix[height - 1 - currRow, currCol] = 2;
            matrix[height - 1 - currRow, width - 1 - currCol] = 3;
            currRow++;
            currCol++;
        }

        currCol = width / 2;
        currRow = 0;
        while (currRow<=height-1)
        {
            matrix[currRow, currCol] = 4;
            currRow++;
        }

        currCol = 0;
        currRow = height/2;
        while (currCol <= height - 1)
        {
            matrix[currRow, currCol] = 1;
            currCol++;
        }

        matrix[height / 2, width / 2] = 5;

        //output
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                if (matrix[row, col] == 1)
                {
                    Console.Write('-');
                }
                if (matrix[row, col] == 2)
                {
                    Console.Write('/');
                }
                if (matrix[row, col] == 3)
                {
                    Console.Write('\\');
                }
                if (matrix[row, col] == 4)
                {
                    Console.Write('|');
                }
                if (matrix[row, col] == 5)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}
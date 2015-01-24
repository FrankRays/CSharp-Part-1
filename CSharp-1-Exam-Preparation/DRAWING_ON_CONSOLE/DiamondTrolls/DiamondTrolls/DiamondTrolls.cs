using System;
class DiamondTrolls
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solution;
        int width = n * 2 + 1;
        int height = (n - 3) / 2 * 3 + 6;
        int[,] matrix = new int[height, width];
        int currRow = (n + 1) / 2;
        int currCol = 0;

        while (currRow >= 0)
        {
            matrix[currRow, currCol] = 1;
            matrix[currRow, width - 1 - currCol] = 1;
            currRow--;
            currCol++;
        }

        currRow++;
        for (int i = 0; i < width / 2 - 1; i++)
        {
            matrix[currRow, currCol] = 1;
            currCol++;
        }

        currRow = (n + 1) / 2;
        currCol = 0;
        while (currRow <= height - 1)
        {
            matrix[currRow, currCol] = 1;
            matrix[currRow, width - 1 - currCol] = 1;
            currRow++;
            currCol++;
        }

        currCol = width / 2;
        for (currRow = 0; currRow < height - 1; currRow++)
        {
            matrix[currRow, currCol] = 1;
        }

        currRow = (n + 1) / 2;
        for (currCol = 0; currCol < width - 1; currCol++)
        {
            matrix[currRow, currCol] = 1;
        }
        //output
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}

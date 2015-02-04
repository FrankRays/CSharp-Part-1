using System;
class FirTree
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solition
        int height = n;
        int width = 2 * n - 3;
        int[,] matrix = new int[height, width];
        int currCol = width / 2;
        int currRow = 0;

        while (currCol >= 0)
        {
            for (int row = currRow; row < height - 1; row++)
            {
                matrix[row, currCol] = 1;
                matrix[row, width - 1 - currCol] = 1;
            }
            currRow++;
            currCol--;
        }
        matrix[height - 1, width / 2] = 1;
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
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}

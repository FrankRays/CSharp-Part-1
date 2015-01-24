using System;
class SandGlass
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

        while (currRow <= height / 2)
        {
            for (int col = currCol; col <= width / 2; col++)
            {
                matrix[currRow, col] = 1;
                matrix[currRow, width - 1 - col] = 1;
                matrix[height - 1 - currRow, col] = 1;
                matrix[height - 1 - currRow, width - 1 - col] = 1;
            }
            currRow++;
            currCol++;
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

                if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}

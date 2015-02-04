using System;
class Eggcellent
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solution
        int height = 2 * n + 1;
        int width = 3 * n + 2;
        int[,] matrix = new int[height, width];
        bool isDot = true;

        int currRow = (height - n) / 2;
        int currCol = 1;
        while (currRow>=0)
        {
                matrix[currRow, currCol] = 1;
                matrix[currRow, width - 2 - currCol] = 1;
                matrix[height - 2 - currRow, currCol] = 1;
                matrix[height - 2 - currRow, width - 2 - currCol] = 1;
                currRow--;
                currCol+=2;
                isDot = false;
        }

        currCol -= 2;
        currRow++;
        for (int i = 0; i < n - 1; i++)
        {
            matrix[currRow, currCol] = 1;
            matrix[height - 2 - currRow, currCol] = 1;
            currCol++;
        }
        currRow = (height - n) / 2;
        currCol = 1;
        for (int i = 0; i < n; i++)
        {
            matrix[currRow, currCol] = 1;
            matrix[currRow, width - 2 - currCol] = 1;
            currRow++;
        }

        currCol = 2;
        currRow = n-1;
        for (int i = 0; i < width - 5; i++)
        {
            if (i % 2 == 0)
                matrix[currRow, currCol] = 2;
            currCol++;
        }

        currCol = 2;
        currRow = n;
        for (int i = 0; i < width - 5; i++)
        {
            if (i % 2 != 0)
                matrix[currRow, currCol] = 2;
            currCol++;
        }
        //output
        for (int row = 0; row < height - 1; row++)
        {
            for (int col = 0; col < width - 1; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write('@');
                }
            }
            Console.WriteLine();
        }
    }
}

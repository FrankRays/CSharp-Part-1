using System;
class GoikoTower
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solution
        int height = n;
        int width = 2 * n;
        int[,] matrix = new int[height, width];
        int slashRow = 0;
        int slashCol = n - 1;
        int m = 1;
        int p = 1;
        while (slashRow <= height - 1)
        {
            matrix[slashRow, slashCol] = 2;
            matrix[slashRow, width - 1 - slashCol] = 3;
            if (slashRow == m)
            {
                int currCol = slashCol + 1;
                int currRow = slashRow;
                for (int i = 0; i < slashRow ; i++)
                {
                    matrix[currRow, currCol] = 1;
                    matrix[currRow, width - 1 - currCol] = 1;
                    currCol++;
                }
                m += ++p;
            }
            slashRow++;
            slashCol--;
        }

        //output
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                if (matrix[row, col] == 1)
                {
                    Console.Write("-");
                }
                if (matrix[row, col] == 2)
                {
                    Console.Write("/");
                }
                if (matrix[row, col] == 3)
                {
                    Console.Write("\\");
                }
            }
            Console.WriteLine();
        }
    }
}

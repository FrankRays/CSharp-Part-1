using System;
class Trapezoid
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solution
        int width = 2 * n;
        int height = n + 1;
        int[,] matrix = new int[height,width];

        int currRow = 0;
        int currCol = width / 2;
        while (currRow<=height-1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol--;
        }

        currRow--;
        currCol++;
        while (currCol<=width -1)
        {
            matrix[currRow, currCol] = 1;
            currCol++;
        }

        currCol--;
        while (currRow>=0)
        {
            matrix[currRow, currCol] = 1;
            currRow--;
        }

        currRow++;
        while(currCol>=width/2)
        {
            matrix[currRow, currCol] = 1;
            currCol--;
        }

        //output
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if(matrix[row,col]==0)
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
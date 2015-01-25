using System;
class OnesAndZeros
{
    static void drawOne(int topLeftCornerRow, int topLeftCornerCol, int[,] matrix)
    {
        matrix[topLeftCornerRow + 1, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 1, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 2, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 3, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol + 2] = 1;
    }
    static void drawZero(int topLeftCornerRow, int topLeftCornerCol, int[,] matrix)
    {
        matrix[topLeftCornerRow, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow, topLeftCornerCol + 2] = 1;
        matrix[topLeftCornerRow + 1, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow + 2, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow + 3, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol] = 1;
        matrix[topLeftCornerRow + 1, topLeftCornerCol + 2] = 1;
        matrix[topLeftCornerRow + 2, topLeftCornerCol + 2] = 1;
        matrix[topLeftCornerRow + 3, topLeftCornerCol + 2] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol + 2] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol + 1] = 1;
        matrix[topLeftCornerRow + 4, topLeftCornerCol + 2] = 1;
    }
    static void Main()
    {
        //input
        int input = int.Parse(Console.ReadLine());

        //solution
        int desiredSizeInBits = 16;
        int height = 5;
        int width = 63;
        int topLeftCornerCol = 60;
        int topLeftCornerRow = 0;
        int[,] matrix = new int[height, width];
        for (int i = 0; i < desiredSizeInBits; i++)
        {
            int currentBit = (input >> i) & 1;
            if (currentBit == 1)
            {
                drawOne(topLeftCornerRow, topLeftCornerCol, matrix);
            }
            else
            {
                drawZero(topLeftCornerRow, topLeftCornerCol, matrix);
            }
            topLeftCornerCol -= 4;
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
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
}


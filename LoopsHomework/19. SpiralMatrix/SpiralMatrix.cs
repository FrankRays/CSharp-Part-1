//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
//holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;
class SpiralMatrix
{
    static void Main()
    {
        //input
        int levelOfmatrix = int.Parse(Console.ReadLine());

        //solution
        int height = levelOfmatrix;
        int width = levelOfmatrix;
        int[,] matrix = new int[height, width];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "right";

        for (int i = 1; i <= levelOfmatrix * levelOfmatrix; i++)
        {
            if (direction == "right" && (currentCol >= width || matrix[currentRow,currentCol]!=0))
            {
                currentCol--;
                i--;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= height|| matrix[currentRow,currentCol]!=0))
            {
                currentRow--;
                i--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0|| matrix[currentRow,currentCol]!=0))
            {
                currentCol++;
                i--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0|| matrix[currentRow,currentCol]!=0))
            {
                currentRow++;
                i--;
                direction = "right";
            }

            matrix[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        //output
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("{0}\t",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

using System;
class Carpet
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //solution
        int[,] matrix = new int[n, n];
        int startSlash = n / 2 - 1;
        int endSlash = n / 2 - 1;
        bool isSlash = true;
        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n / 2; col++)
            {
                if (startSlash <= col && col <= endSlash)
                {
                    if (isSlash == true)
                    {
                        matrix[row, col] = 2;
                        isSlash = false;
                        matrix[row, n - 1 - col] = 3;
                        isSlash = false;
                        matrix[n - 1 - row, col] = 3;
                        isSlash = false;
                        matrix[n - 1 - row, n - 1 - col] = 2;
                        isSlash = false;
                    }
                    else
                    {
                        matrix[row, col] = 1;
                        isSlash = true;
                        matrix[row, n - 1 - col] = 1;
                        isSlash = true;
                        matrix[n - 1 - row, col] = 1;
                        isSlash = true;
                        matrix[n - 1 - row, n - 1 - col] = 1;
                        isSlash = true;
                    }
                }
            }
            startSlash--;
            isSlash = true;
        }

        //output
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                if (matrix[row, col] == 1)
                {
                    Console.Write(' ');
                }
                if (matrix[row, col] == 2)
                {
                    Console.Write('/');
                }
                if (matrix[row, col] == 3)
                {
                    Console.Write('\\');
                }
            }
            Console.WriteLine();
        }
    }
}

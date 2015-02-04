using System;
class ExcelColumns
{
    static void Main()
    {
        //INPUT
        int rank = int.Parse(Console.ReadLine());
        char[] columns = new char[rank];
        for (int i = 0; i < rank; i++)
        {
            columns[i] = Console.ReadLine()[0];
        }

        //SOLUTION
        double result = 0;
        for (int i = rank - 1; i >= 0; i--)
        {
            result += (columns[i] - 'A' + 1) * Math.Pow(26, rank - 1 - i);
        }

        //OUTPUT
        Console.WriteLine(result);
    }
}
using System;
class PieceOfCake
{
    static void Main()
    {
        //input
        ulong A = ulong.Parse(Console.ReadLine());
        ulong B = ulong.Parse(Console.ReadLine());
        ulong C = ulong.Parse(Console.ReadLine());
        ulong D = ulong.Parse(Console.ReadLine());

        //solution
        ulong numerator = A * D + B * C;
        ulong denominator = B * D;
        decimal floatingPointFraction = (decimal)numerator / denominator;
        ulong integerFraction = numerator / denominator;
        decimal difference = floatingPointFraction - integerFraction;

        //output
        if (floatingPointFraction >= 1)
        {
            Console.WriteLine(integerFraction);
            Console.WriteLine("{0}/{1}", numerator, denominator);
        }
        else
        {
            Console.WriteLine("{0:0.0000000000000000000000}", difference);
            Console.WriteLine("{0}/{1}", numerator, denominator);
        }
    }
}


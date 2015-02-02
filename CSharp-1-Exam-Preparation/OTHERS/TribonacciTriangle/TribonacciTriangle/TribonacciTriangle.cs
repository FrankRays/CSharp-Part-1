using System;
using System.Numerics;
class TribonacciTriangle
{
    static void Main()
    {
        //INPUT
        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        BigInteger indexN = BigInteger.Parse(Console.ReadLine());

        //SOLUTION
        Console.WriteLine();
        Console.WriteLine(firstMember);
        Console.WriteLine("{0} {1}", secondMember, thirdMember);
        for (int j = 3; j <= indexN; j++)
        {
            for (int i = 0; i < j; i++)
            {
                BigInteger helper = firstMember + secondMember + thirdMember;

                thirdMember += secondMember;
                secondMember = thirdMember - secondMember;
                thirdMember -= secondMember;

                thirdMember += firstMember;
                firstMember = thirdMember - firstMember;
                thirdMember -= firstMember;

                thirdMember = helper;
                Console.Write(thirdMember);
                if (i != j - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

}

using System;
using System.Numerics;
class QuadronacciRectangle
{
    static void Main()
    {
        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        BigInteger fourthMember = BigInteger.Parse(Console.ReadLine());

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0} ", firstMember);
                BigInteger helper = firstMember + secondMember + thirdMember + fourthMember;
                fourthMember += thirdMember;
                thirdMember = fourthMember - thirdMember;
                fourthMember -= thirdMember;

                fourthMember += secondMember;
                secondMember = fourthMember - secondMember;
                fourthMember -= secondMember;

                fourthMember += firstMember;
                firstMember = fourthMember - firstMember;
                fourthMember -= firstMember;

                fourthMember = helper;
            }
            Console.WriteLine();
        }
    }
}

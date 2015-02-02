using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        BigInteger indexN = BigInteger.Parse(Console.ReadLine());

        for (int i = 3; i < indexN; i++)
        {
            BigInteger helper = firstMember + secondMember + thirdMember;

            thirdMember += secondMember;
            secondMember = thirdMember - secondMember;
            thirdMember -= secondMember;

            thirdMember += firstMember;
            firstMember = thirdMember - firstMember;
            thirdMember -= firstMember;

            thirdMember = helper;
        }
        Console.WriteLine(thirdMember);
    }
}
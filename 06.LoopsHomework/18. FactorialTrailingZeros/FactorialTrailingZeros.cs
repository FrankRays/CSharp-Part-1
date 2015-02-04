//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
class FactorialTrailingZeros
{
    static void Main()
    {
        ulong factorialBase = ulong.Parse(Console.ReadLine());
        ulong factorsOfFive = 0;
        ulong trailingZeros;
        while (factorialBase > 0)
        {
            factorsOfFive += (factorialBase / 5);
            factorialBase /= 5;
        }
        trailingZeros = factorsOfFive;
        Console.WriteLine(trailingZeros);
    }
}

//Explanation:
//Whatever number you may take, e.g. 121 and you want to see how many trailing zeros there are
//in 121! all you have to do is find how many factors of 10 and its powers there are in this product, and count them.
//But, 10 = 2 * 5, so the number of factors of 10 and its powers must be the same number as for 2 or 5, whichever is less,
//because if you have eight 2's. and three 5's that means three 10's, so 3 trailing zeros.
//If you look at any number you will see there are much less factors of 5 and its powers than there are of 2 and its powers.
//So, all we have to do i count all factors of 5 and its powers and we are absolutely sure there are enough 2's
//to make 10's and trailing zeros resprectively.
//How do we do that: we count the number of factors for each power of 5 that can fit into the number.
//
//Example:
//
//100 000 / 5         =   20 000
//100 000 / 25        =   4 000
//100 000 / 125       =   800
//100 000 / 625       =   160
//100 000 / 3125      =   32
//100 000 / 15625     =   6.4 -> 6 when rounded off
//100 000 / 78125     =   1.28 -> 1 when rounded off
//100 000 / 390 625   =   0.256 -> 0 when rounded off
//
//Adding that up we get 20 000 + 4 000 + 800 + 160 + 32 + 6 + 1 = 24 999 factors of 5 and its powers,
//which means 24 999 trailing zeros in 100 000!

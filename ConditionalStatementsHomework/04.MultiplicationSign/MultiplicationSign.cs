//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
class MultiplicationSign
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double thirdNumber = Double.Parse(Console.ReadLine());
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            if (firstNumber > 0)
            {
                if (secondNumber > 0)
                {
                    if (thirdNumber > 0) Console.WriteLine("+");
                    else Console.WriteLine("-");
                }
                else
                {
                    if (thirdNumber < 0) Console.WriteLine("+");
                    else Console.WriteLine("-");
                }
            }
            else
            {
                if (secondNumber > 0)
                {
                    if (thirdNumber > 0) Console.WriteLine("-");
                    else Console.WriteLine("+");
                }
                else
                {
                    if (thirdNumber > 0) Console.WriteLine("+");
                    else Console.WriteLine("-");
                }
            }
        }
    }
}
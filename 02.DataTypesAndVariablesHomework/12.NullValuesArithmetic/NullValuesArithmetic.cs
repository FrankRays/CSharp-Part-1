﻿//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNumber = null;
        double? secondNumber = null;
        firstNumber += 10;
        secondNumber += 2.3;
        Console.WriteLine("|{0}|", firstNumber);
        Console.WriteLine("|{0}|", secondNumber);

    }
}

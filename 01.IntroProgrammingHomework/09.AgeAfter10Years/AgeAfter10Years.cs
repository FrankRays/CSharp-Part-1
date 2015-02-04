//Write a program to read your birthday from the console
//and print how old you are now and how old you will be after 10 years.
using System;
class AgeAfter10Years
{
    static void Main()
    {
        //Since your age is only determined by your birth year,
        //that is the only information needed for this problem
        //in order to get to the age in 10 years' time.
        int birthYear = Int32.Parse(Console.ReadLine());
        Console.WriteLine("In 10 years' time you will be " + (DateTime.Now.Year + 10 - birthYear) + " years old.");
    }
}

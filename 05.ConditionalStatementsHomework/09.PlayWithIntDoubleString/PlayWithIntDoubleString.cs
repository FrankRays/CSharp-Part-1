//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n\t1 --> int\n\t2 --> double\n\t3 --> string");
        int userChoice = Int32.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                {
                    Console.WriteLine(Int32.Parse(Console.ReadLine()) + 1);
                    break;
                }
            case 2:
                {
                    Console.WriteLine(Double.Parse(Console.ReadLine()) + 1.0);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("{0}*", Console.ReadLine());
                    break;
                }
            default:
                {
                    Console.WriteLine("Not a valid choice.");
                    break;
                }
        }
    }
}

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
//Use 2 nested for-loops and a switch-case statement.

using System;
class PrintDeckOfCards
{
    static void Main()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 0: Console.Write("2 of "); break;
                    case 1: Console.Write("3 of "); break;
                    case 2: Console.Write("4 of "); break;
                    case 3: Console.Write("5 of "); break;
                    case 4: Console.Write("6 of "); break;
                    case 5: Console.Write("7 of "); break;
                    case 6: Console.Write("8 of "); break;
                    case 7: Console.Write("9 of "); break;
                    case 8: Console.Write("J of "); break;
                    case 9: Console.Write("Q of "); break;
                    case 10: Console.Write("K of "); break;
                    case 11: Console.Write("A of "); break;
                }
                switch (j)
                {
                    case 0: Console.Write("clubs     "); break;
                    case 1: Console.Write("diamonds  "); break;
                    case 2: Console.Write("hearts    "); break;
                    case 3: Console.Write("spades    "); break;
                }
            }
            Console.WriteLine();
        }
    }
}

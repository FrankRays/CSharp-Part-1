using System;
using System.Numerics;
class CardWars
{
    static void Main()
    {
        //INPUT
        int gamesInMatch = int.Parse(Console.ReadLine());

        //SOLUTION
        BigInteger fPScore = 0;
        BigInteger sPScore = 0;
        int fPGames = 0;
        int sPGames = 0;
        bool fPXCard = false;
        bool sPXCard = false;

        for (int i = 0; i < gamesInMatch; i++)
        {
            BigInteger currFPScore = 0;
            for (int j = 0; j < 3; j++)
            {
                char card = Console.ReadLine()[0];
                switch (card)
                {
                    case '1':
                        fPScore += 2;
                        currFPScore += 2;
                        break;
                    case '2':
                        fPScore += 10;
                        currFPScore += 10;
                        break;
                    case '3':
                        fPScore += 9;
                        currFPScore += 9;
                        break;
                    case '4':
                        fPScore += 8;
                        currFPScore += 8;
                        break;
                    case '5':
                        fPScore += 7;
                        currFPScore += 7;
                        break;
                    case '6':
                        fPScore += 6;
                        currFPScore += 6;
                        break;
                    case '7':
                        fPScore += 5;
                        currFPScore += 5;
                        break;
                    case '8':
                        fPScore += 4;
                        currFPScore += 4;
                        break;
                    case '9':
                        fPScore += 3;
                        currFPScore += 3;
                        break;
                    case 'J':
                        fPScore += 11;
                        currFPScore += 11;
                        break;
                    case 'Q':
                        fPScore += 12;
                        currFPScore += 12;
                        break;
                    case 'K':
                        fPScore += 13;
                        currFPScore += 13;
                        break;
                    case 'A':
                        fPScore += 1;
                        currFPScore += 1;
                        break;
                    case 'Y':
                        fPScore -= 200;
                        break;
                    case 'Z':
                        fPScore *= 2;
                        currFPScore *= 2;
                        break;
                    case 'X':
                        fPXCard = true;
                        break;
                    default: break;
                }
            }

            BigInteger currSPScore = 0;
            for (int j = 0; j < 3; j++)
            {
                char card = Console.ReadLine()[0];
                switch (card)
                {
                    case '1':
                        sPScore += 2;
                        currSPScore += 2;
                        break;
                    case '2':
                        sPScore += 10;
                        currSPScore += 10;
                        break;
                    case '3':
                        sPScore += 9;
                        currSPScore += 9;
                        break;
                    case '4':
                        sPScore += 8;
                        currSPScore += 8;
                        break;
                    case '5':
                        sPScore += 7;
                        currSPScore += 7;
                        break;
                    case '6':
                        sPScore += 6;
                        currSPScore += 6;
                        break;
                    case '7':
                        sPScore += 5;
                        currSPScore += 5;
                        break;
                    case '8':
                        sPScore += 4;
                        currSPScore += 4;
                        break;
                    case '9':
                        sPScore += 3;
                        currSPScore += 3;
                        break;
                    case 'J':
                        sPScore += 11;
                        currSPScore += 11;
                        break;
                    case 'Q':
                        sPScore += 12;
                        currSPScore += 12;
                        break;
                    case 'K':
                        sPScore += 13;
                        currSPScore += 13;
                        break;
                    case 'A':
                        sPScore += 1;
                        currSPScore += 1;
                        break;
                    case 'Y':
                        sPScore -= 200;
                        break;
                    case 'Z':
                        sPScore *= 2;
                        currSPScore *= 2;
                        break;
                    case 'X':
                        sPXCard = true;
                        break;
                    default: break;
                }
            }

            if (fPXCard && sPXCard)
            {
                fPScore += 50;
                sPScore += 50;
                fPXCard = false;
                sPXCard = false;
            }
                if (currFPScore == currSPScore)
                {
                    fPScore -= currFPScore;
                    sPScore -= currSPScore;
                }
                else
                {
                    if (currFPScore > currSPScore)
                    {
                        fPGames++;
                        sPScore -= currSPScore;
                    }
                    else
                    {
                        sPGames++;
                        fPScore -= currFPScore;
                    }
                }
        }

        //OUTPUT
        if (fPXCard && !sPXCard)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
            return;
        }
        else if (!fPXCard && sPXCard)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
            return;
        }
        if (fPScore > sPScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", fPScore);
            Console.WriteLine("Games won: {0}", fPGames);
        }
        else if (sPScore > fPScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", sPScore);
            Console.WriteLine("Games won: {0}", sPGames);
        }
        else if (fPScore == sPScore)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", fPScore);
        }
    }
}
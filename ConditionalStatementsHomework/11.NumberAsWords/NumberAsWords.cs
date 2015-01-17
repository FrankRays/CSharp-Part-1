using System;
class NumberAsWords
{
    static void Main()
    {
        string numberAsWords = "";
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;
        if (thirdDigit > 10) thirdDigit = number % 10;
        switch (firstDigit)
        {
            case 0:
                {
                    if (secondDigit == 1)
                    {
                        switch (thirdDigit)
                        {
                            case 0: numberAsWords += "ten"; break;
                            case 1: numberAsWords += "eleven"; break;
                            case 2: numberAsWords += "twelve"; break;
                            case 3: numberAsWords += "thirteen"; break;
                            case 4: numberAsWords += "fourteen"; break;
                            case 5: numberAsWords += "fifteen"; break;
                            case 6: numberAsWords += "sixteen"; break;
                            case 7: numberAsWords += "seventeen"; break;
                            case 8: numberAsWords += "eighteen"; break;
                            case 9: numberAsWords += "nineteen"; break;
                            default: break;
                        }
                    }
                    else
                    {
                        switch (secondDigit)
                        {
                            case 0:
                                {
                                    switch (thirdDigit)
                                    {
                                        case 0: numberAsWords += "zero"; break;
                                        case 1: numberAsWords += "one"; break;
                                        case 2: numberAsWords += "two"; break;
                                        case 3: numberAsWords += "three"; break;
                                        case 4: numberAsWords += "four"; break;
                                        case 5: numberAsWords += "five"; break;
                                        case 6: numberAsWords += "six"; break;
                                        case 7: numberAsWords += "seven"; break;
                                        case 8: numberAsWords += "eight"; break;
                                        case 9: numberAsWords += "nine"; break;
                                        default: break;
                                    }
                                    break;
                                }
                            case 2: numberAsWords += "twenty"; break;
                            case 3: numberAsWords += "thirty"; break;
                            case 4: numberAsWords += "forty"; break;
                            case 5: numberAsWords += "fifty"; break;
                            case 6: numberAsWords += "sixty"; break;
                            case 7: numberAsWords += "seventy"; break;
                            case 8: numberAsWords += "eighty"; break;
                            case 9: numberAsWords += "ninety"; break;
                            default: break;
                        }
                        if (secondDigit != 0 && secondDigit != 1)
                        {
                            switch (thirdDigit)
                            {
                                case 1: numberAsWords += "-one"; break;
                                case 2: numberAsWords += "-two"; break;
                                case 3: numberAsWords += "-three"; break;
                                case 4: numberAsWords += "-four"; break;
                                case 5: numberAsWords += "-five"; break;
                                case 6: numberAsWords += "-six"; break;
                                case 7: numberAsWords += "-seven"; break;
                                case 8: numberAsWords += "-eight"; break;
                                case 9: numberAsWords += "-nine"; break;
                                default: break;
                            }
                        }
                    }
                    break;
                }
            case 1: numberAsWords += "One hundred"; break;
            case 2: numberAsWords += "Two hundred"; break;
            case 3: numberAsWords += "Three hundred"; break;
            case 4: numberAsWords += "Four hundred"; break;
            case 5: numberAsWords += "Five hundred"; break;
            case 6: numberAsWords += "Six hundred"; break;
            case 7: numberAsWords += "Seven hundred"; break;
            case 8: numberAsWords += "Eight hundred"; break;
            case 9: numberAsWords += "Nine hundred"; break;
            default: break;
        }
        if (secondDigit == 1 && firstDigit!=0)
        {
            switch (thirdDigit)
            {
                case 0: numberAsWords += " and ten"; break;
                case 1: numberAsWords += " and eleven"; break;
                case 2: numberAsWords += " and twelve"; break;
                case 3: numberAsWords += " and thirteen"; break;
                case 4: numberAsWords += " and fourteen"; break;
                case 5: numberAsWords += " and fifteen"; break;
                case 6: numberAsWords += " and sixteen"; break;
                case 7: numberAsWords += " and seventeen"; break;
                case 8: numberAsWords += " and eighteen"; break;
                case 9: numberAsWords += " and nineteen"; break;
                default: break;
            }
        }
        if (secondDigit != 1 && firstDigit != 0)
        {
            switch (secondDigit)
            {
                case 0:
                    {
                        switch (thirdDigit)
                        {
                            case 1: numberAsWords += " and one"; break;
                            case 2: numberAsWords += " and two"; break;
                            case 3: numberAsWords += " and three"; break;
                            case 4: numberAsWords += " and four"; break;
                            case 5: numberAsWords += " and five"; break;
                            case 6: numberAsWords += " and six"; break;
                            case 7: numberAsWords += " and seven"; break;
                            case 8: numberAsWords += " and eight"; break;
                            case 9: numberAsWords += " and nine"; break;
                            default: break;
                        }
                        break;
                    }
                case 2: numberAsWords += " and twenty"; break;
                case 3: numberAsWords += " and thirty"; break;
                case 4: numberAsWords += " and forty"; break;
                case 5: numberAsWords += " and fifty"; break;
                case 6: numberAsWords += " and sixty"; break;
                case 7: numberAsWords += " and seventy"; break;
                case 8: numberAsWords += " and eighty"; break;
                case 9: numberAsWords += " and ninety"; break;
                default: break;
            }
            if (secondDigit != 0 && secondDigit != 1)
            {
                switch (thirdDigit)
                {
                    case 1: numberAsWords += "-one"; break;
                    case 2: numberAsWords += "-two"; break;
                    case 3: numberAsWords += "-three"; break;
                    case 4: numberAsWords += "-four"; break;
                    case 5: numberAsWords += "-five"; break;
                    case 6: numberAsWords += "-six"; break;
                    case 7: numberAsWords += "-seven"; break;
                    case 8: numberAsWords += "-eight"; break;
                    case 9: numberAsWords += "-nine"; break;
                    default: break;
                }
            }
        }
        Console.WriteLine(numberAsWords);
    }
}
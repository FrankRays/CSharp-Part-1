using System;
class TheHorror
{
    static void Main()
    {
        //INPUT
        string inputText = Console.ReadLine();

        //SOLUTION
        long result = 0;
        long counter = 0;
        for (int index = 0; index < inputText.Length; index+=2)
        {
            if(char.IsDigit(inputText[index]))
            {
                ++counter;
                result += inputText[index] - '0';
            }
        }

        //OUTPUT
        Console.WriteLine("{0} {1}",counter,result);
    }
}


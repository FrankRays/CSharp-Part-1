using System;
class NeuronMapping2
{
    static void Main()
    {
        while (true)
        {
            long number = long.Parse(Console.ReadLine());
            if (number == -1)
            {
                break;
            }
            int mostLeftBit = -1;
            int mostRightBit = -1;
            char[] input = Convert.ToString(number, 2).PadLeft(32, '0').ToCharArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '1')
                {
                    mostLeftBit = input.Length - 1 - i;
                }
                if (input[input.Length - 1 - i] == '1')
                {
                    mostRightBit = i;
                }
            }
            if (mostLeftBit == -1 && mostRightBit == -1)
            {
                Console.WriteLine(0);
                continue;
            }
            for (int i = mostRightBit; i <= mostLeftBit; i++)
            {
                if (input[input.Length - 1 - i] == '0')
                {
                    input[input.Length - 1 - i] = '1';
                }
                else
                {
                    input[input.Length - 1 - i] = '0';
                }
            }
            long result = Convert.ToInt64(new string(input), 2);
            Console.WriteLine(result);
        }
    }
}
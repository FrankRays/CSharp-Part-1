using System;
class TripleRotationOfDigits
{
    public static int firstDigitInFront(int n)
    {
        string number = n.ToString();
        char[] result = new char[number.Length];
        if (number[number.Length - 1] != '0')
        {
            result[0] = number[number.Length - 1];
            for (int i = 1; i < number.Length; i++)
            {
                result[i] = number[i - 1];
            }
        }
        else
        {
            number = number.Remove(number.Length - 1, 1);
            for (int i = 0; i < number.Length; i++)
            {
                result[i] = number[i];
            }
        }
        //Console.WriteLine(new string(result));
        return Convert.ToInt32(new string(result));
    }
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
            input = firstDigitInFront(input);
        }
        //int output = firstDigitInFront(input);
        Console.WriteLine(input);
    }
}


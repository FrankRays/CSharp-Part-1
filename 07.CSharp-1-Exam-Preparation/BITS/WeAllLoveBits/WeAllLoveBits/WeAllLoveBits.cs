using System;
class WeAllLoveBits
{
    static int invert(int p)
    {
        char[] binary = Convert.ToString(p, 2).ToCharArray();
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                binary[i] = '0';
            }
            else
            {
                binary[i] = '1';
            }
        }
        int result = Convert.ToInt32(new string(binary), 2);
        return result;
    }
    static int reverse(int p)
    {
        char[] binary = Convert.ToString(p, 2).ToCharArray();
        char[] reversed = new char[binary.Length];
        for (int i = 0; i < binary.Length; i++)
        {
            reversed[i] = binary[binary.Length - 1 - i];
        }
        int result = Convert.ToInt32(new string(reversed), 2);
        return result;
    }
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfInputs; i++)
        {
            int numberP = int.Parse(Console.ReadLine());
            int newP = (numberP ^ invert(numberP)) & reverse(numberP);
            Console.WriteLine(newP);
        }
    }
}

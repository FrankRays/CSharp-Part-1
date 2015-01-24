using System;
class DecimalToBinary
{
    static void Main()
    {
        long decimalForm = Int64.Parse(Console.ReadLine());
        string reversedBinaryForm = "";
        while(decimalForm/2!=0)
        {
            reversedBinaryForm+=(decimalForm%2).ToString();
            decimalForm /= 2;
        }
        Console.WriteLine(reversedBinaryForm);
    }

}

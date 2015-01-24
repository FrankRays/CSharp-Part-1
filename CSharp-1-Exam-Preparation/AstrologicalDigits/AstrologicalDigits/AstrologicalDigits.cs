using System;
class AstrologicalDigits
{
    static void Main()
    {
        //input
        string number = Console.ReadLine();

        //solution
        long sumOfDigits = 0;
        string[] dividedNumber = Convert.ToString(number).Split('.','-');
        int i;
        if(dividedNumber[0]=="-")
        {
            i = 1;
        }
        else
        {
            i = 0;
        }
        for (; i < dividedNumber.Length; i++)
        {
            for (int j = 0; j < dividedNumber[i].Length; j++)
            {
                sumOfDigits += Convert.ToInt64(dividedNumber[i][j].ToString());
            }
        }

        while (sumOfDigits / 10 != 0)
        {
            long sum = 0;
            string newSumOfDigits = sumOfDigits.ToString();
            for (int j = 0; j < newSumOfDigits.Length; j++)
            {
                sum += Convert.ToInt64(newSumOfDigits[j].ToString());
            }
            sumOfDigits = sum;
        }

        //output
        Console.WriteLine(sumOfDigits);
    }
}

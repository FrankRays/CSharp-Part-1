using System;
class CoffeeMachine
{
    static void Main()
    {
        //INPUT
        int[] moneyTray = new int[5];
        for (int i = 0; i < 5; i++)
        {
            moneyTray[i] = int.Parse(Console.ReadLine());
        }
        decimal programmerMoney = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        //SOLUTION
        if (programmerMoney < price)
        {
            Console.WriteLine("More {0:0.00}", -programmerMoney + price);
            return;
        }
        decimal machineMoney = (decimal)(moneyTray[0] * 0.05 + moneyTray[1] * 0.1 + moneyTray[2] * 0.2 + moneyTray[3] * 0.5 + moneyTray[4] * 1);
        decimal change = programmerMoney - price;
        int numberOfCoins = 1;
        while (change > 1 && numberOfCoins <= moneyTray[4])
        {
            change -= 1;
            numberOfCoins++;
        }
        numberOfCoins = 1;
        while (change >= 0.5M && numberOfCoins <= moneyTray[3])
        {
            change -= 0.5M;
            numberOfCoins++;
        }
        numberOfCoins = 1;
        while (change >= 0.20M && numberOfCoins <= moneyTray[2])
        {
            change -= 0.20M;
            numberOfCoins++;
        }
        numberOfCoins = 1;
        while (change >= 0.10M && numberOfCoins <= moneyTray[1])
        {
            change -= 0.10M;
            numberOfCoins++;
        }
        numberOfCoins = 1;
        while (change >= 0.05M && numberOfCoins <= moneyTray[0])
        {
            change -= 0.05M;
            numberOfCoins++;
        }

        //OUTPUT
        if (change == 0)
        {
            change = programmerMoney - price;
            Console.WriteLine("Yes {0:0.00}", machineMoney - change);
            return;
        }
        Console.WriteLine("No {0:0.00}", programmerMoney - price - machineMoney);
    }
}
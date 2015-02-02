using System;
class Garden
{
    static void Main()
    {
        //INPUT
        decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
        decimal tomatoArea = decimal.Parse(Console.ReadLine());
        decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());
        decimal potatoSeeds = decimal.Parse(Console.ReadLine());
        decimal potatoArea = decimal.Parse(Console.ReadLine());
        decimal carrotSeeds = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());
        decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());
        decimal beansSeeds = decimal.Parse(Console.ReadLine());

        //SOLUTION
        decimal tomatoPrice = 0.5M;
        decimal cucumberPrice = 0.4M;
        decimal potatoPrice = 0.25M;
        decimal carrotPrice = 0.6M;
        decimal cabbagePrice = 0.3M;
        decimal beansPrice = 0.4M;
        decimal totalArea = 250M;
        decimal totalCost = tomatoSeeds * tomatoPrice + cucumberSeeds * cucumberPrice + potatoSeeds * potatoPrice
            + carrotSeeds * carrotPrice + cabbageSeeds * cabbagePrice + beansSeeds * beansPrice;
        decimal desiredArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        decimal beansArea = totalArea - desiredArea;

        //OUTPUT
        Console.WriteLine("Total costs: {0:0.00}", totalCost);
        if(desiredArea>totalArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else if(desiredArea==totalArea)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
    }
}


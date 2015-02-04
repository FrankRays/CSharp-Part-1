//Declare two integer variables a and b and assign them with 5 and 10 
//and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int variableA = 5;
        int variableB = 10;
        Console.WriteLine("a = {0}", variableA);
        Console.WriteLine("b = {0}", variableB);

        int helpVariable = variableA;
        variableA = variableB;
        variableB = helpVariable;
        Console.WriteLine("----------");
        Console.WriteLine("a = {0}", variableA);
        Console.WriteLine("b = {0}", variableB);
    }
}

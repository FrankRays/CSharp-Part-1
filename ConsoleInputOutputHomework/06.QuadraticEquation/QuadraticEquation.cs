//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).
using System;
class QuadraticEquation
{
    static void Main()
    {
        double quadraticCoefficient = Double.Parse(Console.ReadLine());
        double linearCoefficient = Double.Parse(Console.ReadLine());
        double freeTerm = Double.Parse(Console.ReadLine());
        double discriminant = Math.Pow(linearCoefficient, 2) - 4 * quadraticCoefficient * freeTerm;
        if (discriminant < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("x1 = x2 = {0:0.00}", -0.5 * linearCoefficient / quadraticCoefficient);
        }
        else
        {
            Console.WriteLine("x1 = {0:0.00}", 0.5 * (-linearCoefficient - Math.Sqrt(discriminant)) / quadraticCoefficient);
            Console.WriteLine("x2 = {0:0.00}", 0.5 * (-linearCoefficient + Math.Sqrt(discriminant)) / quadraticCoefficient);
        }
        Main();
    }
}

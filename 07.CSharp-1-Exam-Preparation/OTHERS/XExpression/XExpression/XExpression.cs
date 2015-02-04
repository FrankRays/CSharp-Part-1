using System;
using System.Data;
class XExpression
{
    static void Main()
    {
        //INPUT
        string expression = Console.ReadLine();

        //SOLUTION
        DataTable dataT = new DataTable();
        decimal computation = 0;
        if(expression[0]=='(')
        {
            expression = "0+" + expression;
        }
        string calc = expression[0].ToString();
        int digits = 0;
        string inBrackets = "";
        for (int i = 1; i < expression.Length - 1; i++)
        {
            if (char.IsDigit(expression[i]))
            {
                digits++;
                calc += expression[i].ToString();
            }
            else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')
            {
                calc += expression[i].ToString();
            }
            else if (expression[i] == '(')
            {
                inBrackets = expression[i + 1].ToString();
                for (int j = i + 2; j < expression.Length; j++)
                {
                    if (expression[j] == ')')
                    {
                        i = j;
                        calc += inBrackets;
                        digits = 1;
                        break;
                    }
                    if (char.IsDigit(expression[j]))
                    {
                        digits++;
                        inBrackets += expression[j].ToString();
                    }
                    else if (expression[j] == '+' || expression[j] == '-' || expression[j] == '*' || expression[j] == '/')
                    {
                        inBrackets += expression[j].ToString();
                    }
                    if (digits == 1)
                    {
                        inBrackets = Convert.ToDecimal(dataT.Compute(inBrackets, "")).ToString();
                        digits = 0;
                    }
                }
            }
            if (digits == 1)
            {
                computation = Convert.ToDecimal(dataT.Compute(calc, ""));
                digits = 0;
                calc = computation.ToString();
            }
        }

        //OUTPUT
        Console.WriteLine("{0:F2}", (float)computation);
    }
}
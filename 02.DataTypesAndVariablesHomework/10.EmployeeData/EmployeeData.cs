//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name, Last name, Age, Gender, Personal ID number, Unique employee number, 
//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. Print the data at the console.
using System;
class EmployeeData
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Smith";
        byte age = 31;
        char gender = 'm';

        //If one of the employees is born in 2000, then we should use type string,
        //but since a 14-year-old working in a company is highly unlikely,
        //then we simply use type long.
        long personalIDNumber = 8306112507;

        //If some of the unique employee numbers start with a '0',
        //then we should use type string.

        int employeeNumber = 27560000;
        Console.WriteLine("First Name:\t\t" + firstName);
        Console.WriteLine("Last Name:\t\t" + lastName);
        Console.WriteLine("Age:\t\t\t" + age);
        Console.WriteLine("Gender:\t\t\t" + gender);
        Console.WriteLine("Personal ID:\t\t" + personalIDNumber);
        Console.WriteLine("Employee Number:\t" + employeeNumber);
        Console.WriteLine();
    }
}
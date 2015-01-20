//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.
using System;
class BankAccountData
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        string IBAN;

        //Type is 'decimal' to prevent mistakes when rounding off.
        decimal balance;

        string bankName;

        //According to Wikipedia, a standard banking and financial
        //credit card has 16 digits and begins either with the digit 4 or 5.
        long firstCreditCard;
        long secondCreditCard;
        long thirdCreditCard;
    }
}

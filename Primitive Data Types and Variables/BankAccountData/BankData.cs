// Problem 11. Bank Account Data
// 
// A bank account has a holder name (first name, middle name and last name),
// available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class Bank
{
    static void Main()
    {
        string  firstName       = "Atanas";
        string  middleName      = "Atanasov";
        string  lastName        = "Atanasov";
        decimal balance         = 156.28m;
        string  bankName        = "DSK";
        string  accountIBAN     = "BG80 BNBG 9661 1020 3456 78";
        long    creditCardAAA_1 = 371449635398431;
        long    creditCardAAA_2 = 5500005555555559;
        long    creditCardAAA_3 = 4444444444444448;
    }
}


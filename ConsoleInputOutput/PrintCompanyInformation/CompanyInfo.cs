// Problem 2. Print Company Information
// 
// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.
// Example input:
// 
// program	user
// Company name:	Telerik Academy
// Company address:	31 Al. Malinov, Sofia
// Phone number:	+359 888 55 55 555
// Fax number:	2
// Web site:	http://telerikacademy.com/
// Manager first name:	Nikolay
// Manager last name:	Kostov
// Manager age:	25
// Manager phone:	+359 2 981 981
// Example output:
// 
// Telerik Academy
// Address: 231 Al. Malinov, Sofia
// Tel. +359 888 55 55 555
// Fax: (no fax)
// Web site: http://telerikacademy.com/
// Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981) 
using System;

class CompanyInfo
{
    static void Main()
    {
       
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
       
        Console.WriteLine("Company address:");
        string companyAdress = Console.ReadLine();
       
        Console.WriteLine("Phone number:");
        string companyPhone = Console.ReadLine();
        
        Console.WriteLine("Fax number:");
        string fax = Console.ReadLine();
       
        Console.WriteLine("Web site:");
        string web = Console.ReadLine();
       
        Console.WriteLine("Manager first name:");
        string managerFN = Console.ReadLine();
       
        Console.WriteLine("Manager last name:");
        string managerLN = Console.ReadLine();
       
        Console.WriteLine("Manager age:");
        string age = Console.ReadLine();
       
        Console.WriteLine("Manager phone:");
        string phone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Adress: "+ companyAdress);
        Console.WriteLine("Tel: " +companyPhone);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: "+ web);
        Console.WriteLine("Manager: {0} {1} (age: {2},tel. {3})", managerFN, managerLN, age, phone );
        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName=Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            double balance = double.Parse(Console.ReadLine());
            string bankName = Console.ReadLine();
            string iban = Console.ReadLine();
            long creditCard1 = long.Parse(Console.ReadLine());
            long creditCard2 = long.Parse(Console.ReadLine());
            long creditCard3 = long.Parse(Console.ReadLine());
            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(lastName);
            Console.WriteLine(balance);
            Console.WriteLine(bankName);
            Console.WriteLine(iban);
            Console.WriteLine(creditCard1);
            Console.WriteLine(creditCard2);
            Console.WriteLine(creditCard3);
            Console.ReadLine();


        }
    }
}

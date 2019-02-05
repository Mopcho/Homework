using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string compName = Console.ReadLine();
            string compAddress = Console.ReadLine();
            string compPhone = Console.ReadLine();
            string compFAX = Console.ReadLine();
            string compWeb=Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            if (compFAX=="")
            {
                Console.WriteLine(compName);
                Console.WriteLine(compAddress);
                Console.WriteLine("Tel. {0}",compPhone);
                Console.WriteLine("Fax: (no fax)");
                Console.WriteLine("Web site: {0}",compWeb);
                Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName,managerLastName,managerAge,managerPhone);
              
            }   else
            {
                Console.WriteLine(compName);
                Console.WriteLine(compAddress);
                Console.WriteLine("Tel. {0}", compPhone);
                Console.WriteLine("Fax: {0}",compFAX);
                Console.WriteLine("Web site: {0}", compWeb);
                Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
            }

            Console.ReadLine();
        }
    }
}

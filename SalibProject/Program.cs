using System;

namespace SalibProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert Your FirstName");
            var firstname = Console.ReadLine();
            Console.WriteLine("Please Insert Your LastName");
            var lastname = Console.ReadLine();
            Console.WriteLine("Please insert Password");
            var password = Console.ReadLine();
            Console.WriteLine("Please insert nationalCode");
            var nationalCode = Console.ReadLine();
            Console.WriteLine("Please insert phone number");
            var mobile = Console.ReadLine();
            Console.WriteLine("Please insert Email");
            var email = Console.ReadLine();
            Account myacc = new Account(firstname, lastname, password, nationalCode, mobile, email);

           
        }
    }
}

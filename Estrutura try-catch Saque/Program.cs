using System;
using Estrutura_try_catch_Saque.Entites;
using Estrutura_try_catch_Saque.Entites.Exceptions;
using System.Globalization;

namespace Estrutura_try_catch_Saque
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Enter account data ");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine("Enter amount for withdraw: ");
                double withdrw = double.Parse(Console.ReadLine());

                account.Withdrw(withdrw);


                
            Console.WriteLine("New balance: "+ account.Balance);
            }
            catch (DomainExpection e )
            {
                Console.WriteLine("erro!! " + e.Message);
            }
        }
    }
}

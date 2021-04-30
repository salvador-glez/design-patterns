using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the withdrawal amount:");
            string number = Console.ReadLine();
            int amount = int.Parse(number);

            // Console.WriteLine("Sending an alert by text.");

            //  if (amount > 100)
            //     Console.WriteLine("Sending an alert by email.");

            // if (amount > 1000)
            //     Console.WriteLine("Scheduling alert call.");
                
            Account account = new Account();
            TextAlert text = new TextAlert(account);
            EmailAlert email = new EmailAlert(account);
            CallAlert call = new CallAlert(account);

            account.Withdraw(amount);
        }        
    }
}

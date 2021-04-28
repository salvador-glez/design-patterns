using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountId = "ABC123";
            var password = "Pa55word";

            var securitySystem = new SecuritySystem();
            bool valid = securitySystem.LogIn(accountId, password);
            
            if (!valid)
                throw new Exception("Invalid user or password.");

            var accountSystem = new AccountSystem();
            var account = accountSystem.GetAccount(accountId);
            
            Transaction deposit = new Deposit();
            deposit.Date = DateTime.Now;
            deposit.Amount = 100;
            account.AddTransaction(deposit);

            Transaction withdraw = new Withdraw();
            withdraw.Date = DateTime.Now;
            withdraw.Amount = 50;
            account.AddTransaction(withdraw);

            foreach(var transaction in account.Transactions)
            {
                Console.WriteLine($"Transaction {transaction.GetType().Name} amount {transaction.Amount}");
            }
        
        }
    }
}

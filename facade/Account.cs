using System.Collections.Generic;

namespace Facade
{
    public class Account
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Account()
        {
            
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
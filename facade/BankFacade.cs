using System;
using System.Collections.Generic;

namespace Facade
{
    public class BankFacade
    {
        SecuritySystem _securitySystem;
        AccountSystem _accountSystem;

        Account _account;

        public BankFacade()
        {
            _accountSystem = new AccountSystem();
            _securitySystem = new SecuritySystem();            
        } 

        public void Deposit(int amount, string accountId)
        {
            var account = GetAccount(accountId);

            Transaction deposit = new Deposit();
            deposit.Date = DateTime.Now;
            deposit.Amount = amount;
            account.AddTransaction(deposit);
        }

        public void Withdraw(int amount, string accountId)
        {
            var account = GetAccount(accountId);

            Transaction withdraw = new Withdraw();
            withdraw.Date = DateTime.Now;
            withdraw.Amount = amount;
            account.AddTransaction(withdraw);
        }

        public List<Transaction> GetTransacctions(string accountId)
        {
             var account = GetAccount(accountId);
             return account.Transactions;
        }

        private Account GetAccount(string accountId)
        {
            if (_account != null)
                return _account;

            _account = _accountSystem.GetAccount(accountId);
            return _account;
        }
    }
}
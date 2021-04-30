using System.Collections.Generic;
using System;

namespace Observer
{
    public class Subject
    {
        private List<AccountObserver> observerList = new List<AccountObserver>();
        public void Attach(AccountObserver observer)
        {
            observerList.Add(observer);
        }
        public void Detach(AccountObserver observer)
        {
            observerList.Remove(observer);
        }       
        
        public void Notify(int amount)
        {
            foreach (AccountObserver observer in observerList)
            {
                observer.Update(amount);
            }
        }
    }

    public abstract class AccountObserver
    {
        abstract public void Update(int amount);
    }

    public class TextAlert : AccountObserver
    {
        Account _account;

        public TextAlert(Account account)
        {
            _account = account;
            _account.Attach(this);
        }

        public override void Update(int amount)
        {
            Console.WriteLine("Sending an alert by text.");
        }
    } 

    public class EmailAlert : AccountObserver
    {
        Account _account;

        public EmailAlert(Account account)
        {
            _account = account;
            _account.Attach(this);
        }

        public override void Update(int amount)
        {
            if (amount > 100)
                Console.WriteLine("Sending an alert by email.");
        }
    }    

    public class CallAlert : AccountObserver
    {
        Account _account;

        public CallAlert(Account account)
        {
            _account = account;
            _account.Attach(this);
        }

        public override void Update(int amount)
        {
            if (amount > 1000)
                Console.WriteLine("Scheduling alert call.");
        }
    }       
}
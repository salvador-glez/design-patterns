namespace Observer
{
    public class Account : Subject
    {
        public void Withdraw(int amount)
        {
            //..
            Notify(amount);
        }
    }
}
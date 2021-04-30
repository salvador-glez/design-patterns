using System;

namespace State
{
    public abstract class ShoppingCartStatus
    {
        public abstract void Save();

        public abstract void AddItem(string productName);

        public abstract void Checkout();
    }

    public class CreatedStatus : ShoppingCartStatus
    {
        ShoppingCart _shoppingCart;

        public CreatedStatus(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public override void AddItem(string productName)
        {
            _shoppingCart.Status = new ReadyStatus(_shoppingCart);
            _shoppingCart.Products.Add(productName);
        }

        public override void Checkout()
        {
            _shoppingCart.Status = new RejectedStatus(_shoppingCart);
        }

        public override void Save()
        {
            _shoppingCart.Status = new SavedStatus(_shoppingCart);
        }
    }

    public class SavedStatus : ShoppingCartStatus
    {
        ShoppingCart _shoppingCart;

        public SavedStatus(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public override void AddItem(string productName)
        {
            _shoppingCart.Status = new ReadyStatus(_shoppingCart);
            _shoppingCart.Products.Add(productName);
        }

        public override void Checkout()
        {
            _shoppingCart.Status = new RejectedStatus(_shoppingCart);
        }

        public override void Save()
        {
           _shoppingCart.Status = new SavedStatus(_shoppingCart);
        }
    }

    public class DeletedStatus : ShoppingCartStatus
    {
        ShoppingCart _shoppingCart;

        public DeletedStatus(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public override void AddItem(string productName)
        {
            Console.WriteLine("it is not possible to add the item.");
        }

        public override void Checkout()
        {
            _shoppingCart.Status = new RejectedStatus(_shoppingCart);
        }

        public override void Save()
        {
            
        }
    }

    public class ApprovedStatus : ShoppingCartStatus
    {
        ShoppingCart _shoppingCart;

        public ApprovedStatus(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public override void AddItem(string productName)
        {
            Console.WriteLine("it is not possible to add the item.");
        }

        public override void Checkout()
        {
            _shoppingCart.Status = new RejectedStatus(_shoppingCart);
        }

        public override void Save()
        {
            _shoppingCart.Status = new SavedStatus(_shoppingCart);
        }
    }

    public class ReadyStatus : ShoppingCartStatus
    {
        ShoppingCart _shoppingCart;

        public ReadyStatus(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public override void AddItem(string productName)
        {
            _shoppingCart.Status = new ReadyStatus(_shoppingCart);
            _shoppingCart.Products.Add(productName);
        }

        public override void Checkout()
        {
           _shoppingCart.Status = new ApprovedStatus(_shoppingCart);
        }

        public override void Save()
        {
           _shoppingCart.Status = new SavedStatus(_shoppingCart);
        }
    }

    public class RejectedStatus : ShoppingCartStatus
    {
        ShoppingCart _shoppingCart;

        public RejectedStatus(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public override void AddItem(string productName)
        {
            _shoppingCart.Status = new ReadyStatus(_shoppingCart);
            _shoppingCart.Products.Add(productName);
        }

        public override void Checkout()
        {
            _shoppingCart.Status = new RejectedStatus(_shoppingCart);
        }

        public override void Save()
        {
            _shoppingCart.Status = new SavedStatus(_shoppingCart);
        }
    }
}
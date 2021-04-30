using System;
using System.Collections.Generic;

namespace State
{
    public class ShoppingCart
    {
        public ShoppingCartStatus Status { get; set; }
        public List<string> Products { get; set; } = new List<string>();
        public ShoppingCart()
        {
            Status = new CreatedStatus(this);
        }

        public void Save()
        {
            // if (Status != "Deleted")
            //     Status = "Saved";
            Status.Save();
        }

        public void AddItem(string productName)
        {
            // if (Status != "Deleted" && Status != "Approved")
            // {
            //     Status = "Ready";
            //     Products.Add(productName);
            // }
            // else
            // {
            //     Console.WriteLine("it is not possible to add the item.");
            // }
            Status.AddItem(productName);
        }

        public void Checkout()
        {
            // if (Status == "Ready")
            // {
            //     Status = "Approved";
            // }
            // else
            // {
            //     Status = "Rejected";
            // }

            Status.Checkout();
        }
    }
}
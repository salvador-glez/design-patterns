using System;
using System.Collections.Generic;

namespace State
{
    public class ShoppingCart
    {
        public string Status { get; set; }
        private List<string> Products { get; set; } = new List<string>();
        public ShoppingCart()
        {
            Status = "Created";
        }

        public void Save()
        {
            if (Status != "Deleted")
                Status = "Saved";
        }

        public void AddItem(string productName)
        {
            if (Status != "Deleted" && Status != "Approved")
            {
                Status = "Ready";
                Products.Add(productName);
            }
            else
            {
                Console.WriteLine("it is not possible to add the item.");
            }
            
        }

        public void Checkout()
        {
            if (Status == "Ready")
            {
                Status = "Approved";
            }
            else
            {
                Status = "Rejected";
            }
        }
    }
}
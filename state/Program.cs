using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart sc = new ShoppingCart();
            Console.WriteLine($"ShoppingCart Status: {sc.Status}");

            sc.Checkout();
            Console.WriteLine($"ShoppingCart Status: {sc.Status}");

            sc.Save();
            Console.WriteLine($"ShoppingCart Status: {sc.Status}");

            sc.AddItem("Item001");
            Console.WriteLine($"ShoppingCart Status: {sc.Status}");

            sc.Checkout();
            Console.WriteLine($"ShoppingCart Status: {sc.Status}");
        }
    }
}

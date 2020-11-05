using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // A delegate as foundation, all it is, is you pass in a method instead
    // of a property or instead of a variable
    class Program
    {
        static ShopingCartModel cart = new ShopingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalcilateLevelDiscount, AlerstUser):C2}"); // With delegates you just pas in the name of the method
            Console.WriteLine();

            // Calling the delegates with anonymos methods
            decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"The subtotal for cart 2 is {subTotal:C2}"),
                (products, subTotal) => {
                    if (products.Count > 3)
                        return subTotal * 0.5M;
                    else
                        return subTotal;
                }, 
                (message) => Console.WriteLine($"Cart 2 Alert: {message}"));
            Console.WriteLine($"The total for cart 2 is {total:C2}");

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit the application...");
            Console.ReadLine();
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void AlerstUser(string message)
        {
            Console.WriteLine(message);
        }

        private static decimal CalcilateLevelDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
                return subTotal * 0.80M;
            else if (subTotal > 50)
                return subTotal * 0.85M;
            else if (subTotal > 10)
                return subTotal * 0.90M;
            else
                return subTotal;

        }
        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}

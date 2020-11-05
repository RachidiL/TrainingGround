using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach(IProductModel prod in cart)
            {
                prod.ShipItem(customer);
                if (prod is IDigitalProductModel digital) //could also do it on the class instead of the interface
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadLeft} downloads left");
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Rachidi",
                LastName = "Lubaki",
                City = "Düsseldorf",
                EmailAddress = "rachidi@Lubaki.com",
                PhoneNumber = "333-777-555-999"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel {Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "Chang is coming" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson source code" });

            return output;
        }
    }
}

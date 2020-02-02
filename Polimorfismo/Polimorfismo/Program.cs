using Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products:");
            int n = 1;
            int.TryParse(Console.ReadLine(), out n);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used, inported (c/u/i)?");
                string type = Console.ReadLine();
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = 0;
                double.TryParse(Console.ReadLine(), out price);
                if (type == "c")
                {
                    products.Add(new Product(name, price));
                }
                else if(type == "u")
                {
                    Console.Write("Manufactured date (DD/MM/YYYY):");
                    DateTime date;
                    DateTime.TryParse(Console.ReadLine(), out date);
                    products.Add(new UsedProduct(name, price, date));
                }
                else if (type == "i")
                {
                    Console.Write("Customs fee:");
                    double customsFee = 0;
                    double.TryParse(Console.ReadLine(), out customsFee);
                    products.Add(new InportedProduct(name, price, customsFee));
                }
                
            }
            Console.WriteLine("PRICE TEGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }

        }
    }
}

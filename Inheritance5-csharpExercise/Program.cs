using System;
using System.Globalization;
using System.Collections.Generic;
using Inheritance5_csharpExercise.Entities;

namespace Inheritance5_csharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of produts: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customnsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customnsFee));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuFac = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manuFac));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}

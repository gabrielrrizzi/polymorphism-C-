using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products:");
            int p = int.Parse(Console.ReadLine());
            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char typeproduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (typeproduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date =DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }else if(typeproduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("Price tags: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}

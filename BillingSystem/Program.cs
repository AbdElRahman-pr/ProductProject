using BillingSystem;
using System;
using System.Collections.Generic;

namespace BillingSystem
{
    class Product
    {
        public string Name { get; set; }


        public double Price { get; set; }


        public int Quantity { get; set; }


        public Product (string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double GetTotal()
        {
            return Price * Quantity;
        }
    }

    class Program
    {
        static void Main (string [] args)
        {
            List<Product> products = new List<Product> ();


            Console.WriteLine("Simple Billing System");
            Console.WriteLine("--------------------------");


            while (true )
            {
                Console.Write("Enter the product name (or write an 'Exit' to end) :");
                string name = Console.ReadLine ();


                if (name.ToLower() == "خروج" || name.ToLower() == "exit")
                    break;


                Console.Write("Enter the product price :");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the quantity :");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Product p = new Product (name, price, quantity);
                products.Add (p);

                Console.WriteLine("The product has been successfully added  ");

            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("All product have been entered.\n ");


            double subtotal = 0;
            foreach (Product p in products)
            {
             subtotal += p.GetTotal();
            }
            double taxRate = 0.15;
            double tax = subtotal * taxRate;
            double total = subtotal + tax;

            Console.WriteLine("\n--------- The Bill ---------");
            Console.WriteLine("{0,-20} {1,5} {2,5:F2} {3,9:F2} " ,"Product"  ,"Quantity  ", " Price  ", " Total");
            Console.WriteLine(new string('-', 50));
            foreach (Product p in products)
            {
                Console.WriteLine("{0,-20} {1,5} {2,10:F2} {3,12:F2}",p.Name, p.Quantity, p.Price, p.GetTotal());
            }
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("{0,3} {1,30:F2}", "SubTotal:          ", subtotal);
            Console.WriteLine("{0,3} {1,30:F2}", "The Tax (15%):     ", tax);
            Console.WriteLine("{0,3} {1,30:F2}", "The Final Total:   ", total);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Thank You For Using The Billing System.");

        }

    }
}
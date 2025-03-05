//Write a program that:
//•	Read an integer number n and n lines of products
//•	Print a numbered list of all the products ordered by name

using System;

namespace ProductList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            string[] products = new string[n];

            for (int i = 0; i < n; i++)
            {
                products[i] = Console.ReadLine();
            }


            Array.Sort(products);


           
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
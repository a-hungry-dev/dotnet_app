using System;
using dotnetapp.Models;
using Newtonsoft.Json;

namespace dotnetapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2008, 12, 28);
            product.Price = 3.99M;
            product.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(product);

            Console.WriteLine(output);
        }
    }
}

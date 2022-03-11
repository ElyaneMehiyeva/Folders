using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product Chocolate1 = new Product();
            Chocolate1.Name = "Adicto";
            Chocolate1.BrandName = "Zara";
            Chocolate1.Price = 1000;

            Product Chocolate2 = new Product
            {
                Name = "Snickers",
                BrandName = "Empty",
                Price = 500
            };
            Product Chocolate3 = new Product
            {
                Name = "Alpen Gold",
                BrandName = "Nest",
                Price = 2000
            };
            Product Chocolate4 = new Product();
            Chocolate4.Name = "Mars";
            Chocolate4.BrandName = "Fabric";
            Chocolate4.Price = 300;

            //Console.WriteLine(Chocolate1.GetData());
            //Console.WriteLine(Chocolate2.GetData());
            //Console.WriteLine(Chocolate3.GetData());
            //Console.WriteLine(Chocolate4.GetData());
            Product[] Chocolates = {Chocolate1,Chocolate2,Chocolate3,Chocolate4};
            foreach(Product Search in SearchProduct(Chocolates, 400.5, 1500.50))
            {
                Console.WriteLine(Search.GetData());
            }

        }
        static Product[] SearchProduct(Product[] Products,double minPrice, double maxPrice)
        {
            Product[] newProducts = new Product[Products.Length];
            int index = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                
                if(Products[i].Price<maxPrice && Products[i].Price>minPrice)
                {
                    newProducts[index] = Products[i];
                    index++;
                }
            }
            return newProducts;
        }


    }
}

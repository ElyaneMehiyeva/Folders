using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Product
    {
        public string Name;
        public string BrandName;
        public int Price;
        public string GetData()
        {
            string data = $"Product Name : {Name} | Product BrandName {BrandName} | Product Price : {Price}";
            return data;
        }
    }

}

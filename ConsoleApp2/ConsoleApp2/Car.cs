using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public string GetData()
        {
            string data = "Car Name :" + name + " Car Brand : " + Brand + " Car Model :" + Model + " Car Color :" + color;
            return data;
        }
    }
}

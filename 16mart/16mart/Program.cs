using System;

namespace _16mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the UserName :");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter the Password :");
            string Password = Console.ReadLine();

            User user156890 = new User(UserName);
            user156890.Password = Password;

            Console.WriteLine("----------Result----------");
            Console.WriteLine(user156890.GetInfo());
            // The End Yatirsan ?Burdasan ?
        }
    }
}

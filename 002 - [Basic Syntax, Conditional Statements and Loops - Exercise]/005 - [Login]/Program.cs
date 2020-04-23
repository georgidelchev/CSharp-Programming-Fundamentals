using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string passwordInsert = Console.ReadLine();
            int counter = 0;
            while (passwordInsert != password)
            {

                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                passwordInsert = Console.ReadLine();
            }
            if (passwordInsert == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}

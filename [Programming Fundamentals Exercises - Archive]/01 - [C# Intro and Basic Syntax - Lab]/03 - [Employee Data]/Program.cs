using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\n" +
                              $"Age: {age}\n" +
                              $"Employee ID: {id:d8}\n" +
                              $"Salary: {salary:f2}");
        }
    }
}

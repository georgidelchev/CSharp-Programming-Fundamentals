using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthType = int.Parse(Console.ReadLine());
            string[] month = { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December", };

            if (monthType > 12 || monthType < 1)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(month[monthType - 1]);
            }
        }
    }
}

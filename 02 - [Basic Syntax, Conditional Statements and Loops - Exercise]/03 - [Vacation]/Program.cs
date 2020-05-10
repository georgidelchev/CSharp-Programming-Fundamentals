using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double discount = 0;
            double sumPerOne = 0;
            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    sumPerOne = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    sumPerOne = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    sumPerOne = 10.46;
                }

                if (groupNumber >= 30)
                {
                    discount = 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    sumPerOne = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    sumPerOne = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    sumPerOne = 16.00;
                }

                if (groupNumber >= 100)
                {
                    groupNumber -= 10;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    sumPerOne = 15.00;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    sumPerOne = 20.00;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    sumPerOne = 22.50;
                }

                if (groupNumber >= 10 && groupNumber <= 20)
                {
                    discount = 0.05;
                }
            }

            double totalSum = sumPerOne * groupNumber;
            totalSum = totalSum - (totalSum * discount);

            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}

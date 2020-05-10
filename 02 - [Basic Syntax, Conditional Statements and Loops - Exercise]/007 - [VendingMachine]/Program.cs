using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                double coinsInsert = double.Parse(input);
                if (coinsInsert == 0.1 || coinsInsert == 0.2 || coinsInsert == 0.5
                    || coinsInsert == 1 || coinsInsert == 2)
                {
                    sum += coinsInsert;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinsInsert}");
                }
                input = Console.ReadLine();
            }
            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;

            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (sum >= nutsPrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= nutsPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (sum >= waterPrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= waterPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum >= crispsPrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= crispsPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum >= sodaPrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= sodaPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sum >= cokePrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= cokePrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

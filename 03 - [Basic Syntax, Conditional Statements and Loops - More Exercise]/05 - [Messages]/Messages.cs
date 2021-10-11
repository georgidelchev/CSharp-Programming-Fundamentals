using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            var result = string.Empty;
            for (int i = 0; i < linesCount; i++)
            {
                var number = Console.ReadLine();
                if (number == "0")
                {
                    result += " ";
                    continue;
                }

                var digitsCount = number.Length;
                var mainDigit = int.Parse(number[0].ToString());
                var offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                var letterIndex = offset + (digitsCount - 1);
                letterIndex += 97;
                result += (char)letterIndex;
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class CurrencyConverter
    {
        internal static void Start()
        {
            Console.WriteLine("++++ currency converter ++++");
            Console.WriteLine();
            Console.WriteLine("write 0 to finish");
            CurrencySum();
        }

        private static void CurrencySum()
        {
            int sum = 0;
            int numbers = 1;
            do
            {
                Console.Write("Write a number to add tot he total: ");
                numbers = int.Parse(Console.ReadLine());
                sum += numbers;

            } while (numbers != 0);

            Console.Write("Name of the foreign currency: ");
            string currency = Console.ReadLine().ToUpper();
            Console.Write("Exchange rate: ");
            int rate = int.Parse(Console.ReadLine());
            int value = sum / rate;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("The sum is: " + sum);

            Console.WriteLine(sum + " SEK is converted to " + value + " " + currency + " at the rate of "+ rate + " SEK/"+currency);

        }
    }
}

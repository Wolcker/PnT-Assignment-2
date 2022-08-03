using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class WholeNumbersForAdd
    {
        internal static void Start()
        {
            Console.WriteLine("**** Summation of whole numbers ****");
            Console.WriteLine("       using a for statement");
            Console.WriteLine();
            Console.Write("Number of whole numbers you want to add? ");
            int numbers = int.Parse(Console.ReadLine());

            Summation(numbers);
        }

        private static void Summation(int numbers)
        {
            int sum = 0;
            for (int i=1; i <= numbers; i++)
            {
                Console.Write("Please give the value for number no " + i +": ");
                int x = int.Parse(Console.ReadLine());
                sum += x;
            }

            Console.WriteLine("The sum is: " + sum);
        }
    }
}

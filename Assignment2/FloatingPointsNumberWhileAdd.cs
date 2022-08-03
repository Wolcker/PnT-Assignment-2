using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class FloatingPointsNumberWhileAdd
    {
        internal static void Start()
        {

            Console.WriteLine("**** Summation of real numbers ****");
            Console.WriteLine("       using a while loop");
            Console.WriteLine();
            Console.WriteLine("write 0 to finish"); 
            Console.WriteLine("-----------------------------------------------");
            Summation();
            
        }

        private static void Summation()
        {
            int numbers = 1;
            int sum = 0;
            while (numbers != 0)
            {
                Console.Write("Write a number to add to the sum: ");
                numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}

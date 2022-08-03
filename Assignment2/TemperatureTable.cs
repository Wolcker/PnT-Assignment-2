using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class TemperatureTable
    {
        internal static void Start()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("              Table converter");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Convert from Fahrenheit to Celsius          : 1");
            Console.WriteLine("Convert from Celsius to Fahrenheit          : 2");
            Console.WriteLine("Exit                                        : 0");
            Console.Write("What do you want to do? ");
            double tmpvalue = int.Parse(Console.ReadLine());
            MenuSwitch(tmpvalue);

            
            
        }

        private static void MenuSwitch(double tmpvalue)
        {
            Console.WriteLine(tmpvalue);
            switch (tmpvalue) {
                case 1:
                    ConvertToC();
                    break;
                case 2:
                    ConvertToF();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Please choose a correct number from the list above");
                    Start();
                    break;
                    }
        }

        private static void ConvertToC()
        {
            for (int i = 0; i <= 100; i = i + 4)
            {
                double c = Math.Round((i - 32) * 5.0 / 9.0);
                Console.WriteLine(i+" F    =    " + c + " C");
            }
        }

        private static void ConvertToF()
        {
            for (int i = 0; i <= 100; i = i + 4)
            {
                double f = Math.Round(9.0/5.0*i+32);
                Console.WriteLine(i + " C    =    " + f + " F");
            }
        }
    }
}

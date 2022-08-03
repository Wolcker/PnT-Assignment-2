using System;

namespace Assignment2
{
    internal class Menu
    {
        public Menu()
        {
        }

        internal void Start()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                 MAIN MENU");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("     Whole Numbers With For                 : 1");
            Console.WriteLine("     Floating Point Numbers While loop      : 2");
            Console.WriteLine("     Currency Converter With Do While Loop  : 3");
            Console.WriteLine("     Work Schedule                          : 4");
            Console.WriteLine("     Temperature Table                      : 5");
            Console.WriteLine("     Exit the Program                       : 0");
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Your choice: ");
            int number = int.Parse(Console.ReadLine());
            MenuSwitch(number);

        }

        public void MenuSwitch(int number)
        {
            Console.WriteLine(number);
            switch (number)
            {
                case 1:
                    WholeNumbersForAdd.Start();
                    Start();
                    break;
                case 2:
                    FloatingPointsNumberWhileAdd.Start();
                    Start();
                    break;
                case 3:
                    CurrencyConverter.Start();
                    Start();
                    break;
                case 4:
                    WorkingSchedule.Start();
                    Start();
                    break;
                case 5:
                    TemperatureTable.Start();
                    Start();
                    break;
                case 0:
                    Console.WriteLine("Thanks for useing this program!");
                    break;
                default: 
                    Console.WriteLine("Please choose a CORRECT number");
                    Start();

                    break;


            }
        }

    }
}
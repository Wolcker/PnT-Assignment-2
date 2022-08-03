using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class WorkingSchedule
    {
        internal static void Start()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("YOUR SCHEDULE PROGRAM");
            Console.WriteLine("Select from the menu which type of scheduale you want to see.");
            Console.WriteLine("");
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of nights to work.");
            Console.WriteLine("0 Return to the Main Menu.");
            Console.WriteLine("");
            Console.Write("Your choice: ");
            int number = int.Parse(Console.ReadLine());
            ScheduleListSwitch(number);

        }

        private static void ScheduleListSwitch(int number)
        {
            switch(number) {
                case 1:
                    weekendSchedule();
                    Start();
                    break;
                case 2:
                    nightSchedule();
                    Start();
                    break;
                case 0: 
                    break;
                default:
                    Console.WriteLine("Please choose a CORRECT number from the list.");
                    Start();
                    break;
            }
        }

        private static void nightSchedule()
        {
            for(int i=6; i <= 52; i=i+5)
            {
                Console.Write("          Week " +i);
            }
            Console.WriteLine("");
        }

        private static void weekendSchedule()
        {
            for (int i = 1; i <= 52; i = i + 3)
            {
                Console.Write("          Week " + i);
            }
            Console.WriteLine("");
        }
    }
}

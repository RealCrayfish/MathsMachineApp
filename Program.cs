using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsMachine;

namespace MathsMachine
{
    class Program
    {
        public static Utilities utils = new Utilities();

        public static void Main(string[] args)
        {
            // Menu
            int operation;
            bool quit = false;
            while (!quit)
            {
                operation = 0;

                Console.Clear();
                Utilities.ForeBlue();
                Console.WriteLine("\n   Welcome to the MathsMachine! Please select an operation:\n     1: Calculator\n     2: Mass Converter\n     3: *\n     4: /\n     5: Quit\n\n");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        operation = 1;
                        break;
                    case ConsoleKey.D2:
                        operation = 2;
                        break;
                    case ConsoleKey.D3:
                        operation = 3;
                        break;
                    case ConsoleKey.D4:
                        operation = 4;
                        break;
                    case ConsoleKey.D5:
                        operation = 5;
                        break;
                    default:
                        Thread.Sleep(500);
                        Console.Clear();
                        Utilities.ForeRed();
                        Console.WriteLine("\n   Invalid option, Please try again");
                        Thread.Sleep(2000);
                        break;
                }
                
                if (operation == 5) { quit = true; }
                else if (operation == 1) { Calculator.NewCalculator(); }
                else if (operation == 2) { MassConverter.NewConverter(); }
            }

            Utilities.ForeColor(ConsoleColor.White);
            Console.Clear();
        }
    }
}

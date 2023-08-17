using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MathsMachine;

namespace MathsMachine
{
    public class Calculator
    { 
        public static void NewCalculator()
        {
            // Menu
            bool quit = false;
            while (true)
            {
                Console.Clear();
                int operation = 0;
                Utilities.ForeBlue();
                Console.WriteLine("\n   Welcome to the Calculator! Please select an operation:\n     1: +\n     2: -\n     3: *\n     4: /\n     5: Exit Calculator\n\n");


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        CalcAddition();
                        break;
                    case ConsoleKey.D2:
                        CalcSubtraction();
                        break;
                    case ConsoleKey.D3:
                        CalcMultiplication();
                        break;
                    case ConsoleKey.D4:
                        CalcDivision();
                        break;
                    case ConsoleKey.D5:
                        quit = true;
                        break;
                    default:
                        Thread.Sleep(500);
                        Utilities.ForeRed();
                        Console.WriteLine("\n\n   Invalid option, Please try again", ConsoleColor.Red);
                        Thread.Sleep(2000);
                        break;
                }

                if (quit)
                {
                    break;
                }
            }
        }
        private static void CalcAddition()
        {
            int input1;
            int input2;
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter First Number: ");
                try
                {
                    input1 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter Second Number: ");
                try
                {
                    input2 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Utilities.ForeBlue();
            Console.WriteLine("\n   Output: " + (input1 + input2));
            Thread.Sleep(3000);
        }

        private static void CalcSubtraction()
        {
            int input1;
            int input2;
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter First Number: ");
                try
                {
                    input1 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter Second Number: ");
                try
                {
                    input2 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Utilities.ForeBlue();
            Console.WriteLine("\n   Output: " + (input1 - input2));
            Thread.Sleep(3000);
        }

        private static void CalcMultiplication()
        {
            int input1;
            int input2;
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter First Number: ");
                try
                {
                    input1 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter Second Number: ");
                try
                {
                    input2 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Utilities.ForeBlue();
            Console.WriteLine("\n   Output: " + (input1 * input2));
            Thread.Sleep(3000);
        }

        private static void CalcDivision()
        {
            int input1;
            int input2;
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter First Number: ");
                try
                {
                    input1 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter Second Number: ");
                try
                {
                    input2 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Utilities.ForeRed();
                    Console.WriteLine("\n   Invalid input, Try again!");
                    Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Utilities.ForeBlue();
            Console.WriteLine("\n   Output: " + (input1 / input2));
            Thread.Sleep(3000);
        }
    }
}

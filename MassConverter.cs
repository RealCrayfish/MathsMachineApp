using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MathsMachine;

namespace MathsMachine
{
    class MassConverter
    {
        public static void NewConverter()
        {
            bool quit = false;
            while (true)
            {
                Console.Clear();
                int operation = 0;
                Utilities.ForeBlue();
                Console.WriteLine("\n   Welcome to the Mass Converter! Please select an operation:\n     1: KG -> lb\n     2: lb -> KG\n     3: Exit Calculator\n\n");


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        MassMetricToInferior();
                        break;
                    case ConsoleKey.D2:
                        MassInferiorToMetric();
                        break;
                    case ConsoleKey.D3:
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

        private static void MassMetricToInferior()
        {
            double input1;
            
            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter Mass (KG): ");
                try
                {
                    input1 = double.Parse(Console.ReadLine());
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
            Console.WriteLine("\n   Output: " + (input1 * 2.20462262185) + "lbs");
            Thread.Sleep(3000);
        }

        private static void MassInferiorToMetric()
        {
            double input1;

            while (true)
            {
                Console.Clear();
                Utilities.ForeBlue();
                Console.Write("\n   Enter Mass (lbs): ");
                try
                {
                    input1 = double.Parse(Console.ReadLine());
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
            Console.WriteLine("\n   Output: " + (input1 / 2.20462262185) + "KG");
            Thread.Sleep(3000);
        }
    }
}

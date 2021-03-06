﻿using System;
using System.Diagnostics;
using AdventOfCode.Days.One;
using AdventOfCode.Days.Two;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main()
        {
            var stopwatch = new Stopwatch();
            
            stopwatch.Start();
            Console.WriteLine($"Day One - Part One {ReportRepair.Answer(Part.One)}");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} \n", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            Console.WriteLine($"Day One - Part Two {ReportRepair.Answer(Part.Two)}");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} \n", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            Console.WriteLine($"Day Two - Part One {PasswordPhilosophy.Answer(Part.One)}");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} \n", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            Console.WriteLine($"Day Two - Part Two {PasswordPhilosophy.Answer(Part.Two)}");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} \n", stopwatch.Elapsed);

            stopwatch.Reset();
        }
    }
}

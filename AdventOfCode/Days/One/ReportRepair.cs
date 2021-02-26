using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days.One
{
    public static class ReportRepair
    {
        public static int Answer(Enum part)
        {
            return part switch
            {
                Part.One => PartOne(),
                Part.Two => PartTwo(),
                _ => 0
            };
        }

        private static int PartOne()
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"Days\One\input.txt");
            var report = File.ReadAllLines(filepath).ToList().Select(int.Parse).ToList();

            const int targetValue = 2020;

            report.Sort();

            var i = 0;
            var j = report.Count - 1;

            while (true)
            {
                if (report[i] + report[j] == targetValue)
                {
                    return report[i] * report[j];
                }
                else if (report[i] + report[j] > targetValue)
                {
                    j--;
                } else if (report[i] + report[j] < targetValue)
                {
                    i++;
                }
            }
        }

        private static int PartTwo()
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"Days\One\input.txt");
            var report = File.ReadAllLines(filepath).ToList().Select(int.Parse).ToArray();

            const int targetValue = 2020;

            for (var i = 0; i < report.Length - 1; i++)
            {
                for (var j = 0; j < report.Length - 1; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    for (var k = 0; k < report.Length - 1; k++)
                    {
                        if (j == k)
                        {
                            continue;
                        }

                        if (report[i] + report[j] + report[k] == targetValue)
                        {
                            return report[i] * report[j] * report[k];
                        }
                    }
                }
            }

            return 0;
        }
    }
}
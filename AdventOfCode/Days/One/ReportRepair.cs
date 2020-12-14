using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days.One
{
    public static class ReportRepair
    {
        public static int Answer(Enum part)
        {
            switch (part)
            {
                case Part.One:
                    return PartOne();
                case Part.Two:
                     return PartTwo();
                default:
                    return 0;
            }
        }

        private static int PartOne()
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

                    var firstTerm = report[i];
                    var secondTerm = report[j];

                    if (firstTerm + secondTerm == targetValue)
                    {
                        return firstTerm * secondTerm;
                    }

                }
            }

            return 0;
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

                        var firstTerm = report[i];
                        var secondTerm = report[j];
                        var thirdTerm = report[k];

                        if (firstTerm + secondTerm + thirdTerm == targetValue)
                        {
                            return firstTerm * secondTerm * thirdTerm;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
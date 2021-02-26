using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days.Two
{
    public static class PasswordPhilosophy
    {
        public static int Answer(Enum part)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"Days\Two\input.txt");
            var input = File.ReadAllLines(filepath).ToList();

            var validPasswordCount = 0;

            foreach (var item in input)
            {
                var first = int.Parse(item.Split(' ')[0].Split('-')[0]);
                var last = int.Parse(item.Split(' ')[0].Split('-')[1]);
                var symbol = char.Parse(item.Split(' ')[1].Remove(1));
                var password = item.Split(' ')[2];


                switch (part)
                {
                    case Part.One:
                        if (FrequencyPolicy(first, last, symbol, password))
                        {
                            validPasswordCount++;
                        }
                        break;
                    case Part.Two:
                        if (PositionPolicy(first, last, symbol, password))
                        {
                            validPasswordCount++;
                        }
                        break;
                }
            }

            return validPasswordCount;
        }

        private static bool FrequencyPolicy(int first, int last, char symbol, string password)
        {
            var count = password.Count(character => character == symbol);

            return count >= first && count <= last;
        }

        private static bool PositionPolicy(int first, int last, char symbol, string password)
        {
            return password[first - 1] == symbol ^ password[last - 1] == symbol;
        }
    }
}

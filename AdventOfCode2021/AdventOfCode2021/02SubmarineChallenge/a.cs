using System;

namespace AdventOfCode2021._02SubmarineChallenge
{
    public static class SolutionB
    {
        public static void Run()
        {
            var input = SolutionBData.Input;

            int x = 0;
            int y = 0;
            int angle = 0;

            foreach (var instruction in input)
            {
                if (instruction.Key == "forward")
                {
                    x += instruction.Value;
                    y += instruction.Value * angle;
                }

                if (instruction.Key == "down")
                {
                    angle += instruction.Value;
                }

                if (instruction.Key == "up")
                {
                    angle -= instruction.Value;
                }
            }

            Console.WriteLine($"Horizontal: {x}, Depth {y}");
            Console.WriteLine($"Position: {x * y}");
        }
    }
}

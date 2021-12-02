using System;
using System.Linq;

namespace AdventOfCode2021._01SumChallenge
{
    public class SolutionA
    {
        public static void Run()
        {
            var data = new SolutionAData().GetInput().ToArray();

            var pointer = 0;
            int lastSum = -1;
            var counter = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data.Length - pointer >= 3)
                {
                    var sum = data[pointer] + data[pointer + 1] + data[pointer + 2];

                    if (lastSum != -1)
                    {
                        if (sum > lastSum)
                        {
                            counter++;
                        }
                    }

                    pointer++;
                    lastSum = sum;
                }
            }

            Console.WriteLine(counter);

            Console.ReadLine();
        }
    }
}

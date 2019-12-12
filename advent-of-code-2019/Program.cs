using advent_of_code_2019.Solvers.Day2;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace advent_of_code_2019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var programInstructions = File.ReadAllText("./Solvers/Day2/Input.txt")
                .Split(',')
                .Select(pi => Convert.ToInt32(pi))
                .ToList();

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var combination = Puzzle2Solver.SolvePuzzle(programInstructions);

            stopWatch.Stop();

            Console.WriteLine("----- Day 2 Puzzle 2 -----");
            Console.WriteLine($"The noun/verb combination to produce an output of 19690720 was {combination}.");
            Console.WriteLine($"Answer was calculated in {(double)stopWatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond}ms.");

            Console.ReadLine();
        }
    }
}

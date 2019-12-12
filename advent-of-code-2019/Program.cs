using advent_of_code_2019.Solvers.Day1;
using System;
using System.IO;
using System.Linq;

namespace advent_of_code_2019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var moduleMasses = File.ReadAllLines("./Solvers/Day1/Day1Input.txt")
                .Select(mm => Convert.ToInt32(mm));

            var totalFuelAmount = Puzzle2Solver.SolvePuzzle(moduleMasses);

            Console.WriteLine($"The spacecraft needs {totalFuelAmount} units of fuel to launch.");

            Console.ReadLine();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace advent_of_code_2019.Solvers.Day1
{
    public static class Puzzle1Solver
    {
        /// <summary>
        /// Calculates the total amount of fuel required to launch a spacecraft
        /// made up of a collection of modules.
        /// </summary>
        /// <param name="moduleMasses">Path to file containing masses of all modules in spacecraft.</param>
        /// <returns>Total amount of fuel needed to launch the specified spacecraft.</returns>
        public static int SolvePuzzle(IEnumerable<int> moduleMasses)
        {
            return moduleMasses.Select(mm =>
            {
                return (mm / 3) - 2;
            }).Sum();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace advent_of_code_2019.Solvers.Day1
{
    public static class Puzzle2Solver
    {
        /// <summary>
        /// Calculates the total amount of fuel required to launch a spacecraft
        /// made up of a collection of modules. Accounts for fuel needed to launch
        /// mass of fuel itself.
        /// </summary>
        /// <param name="moduleMasses">Path to file containing masses of all modules in spacecraft.</param>
        /// <returns>Total amount of fuel needed to launch the specified spacecraft.</returns>
        public static int SolvePuzzle(IEnumerable<int> moduleMasses)
        {
            return moduleMasses.Select(mm =>
            {
                return CalculateFuelNeededForFuelMass(mm);
            }).Sum();
        }

        private static int CalculateFuelNeededForFuelMass(int currentMass)
        {
            var fuelNeeded = (currentMass / 3) - 2;

            if (fuelNeeded <= 0)
            {
                return 0;
            }
            else
            {
                return fuelNeeded + CalculateFuelNeededForFuelMass(fuelNeeded);
            }
        }
    }
}

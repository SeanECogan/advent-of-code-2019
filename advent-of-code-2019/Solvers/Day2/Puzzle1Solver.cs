using System.Collections.Generic;

namespace advent_of_code_2019.Solvers.Day2
{
    public static class Puzzle1Solver
    {
        /// <summary>
        /// Determines the state the IntCode program was in before the last computer caught fire.
        /// </summary>
        /// <param name="programInstructions">IntCode program instruction codes.</param>
        /// <returns>State of the first program instruction after the IntCode program halts.</returns>
        public static int SolvePuzzle(List<int> programInstructions)
        {
            var currentIndex = 0;

            while (programInstructions[currentIndex] != 99)
            {
                var opCode = programInstructions[currentIndex];

                var firstLookup = programInstructions[currentIndex + 1];
                var secondLookup = programInstructions[currentIndex + 2];
                var resultLookup = programInstructions[currentIndex + 3];
                var result = 0;

                switch(opCode)
                {
                    case 1:
                        result = programInstructions[firstLookup] + programInstructions[secondLookup];
                        programInstructions[resultLookup] = result;
                        break;

                    case 2:
                        result = programInstructions[firstLookup] * programInstructions[secondLookup];
                        programInstructions[resultLookup] = result;
                        break;

                    default:
                        break;
                }

                currentIndex += 4;
            }

            return programInstructions[0];
        }
    }
}

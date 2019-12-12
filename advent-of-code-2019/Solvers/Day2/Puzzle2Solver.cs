using System;
using System.Collections.Generic;

namespace advent_of_code_2019.Solvers.Day2
{
    public static class Puzzle2Solver
    {
        /// <summary>
        /// Determines the noun/verb combination that causes the program to output 19690720.
        /// </summary>
        /// <param name="programInstructions">IntCode program instruction codes.</param>
        /// <returns>Code determined from noun/verb combination that caused the program to output 19690720.</returns>
        public static int SolvePuzzle(List<int> programInstructions)
        {
            var noun = 0;
            var verb = 0;

            for (int n = 0; n <= 99; n++)
            {
                for (int v = 0; v <= 99; v++)
                {
                    var currentIndex = 0;

                    var currentProgramInstructions = new List<int>();
                    currentProgramInstructions.AddRange(programInstructions);
                    currentProgramInstructions[1] = n;
                    currentProgramInstructions[2] = v;

                    while (currentProgramInstructions[currentIndex] != 99)
                    {
                        var opCode = currentProgramInstructions[currentIndex];

                        var firstLookup = currentProgramInstructions[currentIndex + 1];
                        var secondLookup = currentProgramInstructions[currentIndex + 2];
                        var resultLookup = currentProgramInstructions[currentIndex + 3];
                        var result = 0;

                        switch (opCode)
                        {
                            case 1:
                                result = currentProgramInstructions[firstLookup] + currentProgramInstructions[secondLookup];
                                currentProgramInstructions[resultLookup] = result;
                                break;

                            case 2:
                                result = currentProgramInstructions[firstLookup] * currentProgramInstructions[secondLookup];
                                currentProgramInstructions[resultLookup] = result;
                                break;

                            default:
                                break;
                        }

                        currentIndex += 4;
                    }

                    if (currentProgramInstructions[0] == 19690720)
                    {
                        noun = n;
                        verb = v;
                        break;
                    }
                }
            }


            return (100 * noun) + verb;
        }
    }
}

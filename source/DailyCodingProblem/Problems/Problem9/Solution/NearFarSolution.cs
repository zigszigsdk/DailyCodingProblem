using System;

namespace DailyCodingProblem.Problems.Problem9.Solution
{
    public class NearFarSolution : ISolution
    {
        public int Execute(int[] input)
        {
            if (input == null)
                return 0;

            int far = 0, between = 0, near = 0, unavailable = 0;

            for (int index = input.Length - 1; index >= 0; index--)
            {
                int newValue = input[index] + Math.Max(near, Math.Max(between, far));

                far = between;
                between = near;
                near = unavailable;
                unavailable = newValue;
            }

            return Math.Max(near, unavailable);
        }
    }
}

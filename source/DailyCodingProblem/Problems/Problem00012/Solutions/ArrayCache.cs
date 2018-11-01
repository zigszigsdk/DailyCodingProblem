
namespace DailyCodingProblem.Problems.Problem00012.Solutions
{
    public class ArrayCache : ISolution
    {
        public int Solve(int totalSteps, int[] steppingSizes)
        {
            int[] cache = new int[totalSteps+1]; //including the "0th" step.

            cache[totalSteps] = 1;

            for (int standingAt = totalSteps - 1; standingAt >= 0; standingAt--)
            {
                cache[standingAt] = 0;

                foreach (int stepSize in steppingSizes)
                    if (standingAt + stepSize < cache.Length)
                        cache[standingAt] += cache[standingAt + stepSize];
            }

            return cache[0];
        }
    }
}

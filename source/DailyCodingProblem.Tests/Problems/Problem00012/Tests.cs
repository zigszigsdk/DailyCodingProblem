using Xunit;

using DailyCodingProblem.Problems.Problem00012;

namespace DailyCodingProblem.Tests.Problems.Problem00012
{
    public class Tests
    {
        public void GivenTest(ISolution solution)
            => Assert.Equal(5, solution.Solve(4, new int[] { 1, 2 }));

        public void DifferentStepSize(ISolution solution)
            => Assert.Equal(7, solution.Solve(10, new int[] { 3, 2 }));
    }
}

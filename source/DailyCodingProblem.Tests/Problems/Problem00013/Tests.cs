using Xunit;

using DailyCodingProblem.Problems.Problem00013;

namespace DailyCodingProblem.Tests.Problems.Problem00013
{
    public class Tests
    {
        public void GivenTest(ISolution solution)
            => Assert.Equal(3, solution.Solve(2, "abcba"));

        public void BestAtStart(ISolution solution)
            => Assert.Equal(3, solution.Solve(2, "abacd"));

        public void BestAtEnd(ISolution solution)
            => Assert.Equal(3, solution.Solve(2, "deaba"));

        public void ZeroAllowed(ISolution solution)
            => Assert.Equal(0, solution.Solve(0, "abcba"));

        public void NullString(ISolution solution)
            => Assert.Equal(0, solution.Solve(2, null));

        public void EmptyString(ISolution solution)
            => Assert.Equal(0, solution.Solve(2, ""));

        public void ShorterString(ISolution solution)
            => Assert.Equal(3, solution.Solve(5, "abc"));

        public void NoRepeats(ISolution solution)
            => Assert.Equal(3, solution.Solve(3, "abcdef"));







    }
}

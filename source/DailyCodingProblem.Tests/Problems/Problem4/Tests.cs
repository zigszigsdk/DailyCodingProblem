using Xunit;

using DailyCodingProblem.Problems.Problem4;

namespace DailyCodingProblem.Tests.Problems.Problem4
{
    public class Tests
    {
        public void GivenTestA(ISolution solution)
            => Assert.Equal(2, solution.Execute(new int[] { 3, 4, -1, 1 }));

        public void GivenTestB(ISolution solution)
            => Assert.Equal(3, solution.Execute(new int[] { 1, 2, 0 }));

        public void NoValidCandidates(ISolution solution)
            => Assert.Equal(1, solution.Execute(new int[] { -1, 5, 0 }));

        public void NoFirstStep(ISolution solution)
            => Assert.Equal(1, solution.Execute(new int[] { 7, 6, -1, 3, 5, 4 }));

        public void Duplicates(ISolution solution)
            => Assert.Equal(1, solution.Execute(new int[] { 5, 5, 5, 5, 5}));
    }
}

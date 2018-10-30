using Xunit;

using DailyCodingProblem.Problems.Problem00009;

namespace DailyCodingProblem.Tests.Problems.Problem00009
{
    class Tests
    {
        public void GivenTestA(ISolution solution)
            => Assert.Equal(13, solution.Execute(new int[] { 2, 4, 6, 2, 5 }));

        public void GivenTestB(ISolution solution)
            => Assert.Equal(10, solution.Execute(new int[] { 5, 1, 1, 5 }));

        public void Null(ISolution solution)
            => Assert.Equal(0, solution.Execute(null));

        public void Empty(ISolution solution)
            => Assert.Equal(0, solution.Execute(new int[] { }));

        public void SingleElement(ISolution solution)
            => Assert.Equal(3, solution.Execute(new int[] { 3 }));

        public void TwoElements(ISolution solution)
            => Assert.Equal(5, solution.Execute(new int[] { 3, 5 }));
    }
}

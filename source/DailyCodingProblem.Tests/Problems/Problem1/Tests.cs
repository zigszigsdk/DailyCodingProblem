
using Xunit;

using DailyCodingProblem.Problems.Problem1;

namespace DailyCodingProblem.Tests.Problems.Problem1
{
    class Tests
    {
        public void GivenTest(ISolution solution) =>
            Assert.True(solution.Execute(new byte[] { 10, 15, 3, 7 }, 17));

        public void CantUseSameIndexTwice(ISolution solution) =>
            Assert.False(solution.Execute(new byte[] { 3, 5, 6 }, 10));

        public void CanUseSameValueTwice(ISolution solution) =>
            Assert.True(solution.Execute(new byte[] { 3, 5, 5, 6 }, 10));
    }
}

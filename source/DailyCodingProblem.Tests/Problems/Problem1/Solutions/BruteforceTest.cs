using Xunit;
using DailyCodingProblem.Problems.Problem1.Solutions;
using DailyCodingProblem.Problems.Problem1;

namespace DailyCodingProblem.Tests.Problems.Problem1.Solutions
{
    public class BruteforceTest
    {
        Tests tests = new Tests();
        ISolution solution = new BruteforceSolution();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);

        [Fact]
        public void CantUseSameIndexTwice() => tests.CantUseSameIndexTwice(solution);

        [Fact]
        public void CanUseSameValueTwice() => tests.CanUseSameValueTwice(solution);

    }
}

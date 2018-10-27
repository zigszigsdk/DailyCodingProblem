using Xunit;
using DailyCodingProblem.Problems.Problem1.Solutions;
using DailyCodingProblem.Problems.Problem1;

namespace DailyCodingProblem.Tests.Problems.Problem1.Solutions
{
    public class BoolArrayHashsetTest
    {
        Tests tests = new Tests();
        ISolution solution = new BoolArrayHashsetSolution();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);

        [Fact]
        public void CantUseSameIndexTwice() => tests.CantUseSameIndexTwice(solution);

        [Fact]
        public void CanUseSameValueTwice() => tests.CanUseSameValueTwice(solution);

    }
}

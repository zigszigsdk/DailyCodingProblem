using Xunit;
using DailyCodingProblem.Problems.Problem00001.Solutions;
using DailyCodingProblem.Problems.Problem00001;

namespace DailyCodingProblem.Tests.Problems.Problem00001.Solutions
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

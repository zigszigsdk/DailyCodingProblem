using Xunit;

using DailyCodingProblem.Problems.Problem00007;
using DailyCodingProblem.Problems.Problem00007.Solutions;


namespace DailyCodingProblem.Tests.Problems.Problem00007.Solutions
{
    public class RecursionTest
    {
        Tests tests = new Tests();
        ISolution solution = new Recursion();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);

        [Fact]
        public void Empty() => tests.Empty(solution);

        [Fact]
        public void AllValid() => tests.AllValid(solution);

        [Fact]
        public void HighDigits() => tests.HighDigits(solution);

        [Fact]
        public void Zeroes() => tests.Zeroes(solution);
    }
}

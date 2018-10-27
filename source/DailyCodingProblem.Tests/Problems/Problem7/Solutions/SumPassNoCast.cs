using Xunit;

using DailyCodingProblem.Problems.Problem7;
using DailyCodingProblem.Problems.Problem7.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem7.Solutions
{
    public class SumPassNoCastTest
    {
        Tests tests = new Tests();
        ISolution solution = new SumPassNoCast();

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

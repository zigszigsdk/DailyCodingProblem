
using DailyCodingProblem.Problems.Problem00002;
using DailyCodingProblem.Problems.Problem00002.Solutions;
using Xunit;

namespace DailyCodingProblem.Tests.Problems.Problem00002.Solutions
{
    public class RecursionTest
    {
        Tests tests = new Tests();
        ISolution solution = new RecursionSolution();

        [Fact]
        public void GivenTestA() => tests.GivenTestA(solution);

        [Fact]
        public void GivenTestB() => tests.GivenTestB(solution);
    }
}

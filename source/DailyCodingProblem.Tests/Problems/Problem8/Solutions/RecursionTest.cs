using Xunit;

using DailyCodingProblem.Problems.Problem8.Solutions;
using DailyCodingProblem.Problems.Problem8;

namespace DailyCodingProblem.Tests.Problems.Problem8.Solutions
{
    public class RecursionTest
    {
        ISolution solution = new RecursionSolution();
        Tests tests = new Tests();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);

        [Fact]
        public void Null() => tests.Null(solution);

        [Fact]
        public void OnlyRoot() => tests.OnlyRoot(solution);

        [Fact]
        public void OnlyChild() => tests.OnlyChild(solution);

        [Fact]
        public void OnlyChildWithUnivals() => tests.OnlyChildWithUnivals(solution);

    }
}

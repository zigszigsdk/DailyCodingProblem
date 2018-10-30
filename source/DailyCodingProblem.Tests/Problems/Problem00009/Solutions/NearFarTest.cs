using Xunit;

using DailyCodingProblem.Problems.Problem00009;
using DailyCodingProblem.Problems.Problem00009.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem00009.Solutions
{
    public class NearFarTest
    {
        Tests tests = new Tests();
        ISolution solution = new NearFarSolution();

        [Fact]
        public void GivenTestA() => tests.GivenTestA(solution);

        [Fact]
        public void GivenTestB() => tests.GivenTestB(solution);

        [Fact]
        public void Null() => tests.Null(solution);

        [Fact]
        public void Empty() => tests.Empty(solution);

        [Fact]
        public void SingleElement() => tests.SingleElement(solution);

        [Fact]
        public void TwoElements() => tests.TwoElements(solution);
    }
}

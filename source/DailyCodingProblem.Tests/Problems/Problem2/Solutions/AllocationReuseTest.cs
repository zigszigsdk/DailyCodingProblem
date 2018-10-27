
using DailyCodingProblem.Problems.Problem2;
using DailyCodingProblem.Problems.Problem2.Solutions;
using Xunit;

namespace DailyCodingProblem.Tests.Problems.Problem2.Solutions
{
    public class AllocationReuseTest
    {
        Tests tests = new Tests();
        ISolution solution = new AllocationReuseSolution();

        [Fact]
        public void GivenTestA() => tests.GivenTestA(solution);

        [Fact]
        public void GivenTestB() => tests.GivenTestB(solution);
    }
}

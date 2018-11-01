using Xunit;

using DailyCodingProblem.Problems.Problem00012;
using DailyCodingProblem.Problems.Problem00012.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem00012.Solutions
{
    public class ArrayCacheTest
    {
        ISolution solution = new ArrayCache();
        Tests tests = new Tests();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);

        [Fact]
        public void DifferentStepSize() => tests.DifferentStepSize(solution);
    }
}

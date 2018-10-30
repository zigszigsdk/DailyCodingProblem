using Xunit;

using DailyCodingProblem.Problems.Problem00010;
using DailyCodingProblem.Problems.Problem00010.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem00010.Solutions
{
    public class SingletonBackendTest
    {
        ISolution solution = new SingletonBackend();
        Tests tests = new Tests();

        [Fact]
        public void SingleCallback() => tests.SingleCallback(solution);

        [Fact]
        public void OverlappingCallbacks() => tests.OverlappingCallbacks(solution);

        [Fact]
        public void Null() => tests.Null(solution);

        [Fact]
        public void NegativeTime() => tests.NegativeTime(solution);
    }
}

using Xunit;

using DailyCodingProblem.Problems.Problem10;
using DailyCodingProblem.Problems.Problem10.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem10.Solutions
{
    public class SeperateThreadsTest
    {
        ISolution solution = new SeperateThreads();
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

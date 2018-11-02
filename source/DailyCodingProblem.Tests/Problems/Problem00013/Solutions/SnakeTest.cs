using Xunit;

using DailyCodingProblem.Problems.Problem00013;
using DailyCodingProblem.Problems.Problem00013.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem00013.Solutions
{
    public class SnakeTest : ITest
    {
        ISolution solution = new Snake();
        Tests tests = new Tests();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);
        [Fact]
        public void BestAtStart() => tests.BestAtStart(solution);
        [Fact]
        public void BestAtEnd() => tests.BestAtEnd(solution);
        [Fact]
        public void ZeroAllowed() => tests.ZeroAllowed(solution);
        [Fact]
        public void NullString() => tests.NullString(solution);
        [Fact]
        public void EmptyString() => tests.EmptyString(solution);
        [Fact]
        public void ShorterString() => tests.ShorterString(solution);
        [Fact]
        public void NoRepeats() => tests.NoRepeats(solution);
    }
}

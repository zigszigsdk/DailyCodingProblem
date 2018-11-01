using Xunit;

using DailyCodingProblem.Problems.Problem00011;
using DailyCodingProblem.Problems.Problem00011.Solutions.SearchTree;

namespace DailyCodingProblem.Tests.Problems.Problem00011.Solutions
{
    public class SearchTreeTest
    {
        ISolution solution = new SearchTree();
        Tests tests = new Tests();

        [Fact]
        public void GivenTest() => tests.GivenTest(solution);

        [Fact]
        public void EndingMatch() => tests.EndingMatch(solution);

        [Fact]
        public void MiddleMatch() => tests.MiddleMatch(solution);

        [Fact]
        public void ReoccouringChars() => tests.ReoccouringChars(solution);

        [Fact]
        public void NoEntries() => tests.NoEntries(solution);

        [Fact]
        public void NoMatch() => tests.NoMatch(solution);

        [Fact]
        public void NullEntry() => tests.NullEntry(solution);

        [Fact]
        public void NullSearch() => tests.NullSearch(solution);

        [Fact]
        public void EmptyEntryString() => tests.EmptyEntryString(solution);
    }
}

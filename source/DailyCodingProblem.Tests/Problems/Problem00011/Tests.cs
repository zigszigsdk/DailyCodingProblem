using Xunit;

using DailyCodingProblem.Problems.Problem00011;

namespace DailyCodingProblem.Tests.Problems.Problem00011
{
    public class Tests
    {
        public void GivenTest(ISolution solution)
        {
            solution.Add("dog");
            solution.Add("deer");
            solution.Add("deal");
            Assert.Equal(new string[] { "deer", "deal" }, solution.Search("de"));
        }

        public void EndingMatch(ISolution solution)
        {
            solution.Add("abce");
            solution.Add("abde");
            solution.Add("acde");
            Assert.Equal(new string[] { "abde", "acde" }, solution.Search("de"));
        }

        public void MiddleMatch(ISolution solution)
        {
            solution.Add("abcdefgh");
            solution.Add("abcdfgh");
            solution.Add("cdfh");
            Assert.Equal(new string[] { "abcdefgh", "abcdfgh" }, solution.Search("fg"));
        }

        public void ReoccouringChars(ISolution solution)
        {
            solution.Add("abcabcabc");
            solution.Add("bcbcbc");
            solution.Add("cccccc");
            Assert.Equal(new string[] { "abcabcabc", "bcbcbc" }, solution.Search("bc"));
        }

        public void NoEntries(ISolution solution)
        {
            Assert.Equal(new string[0], solution.Search("fg"));
        }

        public void NoMatch(ISolution solution)
        {
            solution.Add("abc");
            solution.Add("def");
            solution.Add("hij");
            Assert.Equal(new string[0], solution.Search("abcdefhij"));
        }

        public void NullEntry(ISolution solution)
        {
            solution.Add(null);
            solution.Add("def");
            solution.Add("hij");
            Assert.Equal(new string[] {"def"}, solution.Search("de"));
        }

        public void NullSearch(ISolution solution)
        {
            solution.Add("abc");
            solution.Add("def");
            solution.Add("hij");
            Assert.Equal(new string[0], solution.Search(null));
        }

        public void EmptyEntryString(ISolution solution)
        {
            solution.Add("");
            solution.Add("def");
            solution.Add("hij");
            Assert.Equal(new string[0], solution.Search(""));
            Assert.Equal(new string[] { "def" }, solution.Search("de"));
        }
    }
}

using Xunit;

using DailyCodingProblem.Problems.Problem7;

namespace DailyCodingProblem.Tests.Problems.Problem7
{
    public class Tests
    {
        public void GivenTest(ISolution solution)
            =>  Assert.Equal(3, solution.Execute("111"));

        public void Empty(ISolution solution)
            => Assert.Equal(0, solution.Execute(""));

        public void AllValid(ISolution solution)
            => Assert.Equal(8, solution.Execute("12211"));

        public void HighDigits(ISolution solution)
            => Assert.Equal(2, solution.Execute("91281"));

        public void Zeroes(ISolution solution)
            => Assert.Equal(1, solution.Execute("110201010"));
    }
}

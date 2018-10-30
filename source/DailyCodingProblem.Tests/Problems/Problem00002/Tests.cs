
using DailyCodingProblem.Problems.Problem00002;
using Xunit;

namespace DailyCodingProblem.Tests.Problems.Problem00002
{
    class Tests
    {
        public void GivenTestA(ISolution solution) =>
            Assert.Equal(
                new ulong[] { 120, 60, 40, 30, 24 },
                solution.Execute(new ushort[] { 1, 2, 3, 4, 5 }));

        public void GivenTestB(ISolution solution) =>
            Assert.Equal(
                new ulong[] { 2, 3, 6 },
                solution.Execute(new ushort[] { 3, 2, 1 }));
    }
}

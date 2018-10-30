using Xunit;

using DailyCodingProblem.Problems.Problem00004;
using DailyCodingProblem.Problems.Problem00004.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem00004.Solutions
{
    public class IndexSwapTest
    {
        Tests tests = new Tests();
        ISolution solution = new IndexSwapSolution();

        [Fact]
        public void GivenTestA() => tests.GivenTestA(solution);
        
        [Fact]
        public void GivenTestB() => tests.GivenTestB(solution);

        [Fact]
        public void NoValidCandidates() => tests.NoValidCandidates(solution);
            
        [Fact]
        public void NoFirstStep() => tests.NoFirstStep(solution);

        [Fact]
        public void Duplicates() => tests.Duplicates(solution);
    }
}

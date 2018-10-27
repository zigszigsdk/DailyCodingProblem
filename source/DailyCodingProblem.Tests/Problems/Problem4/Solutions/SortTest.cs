using Xunit;

using DailyCodingProblem.Problems.Problem4;
using DailyCodingProblem.Problems.Problem4.Solutions;


namespace DailyCodingProblem.Tests.Problems.Problem4.Solutions
{
    public class SortTest
    {
        Tests tests = new Tests();
        ISolution solution = new SortSolution();

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

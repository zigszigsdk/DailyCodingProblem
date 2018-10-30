using BenchmarkDotNet.Attributes;
using System.Linq;

using DailyCodingProblem.Problems.Problem00009.Solutions;

namespace DailyCodingProblem.Problems.Problem00009
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(20, 40, 60, 80, 100, 120, 140, 160, 180, 200)]
        public int testLength;

        int[] input;

        [GlobalSetup]
        public void GlobalSetup()
        {
            input = Enumerable.Range(1, testLength).ToArray();
        }

        ISolution nearFar = new NearFarSolution();

        [Benchmark]
        public void NearFar() => nearFar.Execute(input);
    }
}

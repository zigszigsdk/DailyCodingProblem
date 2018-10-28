using BenchmarkDotNet.Attributes;
using System.Linq;

using DailyCodingProblem.Problems.Problem9.Solutions;

namespace DailyCodingProblem.Problems.Problem9
{
    [MemoryDiagnoser]
    public class Benchmark
    {
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

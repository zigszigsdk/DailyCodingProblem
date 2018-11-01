using BenchmarkDotNet.Attributes;

using DailyCodingProblem.Problems.Problem00012.Solutions;

namespace DailyCodingProblem.Problems.Problem00012
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(10, 20, 30, 40, 50, 60, 70, 80, 90, 100)]
        public int steps;

        [Params(new int[] {1}, new int[] { 1, 2 }, new int[] {1, 2, 3})]
        public int[] stepSizes;

        ISolution arrayCache = new ArrayCache();

        [Benchmark]
        public int ArrayCache() => arrayCache.Solve(steps, stepSizes);
    }
}

using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem00004.Solutions;

namespace DailyCodingProblem.Problems.Problem00004
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(5, 10, 15, 20, 25, 30, 35, 40, 45, 50)]
        public ushort inputLength;

        int[] input;
        int[] inputCopy;

        [GlobalSetup]
        public void GlobalSetup()
        {
            Random random = new Random();
            input = Enumerable.Repeat(0, inputLength).Select(i => random.Next((int)(inputLength * -0.5), (int)(inputLength*1.5)) ).ToArray<int>();
            inputCopy = new int[input.Length];
        }

        HashsetSolution hashset = new HashsetSolution();
        SortSolution sort = new SortSolution();
        IndexSwapSolution indexSwap = new IndexSwapSolution();

        [Benchmark]
        public int Hashset()
        {
            input.CopyTo(inputCopy, 0);
            return hashset.Execute(inputCopy);
        }
        [Benchmark]
        public int Sort()
        {
            input.CopyTo(inputCopy, 0);
            return sort.Execute(inputCopy);
        }

        [Benchmark]
        public int IndexSwap()
        {
            input.CopyTo(inputCopy, 0);
            return indexSwap.Execute(inputCopy);
        }
    }
}

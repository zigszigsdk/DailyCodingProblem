﻿
using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem00007.Solutions;

namespace DailyCodingProblem.Problems.Problem00007
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(3, 6, 9, 12, 15, 18, 21, 24, 27, 30)]
        public int inputLength;
        string input;

        [GlobalSetup]
        public void GlobalSetup()
        {
            input = new string('1', inputLength);
        }

        ISolution recursion = new Recursion();
        ISolution sumPass = new SumPass();
        ISolution sumPassNoCast = new SumPassNoCast();

        [Benchmark]
        public int Recursion() => recursion.Execute(input);

        [Benchmark]
        public int SumPass() => sumPass.Execute(input);

        [Benchmark]
        public int SumPassNoCast() => sumPassNoCast.Execute(input);
    }
}

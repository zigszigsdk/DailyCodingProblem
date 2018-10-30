using System;
using BenchmarkDotNet.Attributes;

using DailyCodingProblem.Problems.Problem5.Solutions;

namespace DailyCodingProblem.Problems.Problem5
{
    using Pair =      Func<Func<int, int, int>, int>;
    using Car =  Func<Func<Func<int, int, int>, int>, int>;
    using Cdr =  Func<Func<Func<int, int, int>, int>, int>;
    
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        Pair pair = Problem.cons(3, 4);

        Car car = new Solution().car;
        Cdr cdr = new Solution().cdr;

        [Benchmark]
        public int Car() => car(pair);

        [Benchmark]
        public int Cdr() => cdr(pair);
    }
}

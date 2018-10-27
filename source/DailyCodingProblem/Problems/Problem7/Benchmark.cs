
using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem7.Solutions;

namespace DailyCodingProblem.Problems.Problem7
{
    [MemoryDiagnoser]
    public class Benchmark
    {
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

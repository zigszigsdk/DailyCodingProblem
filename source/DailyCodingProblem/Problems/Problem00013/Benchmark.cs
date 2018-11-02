using BenchmarkDotNet.Attributes;

using DailyCodingProblem.Problems.Problem00013.Solutions;

namespace DailyCodingProblem.Problems.Problem00013
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(10, 20, 30, 40, 50, 60, 70, 80, 90, 100)]
        public int stringLength;

        string input;

        [GlobalSetup]
        public void GlobalSetup() => input = new string('a', stringLength);

        ISolution bruteforce = new Bruteforce();
        ISolution snake = new Snake();

        [Benchmark]
        public int Bruteforce() => bruteforce.Solve(3, input);

        [Benchmark]
        public int Snake() => snake.Solve(3, input);
    }
}

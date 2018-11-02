using System;

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

        string bruteforceInput;
        string snakeInput = "";

        [GlobalSetup]
        public void GlobalSetup()
        {
            bruteforceInput = new string('a', stringLength);

            Random random = new Random();
            while (snakeInput.Length != stringLength)
                snakeInput += (char)random.Next('a', 'z');   
        }

        ISolution bruteforce = new Bruteforce();
        ISolution snake = new Snake();

        [Benchmark]
        public int Bruteforce() => bruteforce.Solve(3, bruteforceInput);

        [Benchmark]
        public int Snake() => snake.Solve(3, snakeInput);
    }
}

using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem1.Solutions;

namespace DailyCodingProblem.Problems.Problem1
{
    [MemoryDiagnoser, RankColumn]
    public class Benchmark
    {
        [Params(1,2,3)]
        public byte testNumber;

        byte[] candidates;
        byte target;

        BruteforceSolution bruteforce = new BruteforceSolution();
        HashsetSolution hashset = new HashsetSolution();
        BoolArrayHashsetSolution boolArrayHashset = new BoolArrayHashsetSolution();

        [GlobalSetup]
        public void GlobalSetup()
        {
            switch (testNumber)
            {
                case 1:
                    candidates = new byte[]{10,15,3,7};
                    target = 17;
                    break;
                case 2:
                    candidates = new byte[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26};
                    target = 22;
                    break;
                case 3:
                    candidates = new byte[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26};
                    target = 51;
                    break;
            }            
        }

        [Benchmark]
        public bool Bruteforce() => bruteforce.Execute(candidates, target);

        [Benchmark]
        public bool Hashset() => hashset.Execute(candidates, target);

        [Benchmark]
        public bool BoolArrayHashset() => boolArrayHashset.Execute(candidates, target);
    }
}

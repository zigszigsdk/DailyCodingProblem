
using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem2.Solutions;

namespace DailyCodingProblem.Problems.Problem2
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        // !20 and above won't fit in an ulong, though it can still run and overflow.
        [Params(3, 19, 5000, 20000)]
        public ushort NumberOfNumbersInInput;

        ushort[] data;

        private BruteLoopSolution bruteLoop = new BruteLoopSolution();
        private RecursionSolution recursion = new RecursionSolution();
        private AllocationReuseSolution allocationReuse = new AllocationReuseSolution();

        [GlobalSetup]
        public void GlobalSetup()
        {
            data = new ushort[NumberOfNumbersInInput];
            for (ushort index = 0; index < NumberOfNumbersInInput; index++)
                data[index] = (ushort)(index + 1);
        }

        [Benchmark]
        public ulong[] BruteLoop() => bruteLoop.Execute(data);

        [Benchmark]
        public ulong[] Recursion() => recursion.Execute(data);

        [Benchmark]
        public ulong[] AllocationReuse() => allocationReuse.Execute(data);
    }
}

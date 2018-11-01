using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem00011.Solutions.SearchTree;

namespace DailyCodingProblem.Problems.Problem00011
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(10, 20, 30, 40, 50, 60, 70, 80, 90, 100)]
        public int entryLength;

        ISolution searchTree = new SearchTree();

        string entry;

        [GlobalSetup]
        public void GlobalSetup()
        {
            entry = new string('B', entryLength);
            searchTree.Add(entry);
        }

        [Benchmark]
        public void SearchTree() => searchTree.Search(entry);
    }
}

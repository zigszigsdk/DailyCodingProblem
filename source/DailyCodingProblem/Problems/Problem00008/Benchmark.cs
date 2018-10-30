using BenchmarkDotNet.Attributes;

using DailyCodingProblem.Problems.Problem00008.Solutions;

namespace DailyCodingProblem.Problems.Problem00008
{
    [MemoryDiagnoser]
    public class Benchmark : IBenchmark 
    {
        public string printBefore() => "";
        public string printAfter() => "";

        [Params(3, 6, 9, 12, 15)]
        public int testDepth;

        Node root = null;

        [GlobalSetup]
        public void GlobalSetup()
        {
            root = new Node(true);
            Node[] leaves = { root };
            for (byte depth = 1; depth <= testDepth; depth++)
            {
                Node[] newLeaves = new Node[leaves.Length * 2];
                for (int leafIndex = leaves.Length - 1; leafIndex >= 0; leafIndex--)
                {
                    leaves[leafIndex].left = new Node(true);
                    leaves[leafIndex].right = new Node(true);
                    newLeaves[leafIndex * 2] = leaves[leafIndex].left;
                    newLeaves[leafIndex * 2 + 1] = leaves[leafIndex].right;
                }
                leaves = newLeaves;
            }
        }

        RecursionSolution recursionSolution = new RecursionSolution();

        [Benchmark]
        public int Recursion() => recursionSolution.Execute(root);
    }
}

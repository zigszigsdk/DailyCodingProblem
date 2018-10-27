using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem3.Solutions;

namespace DailyCodingProblem.Problems.Problem3
{
    public enum Testcase { givenValues, depth5, depth10, depth15 }

    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(Testcase.givenValues, Testcase.depth5, Testcase.depth10, Testcase.depth15)]
        public Testcase testcase;

        static JsonStringSolution givenTest = new JsonStringSolution
            ("root"
            , new JsonStringSolution
                ("left"
                , new JsonStringSolution
                    ("left.left"
                    )
                ), new JsonStringSolution
                ("right"
                )
            );

        JsonStringSolution jsonString;
        SExpsSolution sExps;

        [GlobalSetup]
        public void GlobalSetup()
        {
            JsonStringSolution root = null;

            switch (testcase)
            {
                case Testcase.givenValues: root = givenTest; break;
                case Testcase.depth5: root = generateDepth(5); break;
                case Testcase.depth10: root = generateDepth(10); break;
                case Testcase.depth15: root = generateDepth(15); break;
            }
            jsonString = JsonStringSolution.CreateFrom(root);
            sExps = SExpsSolution.CreateFrom(root);
        }

        private JsonStringSolution generateDepth(byte depthTarget)
        {
            JsonStringSolution root = new JsonStringSolution("root");
            JsonStringSolution[] leaves = { root };
            for (byte depth = 1; depth <= depthTarget; depth++)
            {
                JsonStringSolution[] newLeaves = new JsonStringSolution[leaves.Length * 2];
                for (int leafIndex = leaves.Length - 1; leafIndex >= 0; leafIndex--)
                {
                    leaves[leafIndex].left = new JsonStringSolution(depth + ":" + leafIndex + ":left");
                    leaves[leafIndex].right = new JsonStringSolution(depth + ":" + leafIndex + ":right");
                    newLeaves[leafIndex * 2] = leaves[leafIndex].left;
                    newLeaves[leafIndex * 2 + 1] = leaves[leafIndex].right;
                }
                leaves = newLeaves;
            }
            return root;
        }

        [Benchmark]
        public JsonStringSolution JsonString() => JsonStringSolution.Deserialize(jsonString.Serialize());

        [Benchmark]
        public SExpsSolution SExps() => SExpsSolution.Deserialize(jsonString.Serialize());
    }
}

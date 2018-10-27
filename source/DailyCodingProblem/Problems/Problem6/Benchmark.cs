﻿
using BenchmarkDotNet.Attributes;
using DailyCodingProblem.Problems.Problem6.Solutions.Solution;

namespace DailyCodingProblem.Problems.Problem6
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(10, 20, 30, 40, 50, 60, 70, 80, 90, 100)]
        public int getAtDepth;

        XorLinkedList list = new XorLinkedList();

        [GlobalSetup]
        public void GlobalSetup()
        {
            for (int index = 0; index < getAtDepth + 1; index++)
                list.Append(index);
        }

        [Benchmark]
        public int? GetAtDepth() => list.GetAt(getAtDepth);
    }
}
using System;
using System.IO;
using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace DailyCodingProblem
{
    public class ConsoleMenu
    {
        List<Type> benchmarkedProblems = new List<Type>();

        public ConsoleMenu()
        {
            for (ushort problemNumber = 1; true; problemNumber++)
            {
                Type candidate = Type.GetType("DailyCodingProblem.Problems.Problem" +problemNumber.ToString().PadLeft(5, '0') + ".Benchmark");

                if (candidate == null)
                    break;

                benchmarkedProblems.Add(candidate);
            }
        }

        public void Execute()
        {
            while (true)
            {
                Console.Write
                (   "\n\nSelect a problem:" 
                +   "\n 1 - " + benchmarkedProblems.Count + "." 
                +   "\n Q to go quit." 
                +   "\n\nYour choice: "
                );

                string input = Console.ReadLine().Trim();

                if (input.ToLower() == "q")
                    break;

                if (!ushort.TryParse(input, out ushort selectedProblem) 
                || selectedProblem == 0 
                || selectedProblem > benchmarkedProblems.Count
                )
                    continue;

                Console.Clear();

                while (true)
                {
                    Console.Write
                    (   "\nSelect a task:"
                    +   "\n  P to read the problem description."
                    +   "\n  B to perform benchmark." 
                    +   "\n  Q to return to previous menu." 
                    +   "\n\nYour choice: ");

                    input = Console.ReadLine().Trim().ToLower();
                    Console.Clear();
                    if (input == "q")
                        break;

                    switch (input)
                    {
                        case "p":
                            TryPrint(@".\Problems\Problem" + selectedProblem.ToString().PadLeft(5, '0') + @"\problem.txt");
                            break;
                        case "b":
                            Type type = benchmarkedProblems[selectedProblem - 1];
                            IBenchmark benchmark = (IBenchmark)Activator.CreateInstance(type);
                            Console.WriteLine(benchmark.printBefore());
                            BenchmarkRunner.Run(type);
                            Console.WriteLine(benchmark.printAfter());
                            break;
                    }
                }
            }
        }
        void TryPrint(string filepath) =>
            Console.WriteLine("\n" + (File.Exists(filepath) ? File.ReadAllText(filepath) : filepath + " not found") + "\n");
    }
}

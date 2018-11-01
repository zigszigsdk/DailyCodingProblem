using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem00011.Solutions.SearchTree
{
    class Node
    {
        List<string> matches = new List<string>();

        Dictionary<char, Node> branches = new Dictionary<char, Node>();

        public void Add(string toAdd, int at)
        {
            if(!matches.Contains(toAdd))
                matches.Add(toAdd);

            if (at == toAdd.Length)
                return;

            if (!branches.ContainsKey(toAdd[at]))
            branches[toAdd[at]] = new Node();

            branches[toAdd[at]].Add(toAdd, at + 1);
        }

        public string[] Search(string input)
        {
            if(input.Length == 0)
                return matches.ToArray();

            if (branches.ContainsKey(input[0]))
                return branches[input[0]].Search(input.Substring(1));

            return new string[0];
        }
    }
}

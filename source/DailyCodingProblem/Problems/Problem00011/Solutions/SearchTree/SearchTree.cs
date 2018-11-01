using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem00011.Solutions.SearchTree
{
    public class SearchTree : ISolution
    {
        Node root = new Node();

        public void Add(string toAdd)
        {
            if (toAdd == null)
                return;

            for (int startIndex = toAdd.Length - 1; startIndex >= 0; startIndex--)
                root.Add(toAdd, startIndex);
        }

        public string[] Search(string input)
        {
            if (input == null || input.Length == 0)
                return new string[0];

            return root.Search(input);
        }
    }
}

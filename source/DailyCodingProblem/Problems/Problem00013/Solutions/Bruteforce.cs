using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem00013.Solutions
{
    public class Bruteforce : ISolution
    {
        public int Solve(int maxChars, string subject)
        {
            if (subject == null || subject.Length == 0 || maxChars <= 0)
                return 0;

            if (maxChars >= subject.Length)
                return subject.Length;

            int result = maxChars;

            HashSet<char> seen;
            int next;
            bool roomForNextChar() => seen.Count != maxChars || seen.Contains(subject[next]);

            for (int start = subject.Length - 1 - maxChars; start >= 0; start--)
            {
                seen = new HashSet<char>();

                for (next = start; next < subject.Length && roomForNextChar(); next++)
                    seen.Add(subject[next]);

                if (next - start > result)
                    result = next - start;
            }

            return result;
        }
    }
}

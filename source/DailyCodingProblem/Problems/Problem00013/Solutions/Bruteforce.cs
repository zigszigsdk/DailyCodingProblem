using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem00013.Solutions
{
    public class Bruteforce : ISolution
    {
        public int Solve(int maxChars, string subject)
        {
            if (subject == null || subject.Length == 0 || maxChars <= 0)
                return 0;

            for (int index = subject.Length - 1; index >= 0; index--)
                if (subject[index] < 'a' || subject[index] > 'z')
                    return 0;

            if (maxChars >= subject.Length)
                return subject.Length;

            int result = maxChars;

            bool[] seenChars;
            int seenCount;
            int next;
            bool roomForNextChar() => seenCount != maxChars || seenChars[subject[next]-'a'];

            for (int start = subject.Length - 1 - maxChars; start >= 0; start--)
            {
                seenCount = 0;
                seenChars = new bool[25];
                for (int index = 24; index >= 0; index--)
                    seenChars[index] = false;

                for (next = start; next < subject.Length && roomForNextChar(); next++)
                {
                    if (seenChars[subject[next]-'a'] == false)
                    {
                        seenCount++;
                        seenChars[subject[next]-'a'] = true;
                    }
                }
                if (next - start > result)
                    result = next - start;
            }

            return result;
        }
    }
}

using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem00013.Solutions
{
    public class Snake : ISolution
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

            int tailOffset = 0;

            int distinctInside = 0;
            int[] charsSeenTimes = new int[25];

            for (int head = subject.Length - 1; head >= 0; head--)
            {
                if (charsSeenTimes[subject[head] - 'a'] == 0)
                    distinctInside++;

                charsSeenTimes[subject[head] - 'a']++;

                if (distinctInside <= maxChars)
                    tailOffset++;
                else
                {
                    charsSeenTimes[subject[head + tailOffset] - 'a']--;

                    if (charsSeenTimes[subject[head + tailOffset] - 'a'] == 0)
                        distinctInside--;
                }
            }

            return tailOffset;
        }
    }
}

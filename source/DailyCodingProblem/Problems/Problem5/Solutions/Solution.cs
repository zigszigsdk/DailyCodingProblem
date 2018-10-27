using System;

namespace DailyCodingProblem.Problems.Problem5.Solutions
{
    using Pair = Func<Func<int, int, int>, int>;

    public class Solution
    {
        public int car(Pair pair)
            => pair((int a, int b)
                => a);

        public int cdr(Pair pair)
            => pair((int a, int b)
                => b);
    }
}

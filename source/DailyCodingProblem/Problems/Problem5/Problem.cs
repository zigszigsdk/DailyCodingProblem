using System;

namespace DailyCodingProblem.Problems.Problem5
{
    using Pair = Func<Func<int, int, int>, int>;
    using F =         Func<int, int, int>;
    
    public class Problem
    {
        public static Pair cons(int a, int b)
            => (F f)
                => f(a, b);
    }
}

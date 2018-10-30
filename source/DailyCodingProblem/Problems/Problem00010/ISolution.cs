using System;

namespace DailyCodingProblem.Problems.Problem00010
{
    public interface ISolution
    {
        void Schedule(int inMs, Action callback);
    }
}

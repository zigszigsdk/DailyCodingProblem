using System;

namespace DailyCodingProblem.Problems.Problem10
{
    public interface ISolution
    {
        void Schedule(int inMs, Action callback);
    }
}

using System;
using System.Threading;

namespace DailyCodingProblem.Problems.Problem00010.Solutions
{
    public class SeperateThreads : ISolution
    {
        const int resolution = 1;

        public void Schedule(int inMs, Action callback)
        {
            if (callback == null)
                return;

            if (inMs <= 0)
                callback();

            new Thread(new ThreadStart(() =>
            {
                DateTime target = DateTime.Now.Add(new TimeSpan(0, 0, 0, 0, inMs));
                while (DateTime.Now < target)
                    Thread.Sleep(resolution);

                callback();
            })).Start();

        }
    }
}

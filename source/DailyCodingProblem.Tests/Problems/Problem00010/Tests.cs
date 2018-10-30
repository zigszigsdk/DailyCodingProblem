using System;
using System.Threading;
using Xunit;

using DailyCodingProblem.Problems.Problem00010;

namespace DailyCodingProblem.Tests.Problems.Problem00010
{
    class Tests
    {
        int sleepInterval = 100;
        int margin = 100;

        public void SingleCallback(ISolution solution)
        {
            int callbackIn = 500;
            DateTime to = DateTime.MinValue;
            DateTime from = DateTime.Now;

            solution.Schedule(callbackIn, () => to = DateTime.Now);

            while (to == DateTime.MinValue)
                Thread.Sleep(sleepInterval);

            Assert.True(to.Subtract(from).TotalMilliseconds <= callbackIn + margin);
            Assert.True(to.Subtract(from).TotalMilliseconds >= callbackIn);
        }

        public void OverlappingCallbacks(ISolution solution)
        {
            int instances = 100;
            int callbackIn = 500;

            DateTime[] to = new DateTime[instances];
            DateTime[] from = new DateTime[instances];

            for (int index = instances - 1; index >= 0; index--)
            {
                int index1 = index;
                from[index] = DateTime.Now;                
                solution.Schedule(callbackIn, () => to[index1] = DateTime.Now);
            }

            for (int index = instances - 1; index >= 0; index--)
            {
                while (to[index] == DateTime.MinValue)
                    Thread.Sleep(sleepInterval);

                Assert.True(to[index].Subtract(from[index]).TotalMilliseconds <= callbackIn + margin);
                Assert.True(to[index].Subtract(from[index]).TotalMilliseconds >= callbackIn);
            }
        }

        public void Null(ISolution solution) => solution.Schedule(10, null);

        public void NegativeTime(ISolution solution)
        {
            DateTime to = DateTime.MinValue;

            solution.Schedule(-50, () => to = DateTime.Now);

            Assert.NotEqual(DateTime.MinValue, to);
        }

    }
}

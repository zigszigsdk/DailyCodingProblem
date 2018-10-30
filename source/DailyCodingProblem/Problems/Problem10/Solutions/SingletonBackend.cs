using System;

using System.Collections.Concurrent;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem10.Solutions
{
    struct Callback
    {
        public Action action;
        public DateTime when;
    }

    public class SingletonBackend : ISolution
    {
        const int resolution = 1;

        static ConcurrentQueue<Callback> callbacksToAdd = new ConcurrentQueue<Callback>();

        static Thread backendThread;
        static List<Callback> queue = new List<Callback>();

        static void Backend()
        {
            do
            {
                PerformCallbacks();
                AddNewEntries();
                Thread.Sleep(resolution);
            }
            while (queue.Count != 0);
        }

        static void PerformCallbacks()
        {
            while (queue.Count != 0 && queue[0].when <= DateTime.Now)
            {
                queue[0].action();
                queue.RemoveAt(0);
            }
        }

        static void AddNewEntries()
        {
            while (callbacksToAdd.Count != 0)
            {
                if (callbacksToAdd.TryDequeue(out Callback toAdd))
                {
                    int index = queue.FindIndex(
                        (Callback x) => x.when > toAdd.when);

                    if (index == -1)
                        queue.Add(toAdd);
                    else
                        queue.Insert(index, toAdd);
                }
            }
        }


        public void Schedule(int inMs, Action callback)
        {
            if (callback == null)
                return;

            if (inMs <= 0)
                callback();

            callbacksToAdd.Enqueue(new Callback()
            {   action = callback
            ,   when = DateTime.Now.Add(new TimeSpan(0, 0, 0, 0, inMs))
            });

            if (backendThread == null || !backendThread.IsAlive)
            {
                backendThread = new Thread(new ThreadStart(Backend));
                backendThread.Start();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

using DailyCodingProblem.Problems.Problem00006.Solutions.Solution;

namespace DailyCodingProblem.Tests.Problems.Problem00006
{
    class MonitoredUnmanagedMemory : IUnmanagedMemory
    {
        public HashSet<IntPtr> currentAllocations = new HashSet<IntPtr>();

        public IntPtr AllocHGlobal(int cb)
        {
            IntPtr result = Marshal.AllocHGlobal(cb);
            currentAllocations.Add(result);
            return result;
        }

        public void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
        {
            currentAllocations.Add(ptr);
            Marshal.StructureToPtr(structure, ptr, fDeleteOld);
        }
        public void FreeHGlobal(IntPtr hglobal)
        {
            currentAllocations.Remove(hglobal);
            Marshal.FreeHGlobal(hglobal);
        }

        public int SizeOf(Type t) => Marshal.SizeOf(t);
    }
}

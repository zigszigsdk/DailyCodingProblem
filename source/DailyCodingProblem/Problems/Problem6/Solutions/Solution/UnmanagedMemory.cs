using System;
using System.Runtime.InteropServices;

namespace DailyCodingProblem.Problems.Problem6.Solutions.Solution
{
    public class UnmanagedMemory : IUnmanagedMemory
    {
        public IntPtr AllocHGlobal(int cb) => Marshal.AllocHGlobal(cb);

        public void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) 
            => Marshal.StructureToPtr(structure, ptr, fDeleteOld);

        public void FreeHGlobal(IntPtr hglobal) => Marshal.FreeHGlobal(hglobal);

        public int SizeOf(Type t) => Marshal.SizeOf(t);
    }
}

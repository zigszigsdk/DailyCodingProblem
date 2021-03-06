﻿using System;

namespace DailyCodingProblem.Problems.Problem00006.Solutions.Solution
{
    public interface IUnmanagedMemory
    {
        IntPtr AllocHGlobal(int cb);

        void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);

        void FreeHGlobal(IntPtr hglobal);

        int SizeOf(Type t);
    }
}

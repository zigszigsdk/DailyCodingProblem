using System;
using Xunit;
using DailyCodingProblem.Problems.Problem00006.Solutions.Solution;

namespace DailyCodingProblem.Tests.Problems.Problem00006.Solutions
{
    unsafe public class Solution
    {
        [Fact]
        public void Summing()
        {
            XorLinkedList list = new XorLinkedList(new MonitoredUnmanagedMemory());
            list.Prepend(1);
            list.Prepend(2);
            list.Prepend(3);
            Assert.Equal(6, list.Sum());
        }

        [Fact]
        public void GetAt()
        {
            XorLinkedList list = new XorLinkedList(new MonitoredUnmanagedMemory());
            list.Prepend(1);
            list.Prepend(2);
            list.Prepend(3);
            Assert.Null(list.GetAt(-1));
            Assert.Equal(3, list.GetAt(0));
            Assert.Equal(2, list.GetAt(1));
            Assert.Equal(1, list.GetAt(2));
            Assert.Null(list.GetAt(3));
        }

        [Fact]
        public void Append()
        {
            XorLinkedList list = new XorLinkedList(new MonitoredUnmanagedMemory());
            list.Append(1);
            list.Append(2);
            list.Append(3);
            Assert.Null(list.GetAt(-1));
            Assert.Equal(1, list.GetAt(0));
            Assert.Equal(2, list.GetAt(1));
            Assert.Equal(3, list.GetAt(2));
            Assert.Null(list.GetAt(3));

        }

        [Fact]
        public void RemoveAt()
        {
            XorLinkedList list = new XorLinkedList(new MonitoredUnmanagedMemory());
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            Assert.Equal(3, list.RemoveAt(2));
            Assert.Equal(1, list.RemoveAt(0));
            Assert.Equal(5, list.RemoveAt(2));

            Assert.Equal(2, list.GetAt(0));
            Assert.Equal(4, list.GetAt(1));
            Assert.Null(list.GetAt(2));

            Assert.Null(list.RemoveAt(-1));
            Assert.Equal(2, list.RemoveAt(0));
            Assert.Equal(4, list.RemoveAt(0));
            Assert.Null(list.RemoveAt(0));
        }

        [Fact]
        public void DeleteAll()
        {
            MonitoredUnmanagedMemory mem = new MonitoredUnmanagedMemory();
            
            XorLinkedList list = new XorLinkedList(mem);
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.DeleteAll();
            
            Assert.Empty(mem.currentAllocations);
        }

        [Fact]
        public void AllocationFreeing()
        {
            MonitoredUnmanagedMemory mem = new MonitoredUnmanagedMemory();
            XorLinkedList list = new XorLinkedList(mem);
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.RemoveAt(0);
            Assert.Equal(2, mem.currentAllocations.Count);
            list.RemoveAt(0);
            Assert.Single(mem.currentAllocations);
            list.RemoveAt(0);
            Assert.Empty(mem.currentAllocations);
        }

        [Fact]
        public void ResponsiveToGarbageCollection()
        {
            MonitoredUnmanagedMemory mem = new MonitoredUnmanagedMemory();

            void innerScope()
            {
                XorLinkedList list = new XorLinkedList(mem);
                list.Append(1);
                list.Append(2);
                list.Append(3);
                Assert.Equal(3, mem.currentAllocations.Count);
            }

            innerScope();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Assert.Empty(mem.currentAllocations);
        }
    }
}

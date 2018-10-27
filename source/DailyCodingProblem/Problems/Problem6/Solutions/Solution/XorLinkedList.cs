using System;

namespace DailyCodingProblem.Problems.Problem6.Solutions.Solution
{
    unsafe public class XorLinkedList
    {
        IUnmanagedMemory unmanagedMemory;

        Node* head = (Node*)0;
        Node* tail = (Node*)0;

        public XorLinkedList()
        {
            this.unmanagedMemory = new UnmanagedMemory();
        }

        public XorLinkedList(IUnmanagedMemory unmanagedMemory)
        {
            this.unmanagedMemory = unmanagedMemory;
        }

        ~XorLinkedList()
        {
            DeleteAll();
        }

        public void Prepend(int payload)
        {
            Node* oldHead = head;
            head = (Node*)unmanagedMemory.AllocHGlobal(unmanagedMemory.SizeOf(typeof(Node)));
            unmanagedMemory.StructureToPtr(new Node(payload, oldHead), (IntPtr)head, false);

            if ((long)oldHead == 0)
            {
                tail = head;
                return;
            }

            oldHead->ModifyLink((Node*)0, head);
        }

        public void Append(int payload)
        {
            Node* oldTail = tail;
            tail = (Node*)unmanagedMemory.AllocHGlobal(unmanagedMemory.SizeOf(typeof(Node)));
            unmanagedMemory.StructureToPtr(new Node(payload, oldTail), (IntPtr)tail, false);

            if ((long)oldTail == 0)
            {
                head = tail;
                return;
            }

            oldTail->ModifyLink((Node*)0, tail);
        }

        public int Sum() => (long)head == 0 ? 0 : head->Sum((Node*)0, head);

        public int? GetAt(int index)
            => (long)head == 0 || index < 0 ? null : head->GetAt(index, (Node*)0, head);

        public int? RemoveAt(int index)
        {
            if (index < 0 || (long)head == 0)
                return null;

            Node* toFree = head->RemoveAt(index, (Node*)0, head);

            if ((long)toFree == 0)
                return null;

            int result = toFree->GetPayload();

            if (toFree == head)
                head = (Node*)toFree->GetLink();
            else if (toFree == tail)
                tail = (Node*)toFree->GetLink();

            unmanagedMemory.FreeHGlobal((IntPtr)toFree);

            return result;
        }

        public void DeleteAll()
        {
            if ((long)head == 0)
                return;

            head->DeleteAll(unmanagedMemory, (Node*)0, head);
            unmanagedMemory.FreeHGlobal((IntPtr)head);
            head = (Node*)0;
            tail = (Node*)0;
        }
    }
}

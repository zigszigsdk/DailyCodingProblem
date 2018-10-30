using System;

namespace DailyCodingProblem.Problems.Problem00006.Solutions.Solution
{
    unsafe public struct Node
    {
        int payload;
        IntPtr link;

        public Node(int payload, IntPtr link)
        {   
            this.payload = payload;
            this.link = link;
        }

        public Node(int payload, Node* prevAddress, Node* nextAddress)
            : this( payload, new IntPtr((long)prevAddress ^ (long)nextAddress))
        { }

        public Node(int payload, Node* prevAddress)
            : this(payload, prevAddress, (Node*)0) { }

        public int GetPayload() => payload;

        public IntPtr GetLink() => link;

        public void ModifyLink(Node* oldAddress, Node* newAddress)
        {
            link = new IntPtr(link.ToInt64()^(long)oldAddress^(long)newAddress);
        }

        public int Sum(Node* previousAddress, Node* ownAddress)
        {
            Node* nextAddress = MakeNextAddress(previousAddress);

            if ((long)nextAddress == 0)
                return payload;
            else
                return payload + nextAddress->Sum(ownAddress, nextAddress);
        }

        public int? GetAt(int index, Node* previousAddress, Node* ownAddress)
        {
            if (index == 0)
                return payload;

            Node* nextAddress = MakeNextAddress(previousAddress);

            if ((long)nextAddress == 0)
                return null;
            else
                return nextAddress->GetAt(index-1, ownAddress, nextAddress);
        }

        public Node* RemoveAt(int index, Node* previousAddress, Node* ownAddress)
        {
            Node* nextAddress = MakeNextAddress(previousAddress);

            if (index == 0)
            {
                if((long)previousAddress != 0)
                    previousAddress->ModifyLink(ownAddress, nextAddress);
                if ((long)nextAddress != 0)
                    nextAddress->ModifyLink(ownAddress, previousAddress);
                return ownAddress;
            }
            
            if ((long)nextAddress == 0)
                return (Node*)0;
            else
                return nextAddress->RemoveAt(index - 1, ownAddress, nextAddress);
        }

        public void DeleteAll(IUnmanagedMemory unmanagedMemory, Node* previousAddress, Node* ownAddress)
        {
            Node* nextAddress = MakeNextAddress(previousAddress);

            if ((long)nextAddress == 0)
                return;

            nextAddress->DeleteAll(unmanagedMemory, ownAddress, nextAddress);
            unmanagedMemory.FreeHGlobal((IntPtr)nextAddress);
        }

        Node* MakeNextAddress(Node* previousAddress)
            => (Node*)((link.ToInt64()) ^ (long)previousAddress);
    }
}

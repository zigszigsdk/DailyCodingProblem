using System;

namespace DailyCodingProblem.Shared
{
    public class BinaryTreeNode<T> : ValueEquality where T : BinaryTreeNode<T>
    {
        public static OutType CreateFrom<InType, OutType>(InType copyFrom)
            where InType : BinaryTreeNode<InType>
            where OutType : BinaryTreeNode<OutType>, new()
                => new OutType()
                    {   value = copyFrom.value
                    ,   left = copyFrom.left == null ? null : CreateFrom<InType, OutType>(copyFrom.left)
                    ,   right = copyFrom.right == null ? null : CreateFrom<InType, OutType>(copyFrom.right)
                    };

        public string value;
        public T left;
        public T right;

        public BinaryTreeNode(string value, T left = default, T right = default)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        override protected object[] GetHashObjects() => new object[] { value, left, right };
        override protected int GetBasePrimeForHashCode() => 694847539;
        override protected int GetMultiPrimeForHashCode() => 694884683;

        public virtual string Serialize() => throw new NotImplementedException();
    }
}

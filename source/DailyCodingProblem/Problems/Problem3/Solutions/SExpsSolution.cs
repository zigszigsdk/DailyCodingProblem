using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem3.Solutions
{
    public class SExpsSolution : Node<SExpsSolution>
    {
        public static SExpsSolution Deserialize(string serialized)
            =>  serialized.Trim().Length == 0 
                ?   null
                :   new SExpsSolution(
                        new Stack<string>(
                            serialized.Trim().Split(' ')));

        public static SExpsSolution CreateFrom<T>(Node<T> copyFrom) where T : Node<T>
            => new SExpsSolution(
                    copyFrom.value
                , copyFrom.left == null ? null : CreateFrom(copyFrom.left)
                , copyFrom.right == null ? null : CreateFrom(copyFrom.right));

        public SExpsSolution(string value, SExpsSolution left = null, SExpsSolution right = null)
            : base(value, left, right) { }

        public SExpsSolution(Stack<string> from)
            : base(null)
        {
            if (from.Count == 0)
                return;

            value = from.Pop();

            if (from.Count == 0)
                return;

            if (from.Peek() == "null")
            {
                left = null;
                from.Pop();
            }
            else
                left = new SExpsSolution(from);

            if (from.Count == 0)
                return;

            if (from.Peek() == "null")
            {
                right = null;
                from.Pop();
            }
            else
                right = new SExpsSolution(from);
        }

        public string Serialize()
            =>  (right != null ? right.Serialize() : "null") + " "
            +   (left  != null ? left.Serialize()  : "null") + " "
            +   value;
    }
}

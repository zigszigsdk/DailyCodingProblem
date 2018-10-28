using System.Collections.Generic;

using DailyCodingProblem.Shared;

namespace DailyCodingProblem.Problems.Problem3.Solutions
{
    public class SExpsSolution : BinaryTreeNode<SExpsSolution>
    {
        public static SExpsSolution Deserialize(string serialized)
            =>  serialized.Trim().Length == 0 
                ?   null
                :   new SExpsSolution(
                        new Stack<string>(
                            serialized.Trim().Split(' ')));

        public SExpsSolution() : base("") { }


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

        override public string Serialize()
            =>  (right != null ? right.Serialize() : "null") + " "
            +   (left  != null ? left.Serialize()  : "null") + " "
            +   value;
    }
}

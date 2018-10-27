using System;
using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem3
{
    public class Node<T> where T : Node<T>
    {
        public static bool operator ==(Node<T> a, Node<T> b)
            =>  ReferenceEquals(a, b)
            ||  (   !ReferenceEquals(null, a)
                &&  a.Equals(b));

        public static bool operator !=(Node<T> a, Node<T> b)
            => !(a == b);

        public string value;
        public T left;
        public T right;

        public Node(string value, T left = default, T right = default)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public override bool Equals(object other) => Equals(other as T);

        public bool Equals(T other)
            =>  ReferenceEquals(this, other)
            ||  (   !ReferenceEquals(null, other)
                &&  this.GetType() == other.GetType()
                &&  safeEquals(value, other.value)
                &&  safeEquals(left, other.left)
                &&  safeEquals(right, other.right));
        
        public override int GetHashCode()
        {
            int tryGetHash(object obj)
                => !ReferenceEquals(null, obj) ? obj.GetHashCode() : 0;

            const int basePrime = 694847539;
            const int multiPrime = 694884683;

            unchecked
            {
                int hash = basePrime;
                hash = (hash * multiPrime) ^ tryGetHash(value);
                hash = (hash * multiPrime) ^ tryGetHash(left);
                hash = (hash * multiPrime) ^ tryGetHash(right);
                return hash;
            }
        }

        private bool safeEquals(object a, object b)
            => ReferenceEquals(null, a)
                ?   ReferenceEquals(null, b)
                :   a.Equals(b);
    }
}

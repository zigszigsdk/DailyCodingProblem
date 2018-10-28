
namespace DailyCodingProblem.Shared
{
    abstract public class ValueEquality
    {
        public static bool operator ==(ValueEquality a, object b) => 
            a is null 
                ?   b is null
                :   a.Equals(b);

        public static bool operator !=(ValueEquality a, object b) => !(a == b);

        abstract protected object[] GetHashObjects();
        abstract protected int GetBasePrimeForHashCode();
        abstract protected int GetMultiPrimeForHashCode();

        public override bool Equals(object other) => Equals(other as ValueEquality);

        public bool Equals(ValueEquality other)
            =>  ReferenceEquals(this, other)
            ||  (   !(other is null)
                &&  this.GetType() == other.GetType()
                &&  GetHashCode() == other.GetHashCode());

        public override int GetHashCode()
        {
            int HashOrZero(object obj)
                => obj is null ? 0 : obj.GetHashCode();

            int basePrime = GetBasePrimeForHashCode();
            int multiPrime = GetMultiPrimeForHashCode();

            unchecked
            {
                int hash = basePrime;
                foreach(object obj in GetHashObjects())
                    hash = (hash * multiPrime) ^ HashOrZero(obj);

                return hash;
            }
        }
    }
}

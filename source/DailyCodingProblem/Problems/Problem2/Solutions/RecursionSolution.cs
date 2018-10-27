
namespace DailyCodingProblem.Problems.Problem2.Solutions
{
    public class RecursionSolution : ISolution
    {
        public ulong[] Execute(in ushort[] input)
        {
            ulong[] result = new ulong[input.Length];
            RecursionInner(0, 1, input, ref result);
            return result;
        }

        ulong RecursionInner(ushort index, ulong productFromOuter, in ushort[] input, ref ulong[] result)
        {
            if (index == input.Length)
                return 1;
            ulong thisValue = input[index];
            ulong productFromInner = 
                RecursionInner((ushort)(index + 1), productFromOuter * thisValue, input, ref result);
            result[index] = productFromOuter * productFromInner;
            return productFromInner * thisValue;
        }
    }
}

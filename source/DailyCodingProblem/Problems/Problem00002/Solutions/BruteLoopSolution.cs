
namespace DailyCodingProblem.Problems.Problem00002.Solutions
{
    public class BruteLoopSolution : ISolution
    {
       public ulong[] Execute(in ushort[] input)
        {
            ulong[] output = new ulong[input.Length];

            for (ushort outputIndex = (ushort)(input.Length - 1); outputIndex != ushort.MaxValue; outputIndex--)
            {
                ulong product = 1;
                for (ushort inputIndex = (ushort)(input.Length - 1); inputIndex != ushort.MaxValue; inputIndex--)
                    if (inputIndex != outputIndex)
                        product *= input[inputIndex];
                output[outputIndex] = product;
            }
            return output;
        }
    }
}

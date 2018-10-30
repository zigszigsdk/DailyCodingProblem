
namespace DailyCodingProblem.Problems.Problem00002.Solutions
{
    public class AllocationReuseSolution : ISolution
    {
        public ulong[] Execute(in ushort[] input)
        {
            ulong[] ascendingProductsThenResult = new ulong[input.Length];
            ascendingProductsThenResult[0] = input[0];
            for (ushort index = 1; index < input.Length - 1; index++)
                ascendingProductsThenResult[index] = ascendingProductsThenResult[index - 1] * input[index];

            ascendingProductsThenResult[input.Length - 1] = ascendingProductsThenResult[input.Length - 2];
            ulong descendingProduct = input[input.Length - 1];

            for (ushort index = (ushort)(input.Length - 2); index > 0; index--)
            {
                ascendingProductsThenResult[index] = descendingProduct * ascendingProductsThenResult[index - 1];
                descendingProduct *= input[index];
            }
            ascendingProductsThenResult[0] = descendingProduct;

            return ascendingProductsThenResult;
        }
    }
}

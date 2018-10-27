
namespace DailyCodingProblem.Problems.Problem4.Solutions
{
    public class SortSolution : ISolution
    {
        public int Execute(int[] input)
        {
            if (input.Length == 0)
                return 1;

            for (ushort toSortIndex = 1; toSortIndex < input.Length; toSortIndex++){
                for (ushort toBackflipIndex = toSortIndex; toBackflipIndex > 0; toBackflipIndex--){
                    if (input[toBackflipIndex - 1] <= input[toBackflipIndex])
                        break;
                    int swap = input[toBackflipIndex - 1];
                    input[toBackflipIndex - 1] = input[toBackflipIndex];
                    input[toBackflipIndex] = swap;
                }
            }

            if (input[0] > 1)
                return 1;

            int highestSequentialSeen = input[0];
            for (ushort index = 1; index < input.Length; index++){
                if (highestSequentialSeen <= 0){
                    if (input[index] > 1)
                        return 1;
                }
                else
                    if (input[index] > highestSequentialSeen + 1)
                        return highestSequentialSeen + 1;
                highestSequentialSeen = input[index];
            }
            return highestSequentialSeen + 1;
        }
    }
}

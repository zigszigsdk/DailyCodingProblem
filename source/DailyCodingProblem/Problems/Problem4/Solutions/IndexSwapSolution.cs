
namespace DailyCodingProblem.Problems.Problem4.Solutions
{
    public class IndexSwapSolution : ISolution
    {
        public int Execute(int[] input)
        {
            if (input.Length == 0)
                return 1;

            for (int moveFromIndex = 0; moveFromIndex < input.Length; moveFromIndex++)
          
                //keep swapping values with the current index
                while(input[moveFromIndex] != moveFromIndex + 1 //the value is not in the right location 
                &&  input[moveFromIndex] > 0 && input[moveFromIndex] < input.Length //the value has a proper place
                &&  input[moveFromIndex] != input[input[moveFromIndex] - 1]
                    //there isn't already a duplicate correct value at the swap target location
                )
                {
                    int swap = input[input[moveFromIndex] - 1];
                    input[input[moveFromIndex] - 1] = input[moveFromIndex];
                    input[moveFromIndex] = swap;
                }

            for (int index = 0; index < input.Length; index++)
                if (input[index] != index + 1)
                    return index + 1;

            return input.Length + 1;
        }
    }
}

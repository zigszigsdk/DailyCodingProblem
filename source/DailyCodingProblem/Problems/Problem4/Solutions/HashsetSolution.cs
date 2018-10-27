
namespace DailyCodingProblem.Problems.Problem4.Solutions
{
    public class HashsetSolution : ISolution
    {
        public int Execute(int[] input)
        {
            bool[] hashset = new bool[input.Length];
            foreach (int inputValue in input)
                if(inputValue > 0 && inputValue <= input.Length)
                    hashset[inputValue-1] = true;

            for (int index = 0; index < hashset.Length; index++)
                if (hashset[index] != true)
                    return index + 1;

            return input.Length+1;
        }
    }
}

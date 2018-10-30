
namespace DailyCodingProblem.Problems.Problem00001.Solutions
{
    public class BruteforceSolution : ISolution
    {
        public bool Execute(byte[] candidates, byte target)
        {
            for (byte lowIndex = 0; lowIndex < candidates.Length - 1; lowIndex++)
                for (byte highIndex = (byte)(lowIndex + 1); highIndex < candidates.Length; highIndex++)
                    if (candidates[lowIndex] + candidates[highIndex] == target)
                        return true;
            return false;
        }
    }
}

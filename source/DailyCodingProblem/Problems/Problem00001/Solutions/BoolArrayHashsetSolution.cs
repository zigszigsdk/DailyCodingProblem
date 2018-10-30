
namespace DailyCodingProblem.Problems.Problem00001.Solutions
{
    public class BoolArrayHashsetSolution : ISolution
    {
        public bool Execute(byte[] candidates, byte target)
        {
            bool[] successCandidates = new bool[byte.MaxValue+1];
            foreach (byte candidate in candidates)
            {
                if (successCandidates[candidate] == true)
                    return true;
                successCandidates[target - candidate] = true;
            }
            return false;
        }
    }
}

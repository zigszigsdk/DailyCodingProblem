using System.Collections.Generic;

namespace DailyCodingProblem.Problems.Problem00001.Solutions
{
    public class HashsetSolution : ISolution
    {
        public bool Execute(byte[] candidates, byte target)
        {
            HashSet<byte> successCandidates = new HashSet<byte>();
            foreach (byte candidate in candidates)
            {
                if (successCandidates.Contains(candidate))
                    return true;
                successCandidates.Add((byte)(target - candidate));
            }
            return false;
        }
    }
}

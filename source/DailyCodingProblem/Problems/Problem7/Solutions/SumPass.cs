using System;

namespace DailyCodingProblem.Problems.Problem7.Solutions
{
    public class SumPass : ISolution
    {
        public int Execute(string input)
        {
            if (input.Length == 0)
                return 0;
            
            int farResult = input[input.Length-1] != '0' ? 1 : 0;
            int nearResult = (Convert.ToByte(input.Substring(input.Length-3,2)) <= 26?1:0)+farResult;
            int newResult;

            for (int index = input.Length - 3; index >= 0; index--)
            {
                newResult = input[index + 1] != '0' ? nearResult : 0;

                if(index + 2 >= input.Length || input[index+2] != '0')
                    if(Convert.ToInt16(input.Substring(index, 2)) <= 26)
                        newResult += farResult;
                
                farResult = nearResult;
                nearResult = newResult;
            }
            return nearResult;
        }
    }
}

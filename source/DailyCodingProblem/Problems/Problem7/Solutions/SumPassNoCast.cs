using System;

namespace DailyCodingProblem.Problems.Problem7.Solutions
{
    public class SumPassNoCast : ISolution
    {
        public int Execute(string input)
        {
            if (input.Length == 0)
                return 0;

            int farResult = input[input.Length - 1] != '0' ? 1 : 0;
            int nearResult = (IsValidTwoDigitNumber(input[input.Length - 2], input[input.Length - 1]) ? 1 : 0) + farResult;
            int newResult;

            for (int index = input.Length - 3; index >= 0; index--)
            {
                newResult = input[index + 1] != '0' ? nearResult : 0;

                if (index + 2 >= input.Length || input[index + 2] != '0')
                    if (IsValidTwoDigitNumber(input[index], input[index + 1]))
                        newResult += farResult;

                farResult = nearResult;
                nearResult = newResult;
            }
            return nearResult;
        }
        bool IsValidTwoDigitNumber(char near, char far)
        {
            if (near == '1')
                return true;

            if (near != '2')
                return false;

            return far <= 54; //'6';
        }
    }
}

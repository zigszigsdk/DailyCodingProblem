
namespace DailyCodingProblem.Problems.Problem00007.Solutions
{
    public class Recursion : ISolution
    {
        public int Execute(string input)
            => input.Length == 0 ? 0 : Recur(input);
        
        int Recur(string input)
        {
            if (input.Length == 0)
                return 1;

            if (input[0] == '0')
                return 0;

            if (input.Length == 1)
                return 1;

            int result = Recur(input.Substring(1));

            if (input[0] == '1' || (input[0] == '2' && System.Convert.ToInt16(input.Substring(1,1)) <= 6))
                result += Recur(input.Substring(2));

            return result;
        }
    }
}


namespace DailyCodingProblem.Problems.Problem8.Solutions
{
    struct Result
    {
        public bool? value;
        public int univals;
        public bool isUnival;
    }

    public class RecursionSolution : ISolution
    {
        public int Execute(Node root) => Inner(root).univals;

        Result Inner(Node node)
        {
            if (node == null)
                return new Result() { value = null, univals = 0, isUnival = true };

            if (node.left == null && node.right == null)
                return new Result() { value = node.value, univals = 1, isUnival = true };

            Result left = node.left == null
                ?   new Result() { value =null, univals=0, isUnival=true}
                :   Inner(node.left);

            Result right = node.right == null
                ?   new Result() { value = null, univals = 0, isUnival = true }
                :   Inner(node.right);

            bool isUnival = left.isUnival
                &&  right.isUnival
                &&  left.value == node.value
                &&  right.value == node.value;

            return new Result()
            {   value = node.value
            ,   univals = left.univals + right.univals + (isUnival ? 1 : 0)
            ,   isUnival = isUnival
            };
        }
    }
}

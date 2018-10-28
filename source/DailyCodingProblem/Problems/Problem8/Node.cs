
namespace DailyCodingProblem.Problems.Problem8
{
    public class Node
    {
        public bool value;
        public Node left;
        public Node right;

        public Node(bool value, Node left = null, Node right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}

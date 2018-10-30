using Xunit;

using DailyCodingProblem.Problems.Problem00008;

namespace DailyCodingProblem.Tests.Problems.Problem00008
{
    class Tests
    {
        public void GivenTest(ISolution solution)
        {
            /*     0
                  / \
                 1   0
                    / \
                   1   0
                  / \
                 1   1
            */
            Node root =
                new Node(false
                ,   new Node(true)
                ,   new Node(false
                    ,   new Node(true
                        ,   new Node(true)
                        ,   new Node(true)
                        )
                    ,   new Node(false)
                ));

            Assert.Equal(5, solution.Execute(root));
        }

        public void Null(ISolution solution)
         => Assert.Equal(0, solution.Execute(null));

        public void OnlyRoot(ISolution solution)
            =>  Assert.Equal(1, solution.Execute(new Node(true)));

        public void OnlyChild(ISolution solution)
        {
            /*     0
                    \
                     0
                    / \
                   1   0
                  / 
                 1   
            */
            Node root =
                new Node(false
                ,   null
                ,   new Node(false
                    ,   new Node(true
                        ,   new Node(true)
                        ,   null
                        )
                    ,   new Node(false)
                    )
                );

            Assert.Equal(2, solution.Execute(root));
        }

        public void OnlyChildWithUnivals(ISolution solution)
        {
            /*     0
                    \
                     0
                    / \
                   1   0
                  / 
                 1
                / \
               1   1
            */
            Node root =
                new Node(false
                ,   null
                ,   new Node(false
                    ,   new Node(true
                        ,   new Node(true
                            ,   new Node(true)
                            ,   new Node(true)
                            )
                        ,   null
                        )
                    ,   new Node(false)
                    )
                );

            Assert.Equal(4, solution.Execute(root));
        }

    }
}

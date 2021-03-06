﻿using Xunit;

using DailyCodingProblem.Problems.Problem00005;
using DailyCodingProblem.Problems.Problem00005.Solutions;

namespace DailyCodingProblem.Tests.Problems.Problem00005.Solutions
{
    public class SolutionTest
    {
        Solution solution = new Solution();
        
        [Fact]
        public void GivenTestCar()
            => Assert.Equal(3, solution.car(Problem.cons(3, 4)));

        [Fact]
        public void GivenTestCdr()
            => Assert.Equal(4, solution.cdr(Problem.cons(3, 4)));


    }
}

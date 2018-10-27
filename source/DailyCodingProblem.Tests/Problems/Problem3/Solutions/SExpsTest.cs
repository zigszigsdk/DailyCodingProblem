using System.Collections.Generic;
using DailyCodingProblem.Problems.Problem3.Solutions;
using Xunit;

namespace DailyCodingProblem.Tests.Problems.Problem3.Solutions
{
    public class SExpsTest
    {
        [Fact]
        public void Serialization()
            =>  Assert.Equal
                (   "null null right null null null left.left left root"
                ,   new SExpsSolution("root", new SExpsSolution("left", new SExpsSolution("left.left")), new SExpsSolution("right"))
                        .Serialize()
                );

        [Fact]
        public void Deserialization()
            =>  Assert.Equal
                (   new SExpsSolution("root", new SExpsSolution("left", new SExpsSolution("left.left")), new SExpsSolution("right"))
                ,   SExpsSolution.Deserialize("null null right null null null left.left left root")
                );

        [Fact]
        public void ValueEquality()
        {
            var sameA = new SExpsSolution("root", new SExpsSolution("left", new SExpsSolution("left.left")), new SExpsSolution("right"));
            var sameB = new SExpsSolution("root", new SExpsSolution("left", new SExpsSolution("left.left")), new SExpsSolution("right"));
            var differ = new SExpsSolution("root", new SExpsSolution("læft", new SExpsSolution("left left")), new SExpsSolution("right"));

            HashSet<SExpsSolution> hhh = new HashSet<SExpsSolution>();
            hhh.Add(sameA);

            Assert.True(sameA.Equals(sameA));
            Assert.True(sameA.Equals(sameB));
            Assert.False(sameA.Equals(differ));

            Assert.True(sameA == sameA);
            Assert.True(sameA == sameB);
            Assert.False(sameA == differ);

            Assert.Contains(sameA, hhh);
            Assert.Contains(sameB, hhh);
            Assert.DoesNotContain(differ, hhh);

        }

    }
}

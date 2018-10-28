using System.Collections.Generic;
using DailyCodingProblem.Problems.Problem3.Solutions;
using Xunit;

namespace DailyCodingProblem.Tests.Problems.Problem3.Solutions
{
    public class JsonStringTest
    {
        [Fact]
        public void Serialization()
            => Assert.Equal
            (   "{\"value\":\"root\",\"left\":{\"value\":\"left\",\"left\":{\"value\":\"left.left\",\"left\":null,\"right\":null},\"right\":null},\"right\":{\"value\":\"right\",\"left\":null,\"right\":null}}"
            ,   new JsonStringSolution("root", new JsonStringSolution("left", new JsonStringSolution("left.left")), new JsonStringSolution("right"))
                    .Serialize()
            );

        [Fact]
        public void Deserialization()
            => Assert.Equal
            (   new JsonStringSolution("root", new JsonStringSolution("left", new JsonStringSolution("left.left")), new JsonStringSolution("right"))
            ,   JsonStringSolution.Deserialize("{\"value\":\"root\",\"left\":{\"value\":\"left\",\"left\":{\"value\":\"left.left\",\"left\":null,\"right\":null},\"right\":null},\"right\":{\"value\":\"right\",\"left\":null,\"right\":null}}")
            );

        [Fact]
        public void ValueEquality()
        {
            var sameA = new JsonStringSolution("root", new JsonStringSolution("left", new JsonStringSolution("left.left")), new JsonStringSolution("right"));
            var sameB = new JsonStringSolution("root", new JsonStringSolution("left", new JsonStringSolution("left.left")), new JsonStringSolution("right"));
            var differ = new JsonStringSolution("root", new JsonStringSolution("læft", new JsonStringSolution("left left")), new JsonStringSolution("right"));

            HashSet<JsonStringSolution> hashSet = new HashSet<JsonStringSolution>();
            hashSet.Add(sameA);

            Assert.True(sameA.Equals(sameA));
            Assert.True(sameA.Equals(sameB));
            Assert.False(sameA.Equals(differ));

            Assert.True(sameA == sameA);
            Assert.True(sameA == sameB);
            Assert.False(sameA == differ);

            Assert.Contains(sameA, hashSet);
            Assert.Contains(sameB, hashSet);
            Assert.DoesNotContain(differ, hashSet);

        }

    }
}

using Newtonsoft.Json;

using DailyCodingProblem.Shared;

namespace DailyCodingProblem.Problems.Problem3.Solutions
{
    public class JsonStringSolution : BinaryTreeNode<JsonStringSolution>
    {
        public static JsonStringSolution Deserialize(string serialized)
            => JsonConvert.DeserializeObject<JsonStringSolution>(serialized);

        public JsonStringSolution(): base(""){ }

        public JsonStringSolution(string value, JsonStringSolution left = null, JsonStringSolution right = null)
            : base(value, left, right) { }

        override public string Serialize() => JsonConvert.SerializeObject(this);


    }
}

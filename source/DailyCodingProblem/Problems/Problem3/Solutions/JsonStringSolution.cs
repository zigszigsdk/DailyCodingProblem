using Newtonsoft.Json;

namespace DailyCodingProblem.Problems.Problem3.Solutions
{
    public class JsonStringSolution : Node<JsonStringSolution>
    {
        public static JsonStringSolution Deserialize(string serialized)
            => JsonConvert.DeserializeObject<JsonStringSolution>(serialized);

        public static JsonStringSolution CreateFrom<T>(Node<T> copyFrom) where T : Node<T>
            =>  new JsonStringSolution(
                    copyFrom.value
                ,   copyFrom.left  == null ? null : CreateFrom(copyFrom.left )
                ,   copyFrom.right == null ? null : CreateFrom(copyFrom.right));

        public JsonStringSolution(string value, JsonStringSolution left = null, JsonStringSolution right = null)
            : base(value, left, right) { }

        public string Serialize() => JsonConvert.SerializeObject(this);


    }
}

using Newtonsoft.Json;

namespace GraphQL_Test.Tests.Test5
{
    public class GraphQLResult
    {
        [JsonProperty("data")]
        public object Data;
    }
}

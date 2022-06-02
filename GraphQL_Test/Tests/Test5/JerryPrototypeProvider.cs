using GraphQL.NewtonsoftJson;
using GraphQL.Types;
using GraphQL_Test.Tests.Test4;
using Newtonsoft.Json;

namespace GraphQL_Test.Tests.Test5
{
    public class JerryPrototypeProvider
    {
        public string Get(string query)
        {
            var schema = new Schema
            {
                Query = new QueryJerryPrototype()
            };

            var json = schema.ExecuteAsync(_ =>
            {
                _.Query = query;
            }).Result;

            //拆掉data的部分(有必要嗎?
            return json;

            var result = JsonConvert.DeserializeObject<GraphQLResult>(json)
                                    ?.Data;
            return JsonConvert.SerializeObject(result);
        }
    }
}

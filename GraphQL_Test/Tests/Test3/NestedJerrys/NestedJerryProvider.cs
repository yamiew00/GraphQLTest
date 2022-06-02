using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace GraphQL_Test.Tests.Test3.NestedJerrys
{
    public class NestedJerryProvider
    {
        public string Get(string query)
        {
            var schema = new Schema
            {
                Query = new QueryNestedJerry()
            };

            return schema.ExecuteAsync(_ =>
            {
                _.Query = query;
            }).Result;
        }
    }
}

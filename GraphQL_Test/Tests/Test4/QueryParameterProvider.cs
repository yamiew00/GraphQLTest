using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace GraphQL_Test.Tests.Test4
{
    public class QueryParameterProvider
    {
        public string Get(string query)
        {
            var schema = new Schema
            {
                Query = new QueryParameterJerry()
            };

            return schema.ExecuteAsync(_ =>
            {
                _.Query = query;
            }).Result;
        }
    }
}

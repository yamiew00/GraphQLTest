using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace GraphQL_Test.Tests.Test2.Jerrys
{
    public class JerryProvider
    {

        public string Get(string query)
        {
            var schema = new Schema 
            {
                Query = new QueryJerry() 
            };

            return schema.ExecuteAsync(_ =>
            {
                _.Query = query;
            }).Result;
        }
    }
}

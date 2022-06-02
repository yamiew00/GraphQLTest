using GraphQL.Types;

namespace GraphQL_Test.Tests.Test2.Jerrys
{
    public class QueryJerry : ObjectGraphType
    {
        private List<Jerry> List = new List<Jerry>
        {
            new Jerry
            {
                Name = "Jerry",
                Age = 8
            },
            new Jerry
            {
                Name = "Jerry2",
                NickName = "two"
            }
        };

        public QueryJerry()
        {
            Field<ListGraphType<JerryType>>("jerryTest",
                             resolve: context => List);
        }
    }
}

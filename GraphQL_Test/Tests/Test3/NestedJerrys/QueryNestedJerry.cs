using GraphQL.Types;

namespace GraphQL_Test.Tests.Test3.NestedJerrys
{
    public class QueryNestedJerry : ObjectGraphType
    {
        private List<NestedJerry> List = new List<NestedJerry>
        {
            new NestedJerry
            {
                Name = "Jerry1",
                BirthDate = DateTime.Now,
                JerryInfo = new JerryInfo
                {
                    Height = 176,
                    Width = 75
                }
            }
        };

        public QueryNestedJerry()
        {
            Field<ListGraphType<NestedJerryType>>("jerrys", resolve: context => List);
        }
    }
}

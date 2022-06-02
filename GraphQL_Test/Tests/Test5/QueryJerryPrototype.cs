using GraphQL.Types;

namespace GraphQL_Test.Tests.Test5
{
    public class QueryJerryPrototype : ObjectGraphType
    {
        public QueryJerryPrototype()
        {
            Field<JerryPrototypeType>(Name = "jerry",
                  resolve: context => new JerryPrototype
                  {
                      Name = "123",
                      Id = 3
                  });
        }
    }
}

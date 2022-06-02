using GraphQL.Types;

namespace GraphQL_Test.Tests.Test5
{
    public class JerryPrototype
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }

    public class JerryPrototypeType: ObjectGraphType<JerryPrototype>
    {
        public JerryPrototypeType()
        {
            Field(jerry => jerry.Name);
            Field(jerry => jerry.Id);
        }
    }
}

using GraphQL.Types;

namespace GraphQL_Test.Tests.Test4
{
    public class ParameterJerry
    {
        public string? Name { get; set; }

        public int Age { get; set; }
    }

    public class ParameterJerryType: ObjectGraphType<ParameterJerry>
    {
        public ParameterJerryType()
        {
            Field(jerry => jerry.Name);
            Field(jerry => jerry.Age);
        }
    }
}

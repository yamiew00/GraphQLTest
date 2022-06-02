using GraphQL.Types;

namespace GraphQL_Test.Tests.Test2.Jerrys
{
    public class Jerry
    {
        public string? Name { get; set; }

        public string? NickName { get; set; }

        public int? Age { get; set; }
    }

    public class JerryType : ObjectGraphType<Jerry>
    {
        public JerryType()
        {
            Field(name: "theName", 
                  expression: jerry => jerry.Name);

            Field(jerry => jerry.NickName, type: typeof(StringGraphType));
            Field(jerry => jerry.Age, type: typeof(IntGraphType));
        }
    }
}

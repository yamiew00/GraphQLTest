using GraphQL.Types;

namespace GraphQL_Test.Tests.Test3.NestedJerrys
{
    public class JerryInfo
    {
        public int Height { get; set; }

        public int? Width { get; set; }
    }

    public class JerryInfoType: ObjectGraphType<JerryInfo>
    {
        public JerryInfoType()
        {
            Field(jerryInfo => jerryInfo.Height,
                  type: typeof(IntGraphType));
            Field(jerryInfo => jerryInfo.Width,
                  type: typeof(IntGraphType));
        }
    }
}

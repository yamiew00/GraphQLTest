using GraphQL.Types;

namespace GraphQL_Test.Tests.Test3.NestedJerrys
{
    public class NestedJerry
    {
        public string? Name { get; set; }

        public JerryInfo? JerryInfo { get; set; }

        public DateTime BirthDate { get; set; }
    }

    public class NestedJerryType : ObjectGraphType<NestedJerry>
    {
        public NestedJerryType()
        {
            Field("name", nestedJerry => nestedJerry.Name);

            Field("info", 
                  nestedJerry => nestedJerry.JerryInfo, 
                  type: typeof(JerryInfoType));

            Field("birthday", nestedJerry => nestedJerry.BirthDate);
        }
    }
}

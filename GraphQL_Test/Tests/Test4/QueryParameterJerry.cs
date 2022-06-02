using GraphQL;
using GraphQL.Types;

namespace GraphQL_Test.Tests.Test4
{
    public class QueryParameterJerry: ObjectGraphType
    {
        public List<ParameterJerry> List = new List<ParameterJerry>
        {
            new ParameterJerry
            {
                Name = "1",
                Age = 3
            },
            new ParameterJerry
            {
                Name = "2",
                Age = 30
            }
        };

        public QueryParameterJerry()
        {
            Field<ListGraphType<ParameterJerryType>>(name: "paraJerry",
                                                     arguments: new QueryArguments(new QueryArgument<IntGraphType>
                                                     {
                                                         Name = "age"
                                                     },
                                                     new QueryArgument<StringGraphType>
                                                     {
                                                         Name = "name"
                                                     }),
                                                     resolve: context =>
                                                     {
                                                         var age = context.GetArgument<int?>("age");
                                                         var name = context.GetArgument<string?>("name");
                                                         IEnumerable<ParameterJerry> result = List;

                                                         if(age != null)
                                                         {
                                                             result = result.Where(item => item.Age == age);
                                                         }
                                                         if(name != null)
                                                         {
                                                             result = result.Where(item => item.Name == name);
                                                         }
                                                         return result;
                                                     });
        }
    }
}

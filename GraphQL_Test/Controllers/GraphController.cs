using GraphQL.NewtonsoftJson;
using GraphQL.Types;
using GraphQL_Test.Controllers.RequestBodys;
using GraphQL_Test.Graphs;
using GraphQL_Test.Tests.Test2.Jerrys;
using GraphQL_Test.Tests.Test3.NestedJerrys;
using GraphQL_Test.Tests.Test4;
using GraphQL_Test.Tests.Test5;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphController : ControllerBase
    {
        private Schema Schema;

        public GraphController()
        {
            Schema = Schema.For(@"
              type Query {
                  hello: String,
                  jedis: [Jedi],
                  jedi(sides: [String], id: ID): [Jedi]
              }

              type Jedi {
                  #comment here
                  name: String,
                  side: String,
                  id: ID
              }
            ", _ =>
            {
                _.Types.Include<Query>();
            });
        }

        [HttpPost(Name = "Test1")]
        public IActionResult Get(Test1Body test1Body)
        {
            var query = test1Body.Query;

            var json = Schema.ExecuteAsync(_ =>
            {
                _.Query = query;
            }).Result;

            return Ok(json);
        }

        [HttpPost("Test2")]
        public IActionResult Get2(Test2Body test2Body)
        {
            JerryProvider jerryProvider = new JerryProvider();
            var result = jerryProvider.Get(test2Body.Query);
            return Ok(result);
        }

        [HttpPost("Test3")]
        public IActionResult Get3(Test3Body test3Body)
        {
            NestedJerryProvider nestedJerryProvider = new NestedJerryProvider();
            var result = nestedJerryProvider.Get(test3Body.Query);
            return Ok(result);
        }

        [HttpPost("Test4")]
        public IActionResult Get4(Test4Body test4Body)
        {
            QueryParameterProvider queryParamterProvider = new QueryParameterProvider();
            var result = queryParamterProvider.Get(test4Body.Query);
            return Ok(result);
        }

        [HttpPost("Test5")]
        public IActionResult Get5(Test5Body test5Body)
        {
            JerryPrototypeProvider jerryPrototypeProvider = new JerryPrototypeProvider();
            var result = jerryPrototypeProvider.Get(test5Body.Query);
            return Ok(result);
        }
    }
}
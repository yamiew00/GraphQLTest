using GraphQL;

namespace GraphQL_Test.Graphs
{
    public class Query
    {
        private List<Jedi> List = new List<Jedi>() {
            new Jedi() {Id = 1, Name = "Luke", Side = "Light"},
            new Jedi() {Id = 2,  Name = "Yoda", Side = "Light"},
            new Jedi() {Id = 3,  Name = "Darth Vader", Side = "Dark"}
        };


        public Query()
        {

        }

        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return List;
        }

        [GraphQLMetadata("jedi")]
        public IEnumerable<Jedi> GetJedi(IEnumerable<string> sides, int? id)
        {
            if (id.HasValue) return List.Where(item => sides.Contains(item.Side) && item.Id == id);
            return List.Where(item => sides.Contains(item.Side));

        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Hello Query class";
        }
    }
}

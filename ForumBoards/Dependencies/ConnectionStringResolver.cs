using ForumBoards.Core.Resolvers;

namespace API.Client.Dependencies
{
    public class ConnectionStringResolver : IConnectionStringResolver
    {
        private readonly IConfiguration _config;

        public ConnectionStringResolver(IConfiguration config)
        {
            _config = config;
        }
        public string Resolve()
        {
            return _config.GetConnectionString("Default");
        }
    }
}

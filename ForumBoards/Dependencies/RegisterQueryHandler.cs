using ForumBoards.Core.Generics;
using ForumBoards.Core.Queries;
using ForumBoards.Core.Resolvers;
using ForumBoards.Core.Results;
using ForumBoards.QueryHandlers.Models.Abstraction;
using ForumBoards.QueryHandlers.Models.Posts;

namespace API.Client.Dependencies
{
    public static class QueryHandlerRegistrar
    {
        public static void RegisterQueryHandler(this IServiceCollection services) {

            services.AddTransient<IHandleQuery<PostRequestQuery, QueryResult<IEnumerable<PostRequestResult>>>, PostQueryHandler>();
            services.AddTransient<IConnectionStringResolver, ConnectionStringResolver>();
        }
    }
}

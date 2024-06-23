using ForumBoards.APIClient.Models;
using ForumBoards.Core.Generics;
using ForumBoards.Core.Models.Abstraction;
using ForumBoards.Core.Queries;
using ForumBoards.Core.Repositories;
using ForumBoards.Core.Resolvers;
using ForumBoards.Core.Results;
using ForumBoards.DataAccess.Repositories;
using ForumBoards.Infrastructure.Factory;
using ForumBoards.QueryHandlers.Models.Abstraction;
using ForumBoards.QueryHandlers.Models.Posts;

namespace API.Client.Dependencies
{
    public static class RepositoryRegistrar
    {
        public static void RegisterRepositories(this IServiceCollection services) {

            services.AddTransient<IPostRepository, PostRepository>(); ;
        }
    }
}

using ForumBoards.APIClient.Models;
using ForumBoards.Core.Generics;
using ForumBoards.Core.Models.Abstraction;
using ForumBoards.Core.Queries;
using ForumBoards.Core.Resolvers;
using ForumBoards.Core.Results;
using ForumBoards.Infrastructure.Factory;
using ForumBoards.QueryHandlers.Models.Abstraction;
using ForumBoards.QueryHandlers.Models.Posts;

namespace API.Client.Dependencies
{
    public static class FactoryRegistrar
    {
        public static void RegisterFactories(this IServiceCollection services) {

            services.AddTransient<IModelFactory<PostRequestModel, PostRequestResult>, PostModelFactory>();
        }
    }
}

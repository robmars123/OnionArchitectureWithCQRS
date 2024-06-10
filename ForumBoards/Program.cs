using API.Client.Dependencies;
using ForumBoards.APIClient.Models;
using ForumBoards.Core.Models.Abstraction;
using ForumBoards.Core.Repositories;
using ForumBoards.Core.Results;
using ForumBoards.DataAccess.Repositories;
using ForumBoards.Infrastructure.Factory;

namespace ForumBoards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Register Dependencies
            builder.Services.RegisterQueryHandler();

            // Add services to the container.
            //dependency injection
            builder.Services.AddTransient<IPostRepository, PostRepository>();

            //Factory
            builder.Services.AddTransient<IModelFactory<PostRequestModel, PostRequestResult>, PostModelFactory>();


            builder.Services.AddControllers();

            var app = builder.Build();


            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

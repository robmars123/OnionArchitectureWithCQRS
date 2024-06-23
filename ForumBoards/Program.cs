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
            builder.Services.RegisterFactories();
            builder.Services.RegisterRepositories();

            // Add services to the container.            

            builder.Services.AddControllers();
            builder.Services.AddHttpClient();

            var app = builder.Build();


            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

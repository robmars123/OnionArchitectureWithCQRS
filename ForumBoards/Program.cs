using API.Client.Dependencies;
using ForumBoards.Core.Repositories;
using ForumBoards.DataAccess.Repositories;

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

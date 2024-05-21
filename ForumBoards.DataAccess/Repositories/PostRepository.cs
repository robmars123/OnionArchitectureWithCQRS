using Dapper;
using ForumBoards.Core.Generics;
using ForumBoards.Core.Models;
using ForumBoards.Core.Repositories;
using ForumBoards.Core.Resolvers;
using ForumBoards.Core.Results;
using ForumBoards.DataAccess.Mapper;
using Microsoft.Data.SqlClient;

namespace ForumBoards.DataAccess.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IConnectionStringResolver _connectionStringResolver;

        public PostRepository(IConnectionStringResolver connectionStringResolver)
        {
            _connectionStringResolver = connectionStringResolver;
        }

        private SqlConnection GetSqlConnection()
        {
            string connString =  _connectionStringResolver.Resolve();
            return new SqlConnection(connString);
        }
        public IEnumerable<PostRequestResult> GetPosts()
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                var result = connection.Query<Post>("GetPosts", null, commandType: System.Data.CommandType.StoredProcedure);

                return result.Select(PostMapper.Map);
            }
        }
    }
}

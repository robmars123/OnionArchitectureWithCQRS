using Dapper;
using ForumBoards.Core.Generics;
using ForumBoards.Core.Models;
using ForumBoards.Core.Repositories;
using ForumBoards.Core.Resolvers;
using ForumBoards.Core.Results;
using ForumBoards.DataAccess.Constants;
using ForumBoards.DataAccess.Mapper;
using Microsoft.Data.SqlClient;
using System.Data;

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
        public List<PostRequestResult> GetPosts()
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                //parameters.Add(StoredProcedureConstants.Parameters.Id, 1);

                var result = connection.QueryAsync<Post>(sql: StoredProcedureConstants.GetPosts, 
                                                        parameters,
                                                        commandType: CommandType.StoredProcedure);

                return result.Result.Select(PostMapper.Map).ToList();
            }
        }
    }
}

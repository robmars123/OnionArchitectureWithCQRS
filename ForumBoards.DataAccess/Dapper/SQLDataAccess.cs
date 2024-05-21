//using Dapper;
//using ForumBoards.DataAccess.Dapper.Abstraction;
//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
//using System.Data;

//namespace ForumBoards.DataAccess.Dapper
//{
//    public class SQLDataAccess : ISQLDataAccess
//    {
//		private readonly IConfiguration _config;

//		public string ConnectionStringName { get; set; } = "Default";
//        public SQLDataAccess(IConfiguration config)
//        {
//            _config = config;
//		}
//        /// <summary>
//        /// Get list of object. Re-usable method.
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <typeparam name="U"></typeparam>
//        /// <param name="sql"></param>
//        /// <param name="parameters"></param>
//        /// <returns></returns>
//        public async Task<List<T>> GetList<T>(T parameters)
//        {
//            string connectionString = _config.GetConnectionString(ConnectionStringName);

//            using (IDbConnection connection = new SqlConnection(connectionString))
//            {
//                var data = await connection.QueryAsync<T>(parameters);
//                return data.ToList();
//            }
//        }

//        public async Task<int> InsertData<T>(string sql, T parameters)
//        {
//			return await Save(sql, parameters);
//		}

//        public async Task DeleteData<T>(string sql, T parameters)
//        {
//			await Save(sql, parameters);
//		}

//		public async Task UpdateData<T>(string sql, T parameters)
//		{
//            await Save<T>(sql, parameters);
//		}

//        public async Task<List<T>> SearchData<T, U>(string sql, U parameters)
//        {
//			string connectionString = _config.GetConnectionString(ConnectionStringName);

//			using (IDbConnection connection = new SqlConnection(connectionString))
//			{
//				var data = await connection.QueryAsync<T>(sql, parameters);
//				return data.ToList();
//			}
//		}

//		private async Task<int> Save<T>(string sql, T parameters)
//        {
//            int id = 0;
//			string connectionString = _config.GetConnectionString(ConnectionStringName);

//			using (IDbConnection connection = new SqlConnection(connectionString))
//			{
//				id = connection.ExecuteScalar<int>(sql, parameters);
//			}
//            return id;
//		}
//        /// <summary>
//        /// Get single object
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <typeparam name="U"></typeparam>
//        /// <param name="sql"></param>
//        /// <param name="parameters"></param>
//        /// <returns></returns>
//        public async Task<T> GetData<T, U>(string sql, U parameters)
//        {
//            string connectionString = _config.GetConnectionString(ConnectionStringName);

//            using (IDbConnection connection = new SqlConnection(connectionString))
//            {
//                var data = await connection.QueryAsync<T>(sql, parameters);
//                return data.FirstOrDefault();
//            }
//        }
//    }
//}

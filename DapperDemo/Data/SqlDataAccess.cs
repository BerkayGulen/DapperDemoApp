﻿using DapperDemo.Entity;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace Dapper.Data
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(
            string storedPrecedure,
            U parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(storedPrecedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(
            string storedPrecedure,
            T parameters,
            string connectionId = "Default")

        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            var result = await connection.QuerySingleOrDefaultAsync(storedPrecedure, parameters, commandType: CommandType.StoredProcedure);
            var json = JsonConvert.SerializeObject(result);
            Customer person = JsonConvert.DeserializeObject<Customer>(json);

        }
    }
}

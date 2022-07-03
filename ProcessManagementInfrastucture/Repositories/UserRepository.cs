using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using ProcessManagementApplication.Interfaces;
using ProcessManagementCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementInfrastucture.Repositories
{
    public class UserRepository : IUserRepository
    {
        //private readonly IConfiguration _configuration;
        private string connectionString;
        private NpgsqlConnection connection;
        public UserRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("ProcessDB");
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
            //_configuration = configuration;
        }

        public async Task<int> Add(User entity)
        {
            var sqlQuery = "INSERT INTO public.user(name) VALUES (@Name)";
            var result = await connection.ExecuteAsync(sqlQuery, entity);
            return result;
        }

        public async Task<int> Delete(int id)
        {
            var sqlQuery = "DELETE FROM user Where id=@Id";
            var result = await connection.ExecuteAsync(sqlQuery, new {Id=id});
            return result;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var sqlQuery = "SELECT * FROM public.user";
            var result = await connection.QueryAsync<User>(sqlQuery);
            return result;
        }

        public async Task<User> GetById(int id)
        {
            var sqlQuery = "SELECT * FROM public.user Where id=@ID";
            var result = await connection.QueryAsync<User>(sqlQuery, new { Id = id });
            return result.FirstOrDefault();
        }

        public async Task<int> Update(User entity)
        {
            var sqlQuery = "UPDATE public.user SET INTO name=@Name";
            var result= await connection.ExecuteAsync(sqlQuery, entity);
            return result;
        }
    }
}

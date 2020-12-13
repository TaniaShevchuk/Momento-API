using System;
using System.Linq;
using App.Domain;
using App.DomainPostgreSql.Common;
using App.DomainPostgreSql.Contracts;
using Dapper;
using Npgsql;

namespace App.DomainPostgreSql
{
    public class AppUserData: BaseData, IAppUserData
    {
        public User GetUser()
        {
            var user = new User();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    user = conn.Query<User>($"Select * from dbo.AppUser;").FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return user;
        }


        public User GetUserById(long userId)
        {
            var user = new User();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    user = conn.Query<User>($"Select firstname, friends, imageUri, lastname, nickname, userId from dbo.AppUser where userId = {userId};").FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return user;
        }
    }
}

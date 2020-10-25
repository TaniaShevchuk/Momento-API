using System;
using System.Linq;
using App.Domain;
using App.DomainContract;
using App.DomainPostgreSql.Common;
using Dapper;
using Npgsql;

namespace App.DomainPostgreSql
{
    public class AppUserData: BaseData
    {
        public AppUserData(IAppSettings settings) : base(settings) { }

        public User GetUser()
        {
            var user = new User();
            using (var conn = new NpgsqlConnection(settings.PostgreSqlConnectionString))
            {
                try
                {
                    conn.Open();
                    user = conn.Query<User>("Select * from dbo.AppUser;").FirstOrDefault();
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

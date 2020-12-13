using System;
using System.Collections.Generic;
using System.Linq;
using App.Domain;
using App.DomainContract;
using App.DomainPostgreSql;
using App.DomainPostgreSql.Common;
using App.DomainPostgreSql.Contracts;
using App.DomainService.Common;
using Dapper;
using Npgsql;

namespace App.DomainService
{
    public class AuthSvc : BaseSvc, IAuthSvc
    {
        public AuthSvc(IAppSettings settings, IDataFactory dataFactory) : base(settings, dataFactory) { }

        public AppResponse<User> AuthenticateUser(string email, string password)
        {
            var userData = dataFactory.GetInstance<IAppUserData>();
            userData.Load(GetConnectionString);

            var user = userData.GetUser();

            return new AppResponse<User>(true, user);
        }
    }
}

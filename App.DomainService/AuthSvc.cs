using System;
using System.Collections.Generic;
using System.Linq;
using App.Domain;
using App.DomainContract;
using App.DomainPostgreSql;
using App.DomainService.Common;
using Dapper;
using Npgsql;

namespace App.DomainService
{
    public class AuthSvc : BaseSvc, IAuthSvc
    {
        public AuthSvc(IAppSettings settings) : base(settings) { }

        public AppResponse<User> AuthenticateUser(string email, string password)
        {
            var user = new AppUserData(settings).GetUser();

            return new AppResponse<User>(true, user);
        }
    }
}

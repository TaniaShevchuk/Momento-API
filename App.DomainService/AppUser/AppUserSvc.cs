using App.Domain;
using App.DomainContract;
using App.DomainPostgreSql.Common;
using App.DomainPostgreSql.Contracts;
using App.DomainService.Common;

namespace App.DomainService.AppUser
{
    public class AppUserSvc : BaseSvc, IAppUserSvc
    {
        public AppUserSvc(IAppSettings settings, IDataFactory dataFactory) : base(settings, dataFactory) { }


        public AppResponse<User> GetUserById(long userId)
        {
            var userData = dataFactory.GetInstance<IAppUserData>();
            userData.Load(GetConnectionString);

            var user = userData.GetUserById(userId);

            return new AppResponse<User>(true, user);
        }
    }
}
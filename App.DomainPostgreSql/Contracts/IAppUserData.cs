using App.Domain;
using App.DomainPostgreSql.Common;

namespace App.DomainPostgreSql.Contracts
{
    public interface IAppUserData : IData<string>
    {
        User GetUser();
        User GetUserById(long userId);
    }
}

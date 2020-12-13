using App.Domain;

namespace App.DomainContract
{
    public interface IAppUserSvc
    {
        AppResponse<User> GetUserById(long userId);
    }
}
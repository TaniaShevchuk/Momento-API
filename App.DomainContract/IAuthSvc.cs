using App.Domain;

namespace App.DomainContract
{
    public interface IAuthSvc
    {
        AppResponse<User> AuthenticateUser(string email, string password);
    }
}

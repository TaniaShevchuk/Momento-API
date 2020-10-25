using App.DomainContract;

namespace App.DomainService.Common
{
    public class BaseSvc
    {
        protected readonly IAppSettings settings;

        protected BaseSvc(IAppSettings settings)
        {
            this.settings = settings;
        }
    }
}


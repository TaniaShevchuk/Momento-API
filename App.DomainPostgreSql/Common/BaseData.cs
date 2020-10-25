using App.DomainContract;

namespace App.DomainPostgreSql.Common
{
    public class BaseData
    {
        protected readonly IAppSettings settings;

        public BaseData(IAppSettings settings)
        {
            this.settings = settings;
        }
    }
}

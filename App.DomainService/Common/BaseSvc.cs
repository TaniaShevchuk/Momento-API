using App.DomainContract;
using App.DomainPostgreSql.Common;

namespace App.DomainService.Common
{
    public class BaseSvc
    {
        protected readonly IAppSettings settings;
        protected readonly IDataFactory dataFactory;

        protected BaseSvc(IAppSettings settings, IDataFactory dataFactory)
        {
            this.settings = settings;
            this.dataFactory = dataFactory;
        }


        public string GetConnectionString => settings.PostgreSqlConnectionString;

    }
}


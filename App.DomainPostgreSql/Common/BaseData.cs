using App.DomainContract;

namespace App.DomainPostgreSql.Common
{
    public class BaseData
    {
        protected readonly IAppSettings settings;
        public string connectionString;

        public BaseData() { }

        public BaseData(IAppSettings settings)
        {
            this.settings = settings;
        }

        public void Load(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

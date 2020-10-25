using App.DomainContract;

namespace App.DomainService.Common
{
    public class AppSettings: IAppSettings
    {
        public string PostgreSqlConnectionString { get; set; }
    }
}

using App.DomainPostgreSql.Common;
using App.DomainPostgreSql.Contracts;

namespace UnitTests.Mocks
{
    public class MockDataFactory : IDataFactory
    {
        public PostgresAppUserMock PostgresAppUserMock;

        public MockDataFactory()
        {
            PostgresAppUserMock = new PostgresAppUserMock();
        }

        public T GetInstance<T>()
        {
            if (typeof(T) == typeof(IAppUserData))
            {
                return (T) (PostgresAppUserMock).Object;
            }

            return default;
        }
    }
}
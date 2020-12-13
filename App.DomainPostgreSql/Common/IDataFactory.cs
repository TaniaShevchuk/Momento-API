namespace App.DomainPostgreSql.Common
{
    public interface IDataFactory
    {
        public T GetInstance<T>();
    }
}

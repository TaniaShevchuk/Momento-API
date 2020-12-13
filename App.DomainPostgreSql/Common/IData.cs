namespace App.DomainPostgreSql.Common
{
    public interface IData<in T>
    {
        void Load(T settings);
    }
}

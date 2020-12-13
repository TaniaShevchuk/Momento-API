using System;
using System.Collections.Generic;
using App.DomainPostgreSql;
using App.DomainPostgreSql.Common;
using App.DomainPostgreSql.Contracts;

namespace App.DomainRepository
{
    public class DataFactory : IDataFactory
    {
        private readonly Dictionary<Type, Type> _map = new Dictionary<Type, Type>()
        {
            {typeof(IAppUserData), typeof(AppUserData)}
        };

        public DataFactory() { }

        public DataFactory(Dictionary<Type, Type> map)
        {
            _map = map;
        }

        public T GetInstance<T>()
        {
            return (T)Activator.CreateInstance(_map[typeof(T)]);
        }
    }
}
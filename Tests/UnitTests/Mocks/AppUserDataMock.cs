using System;
using System.Collections.Generic;
using System.Text;
using App.Domain;
using App.DomainPostgreSql.Contracts;
using Moq;
using UnitTests.DataHelpers;

namespace UnitTests.Mocks
{
    public class AppUserDataMock
    {
        private readonly Mock<IAppUserData> mock;

        public IAppUserData Object => mock?.Object;
        public List<User> Users { get; set; }

        public AppUserDataMock()
        {
            Users = DataProvider.GetData<User>();

            mock = new Mock<IAppUserData>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Domain;
using App.DomainPostgreSql.Contracts;
using Moq;
using UnitTests.DataHelpers;

namespace UnitTests.Mocks
{
    public class PostgresAppUserMock
    {
        private readonly Mock<IAppUserData> mock;

        public IAppUserData Object => mock?.Object;
        public List<User> Users { get; set; }

        // Maybe data in constructor?
        public PostgresAppUserMock()
        {
            Users = DataProvider.GetData<User>();

            mock = new Mock<IAppUserData>();

            // GetUserById
            mock.Setup(d => d.GetUserById(It.IsAny<long>()))
                .Returns((long userId) => Users.FirstOrDefault(a => a.UserId == userId));

        }
    }
}

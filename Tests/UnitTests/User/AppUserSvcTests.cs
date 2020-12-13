using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.DomainContract;
using App.DomainService;
using App.DomainService.AppUser;
using App.DomainService.Common;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.Auth
{
    public class AppUserSvcTests
    {
        private MockDataFactory dataFactory;
        private IAppUserSvc appUserSvc;

        public AppUserSvcTests()
        {
            var settings = new AppSettings();

            dataFactory = new MockDataFactory();

            appUserSvc = new AppUserSvc(settings, dataFactory);
        }

        [Theory]
        [InlineData(1)]

        public void GetUserById_Success(long userId)
        {
            var expectedAppUser = dataFactory.PostgresAppUserMock.Users.First(it => it.UserId == userId);

            var userResponse = appUserSvc.GetUserById(userId);
            Assert.True(userResponse.Success);
            Assert.NotNull(userResponse.Result);

            var actualAppUser = userResponse.Result;
            Assert.Equal(expectedAppUser, actualAppUser);
        }

    }
}

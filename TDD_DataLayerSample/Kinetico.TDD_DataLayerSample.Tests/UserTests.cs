using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Kinetico.TDD_DataLayerSample.Gateway.Interfaces;
using Kinetico.TDD_DataLayerSample.Gateway.Entities;
using Kinetico.TDD_DataLayerSample.Gateway.Facade;

namespace Kinetico.TDD_DataLayerSample.Tests
{
    [TestFixture]
    public class UserTests
    {
        private IUserRepository _userRepositoryInstance;

        [SetUp]
        public void SetupTest()
        {
            _userRepositoryInstance = new InMemoryUserRepository();

            // add the "ewise" user to the 'database'
            _userRepositoryInstance.Save(
                new User()
                {
                    UserName = "ewise",
                    FirstName = "Eric",
                    LastName = "Wise"
                });
        }

        [Test]
        public void UsernameExists()
        {
            UserFacade facade = new UserFacade(_userRepositoryInstance);

            string userNameThatShouldExist = "ewise";
            string usernameThatShouldNotExist = "mvoronkin";

            Assert.IsTrue(
            facade.UsernameExists(userNameThatShouldExist),
                "User name should exist.");

            Assert.IsFalse(
           facade.UsernameExists(usernameThatShouldNotExist),
                "User name should not exist.");
        }
    }
}

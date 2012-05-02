using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinetico.TDD_DataLayerSample.Gateway.Entities;
using Kinetico.TDD_DataLayerSample.Gateway.Interfaces;

namespace Kinetico.TDD_DataLayerSample.Gateway.Facade
{
    public class UserFacade
    {
        private IUserRepository _repositoryInstance;

        // This is constructor injection, the easiest way to do dependency injection
        public UserFacade(IUserRepository repository)
        {
            _repositoryInstance = repository;
        }

        public bool UsernameExists(string username)
        {
            User user = _repositoryInstance.GetByUserName(username);

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

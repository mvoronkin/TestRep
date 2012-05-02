using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinetico.TDD_DataLayerSample.Gateway.Entities;
using Kinetico.TDD_DataLayerSample.Gateway.Interfaces;

namespace Kinetico.TDD_DataLayerSample.Tests
{
    public class InMemoryUserRepository : RepositoryMock<User>, IUserRepository
    {
        public InMemoryUserRepository()
        {

        }

        public User GetByUserName(string username)
        {
            if (username == null)
            {
                return null;
            }
            else
            {
                // Items is an instance of List<User> 
                User match = (from user in Items
                              where user.UserName == username
                              select user).FirstOrDefault();

                return match;
            }
        }
    }
}

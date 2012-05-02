using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinetico.TDD_DataLayerSample.Gateway.Entities;

namespace Kinetico.TDD_DataLayerSample.Gateway.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUserName(string username);
    }
}

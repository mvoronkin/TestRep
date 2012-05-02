using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinetico.TDD_DataLayerSample.Gateway.Interfaces;

namespace Kinetico.TDD_DataLayerSample.Gateway.Entities
{
    public class User : IInt32Id
    {
        public User()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}
